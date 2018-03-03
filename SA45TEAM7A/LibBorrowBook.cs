using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace SA45TEAM7A
{

    public partial class LibBorrowBook : Form
    {
        LibrarySevenAEntities context = new LibrarySevenAEntities();
        List<string> borrowedBookListstr = new List<string>();
        List<Int32> borrowedBookList = new List<Int32>();
        int count = 1;
        int currentBookLimit;
        short memberID;


        public LibBorrowBook()
        {
            InitializeComponent();
        }
        private void LibBorrowBook_Load(object sender, EventArgs e)
        {
            dGVBorrow.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                memberID = Convert.ToInt16(txtMemberID.Text);
                Member k = context.Members.Where(x => x.MemberID == memberID).First();
                if (k.Password == txtPassWord.Text)
                {
                    txtBorrowBookID.BackColor = SystemColors.Window;
                    txtBorrowBookID.ReadOnly = false;
                    lblPasswordError.Text = "";
                    currentBookLimit = bookLimitTest();
                    txtMemberType.Text = k.MemberType;
                    txtMemberID.Enabled = false;
                    txtPassWord.Enabled = false;
                    btnLogIn.Enabled = false;
                    txtBorrowBookID.Enabled = true;
                }
                else
                {
                    lblPasswordError.Text = "Wrong Password";
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is InvalidOperationException) {
                    lblMemberIDError.Text = "Incorrect User ID";
                    return;
                }
            }
        }

        private void txtBorrowBookID_TextChanged(object sender, EventArgs e)
        {//check for booklimit
            if (currentBookLimit > 0)
            {
                if (txtBorrowBookID.TextLength == 10 && !borrowedBookListstr.Contains(txtBorrowBookID.Text))
                {
                    try
                    {
                        int borrowbookID = Convert.ToInt32(txtBorrowBookID.Text);
                        //if books has already been borrowed, can't borrow it. Resource intensive search place after simple check.
                        if (!context.books.Where(x => x.BookID == borrowbookID).First().LoanStatus)
                        {
                            borrowedBookListstr.Add(txtBorrowBookID.Text);
                            txtBorrowError.Text = "";
                            string Title = context.books.Where(x => x.BookID == borrowbookID).First().BookTitle;
                            dGVBorrow.Rows.Add(count, Title, DateTime.Today.AddDays(21).ToString("dd/MM/yyyy"));
                            borrowedBookList.Add(borrowbookID);
                            txtBorrowBookID.Text = "";
                            count++;
                            currentBookLimit--;
                            btnlibEndDontPrint.Enabled = true;
                            btnlibEndPrint.Enabled = true;
                        }
                        else
                        {
                            txtBorrowError.Text = "Book has already been borrowed. Please check";
                            txtBorrowBookID.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex is InvalidOperationException || ex is OverflowException)
                        {
                            txtBorrowError.Text = "Book not found. Please try again.";
                            txtBorrowBookID.Text = "";
                        }
                        else if (ex is FormatException)
                        {
                            txtBorrowError.Text = "Wrong Input. Please try again.";
                            txtBorrowBookID.Text = "";
                        }

                    }
                }
                else if (borrowedBookListstr.Contains(txtBorrowBookID.Text))
                {
                    txtBorrowError.Text = "Item has been scanned/borrowed. Please check.";
                    txtBorrowBookID.Text = "";

                }
            }else
            {
                txtBorrowError.Text = "You have exceed the number of borrowed items";
                txtBorrowBookID.Text = "";
                txtBorrowBookID.ReadOnly = true;
            }
        }




        private void printReceipt()
        {
            CRformReceipt cFR = new CRformReceipt(C.transactionNo);
            cFR.Show();
        }

       
        private void addTransaction()
        {
            BookTransaction bt = new BookTransaction();
            bt.DateIssue = DateTime.Today.Date;
            bt.OriginalDateDue = DateTime.Today.AddDays(21).Date;
            bt.MemberID = memberID;
            context.BookTransactions.Add(bt);
            context.SaveChanges();
            C.transactionNo = bt.TransactionID;
        }
        private void addTransactionDetails()
        {
            for (int i = 0; i < borrowedBookList.Count; i++)
            {
                BookTransDetail k = new BookTransDetail();
                k.TransactionID = C.transactionNo;
                k.BookID = borrowedBookList[i];
                k.DateDue = DateTime.Today.AddDays(21).Date;
                k.RentalStatus = false;
                context.BookTransDetails.Add(k);
            }
        }

        private void updateBookLoanstatus()
        {
            for (int i = 0; i < borrowedBookList.Count; i++)
            {
                int j = borrowedBookList[i];
                book k = context.books.Where(x => x.BookID == j).First();
                k.LoanStatus = true;
            }
        }

        private void updateBookInventory()
        {
            for (int i = 0; i < borrowedBookList.Count; i++)
            {
                int j = borrowedBookList[i];
                string bookISBN = context.books.Where(x => x.BookID == j).First().ISBN;
                BookInventory k = context.BookInventories.Where(x => x.ISBN == bookISBN).First();
                k.InventoryLibrary--;
                k.InventoryLoan++;
            }

        }



        private void btnlibEndDontPrint_Click(object sender, EventArgs e)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                addTransaction();
                addTransactionDetails();
                updateBookInventory();
                updateBookLoanstatus();
                context.SaveChanges();
                ts.Complete();
            }
            Close();
        }

        private void btnlibEndPrint_Click(object sender, EventArgs e)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                addTransaction();
                addTransactionDetails();
                updateBookInventory();
                updateBookLoanstatus();
                context.SaveChanges();
                ts.Complete();
            }
            printReceipt();
            Close();
        }

        private void dGVBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string bTitle = dGVBorrow.CurrentRow.Cells[1].Value.ToString();
                int bNum = context.books.Where(x => x.BookTitle == bTitle).First().BookID;
                borrowedBookListstr.Remove(bNum.ToString());
                borrowedBookList.Remove(bNum);
                dGVBorrow.Rows.RemoveAt(dGVBorrow.CurrentRow.Index);
                if (borrowedBookList.Count == 0)
                {
                    btnlibEndDontPrint.Enabled = false;
                    btnlibEndPrint.Enabled = false;
                }
            }
        }

        private void btnCancelTrans_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int bookLimitTest()
        {
            List<BookTransaction> k = context.BookTransactions.Where(x => x.MemberID == memberID).ToList();
            List<BookTransDetail> j = new List<BookTransDetail>();
            for (int i = 0; i < k.Count(); i++)
            {
                int m = k[i].TransactionID;
                j.AddRange(context.BookTransDetails.Where(x => x.TransactionID == m && x.DateReturn == null).ToList());
            }
            return (8 - j.Count);
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            lblMemberIDError.Text = "";
            lblPasswordError.Text = "";
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            lblPasswordError.Text = "";
        }
    }
    public static class C
    {
        public static int transactionNo;
    }

}



