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


    public partial class BorrowBook : Form
    {
        LibrarySevenAEntities context = new LibrarySevenAEntities();
        //need two list, int list for convenience, string list as I can't parse empty string to int
        List<string> borrowedBookListstr = new List<string>();
        List<Int32> borrowedBookList = new List<Int32>();
        
        int count = 1;
        Int16 memberID; 
        int currentBookLimit;      

        public BorrowBook()
        {
            InitializeComponent();
        }
        private void BorrowBook_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dGVBorrow.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            currentBookLimit = bookLimitTest();
            memberID = A.ID;
            Member mb = context.Members.Where(x => x.MemberID == memberID).First();
            lblWelcome.Text = string.Format("Welcome, {0} {1}, to Library7A.", mb.ContactTitle, mb.MemberName);
                 
        }

        private void txtBorrowBookID_TextChanged(object sender, EventArgs e)
        {//check user has not borrowed more than limit
            if (currentBookLimit > 0)
            {
                //if textlength is 10, the borrowbook is automatically trigger, also check that item is not borrowed or scanned already
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
                            btnEndDontPrint.Enabled = true;
                            btnEndPrint.Enabled = true;
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

            }
            else
            {
                txtBorrowError.Text = "You have exceed the number of borrowed items";
                txtBorrowBookID.Text = "";
                txtBorrowBookID.ReadOnly = true;
                txtBorrowBookID.BackColor = SystemColors.Control;
            }
        }
        private void printReceipt()
        {

            CRformReceipt cFR = new CRformReceipt(B.transactionNo);
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
            B.transactionNo = bt.TransactionID;
                              
        }
        private void addTransactionDetails()
        {
            for (int i = 0; i < borrowedBookList.Count; i++)
            {
                BookTransDetail k = new BookTransDetail();
                k.TransactionID = B.transactionNo;
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


        private void btnEndDontPrint_Click(object sender, EventArgs e)
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

        private void btnEndPrint_Click(object sender, EventArgs e)
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

        private void btnCancelTrans_Click(object sender, EventArgs e)
        {
            Close();
        }

        //generate the books currently borrowed by member
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

  
    }
    public static class B
    {
        public static int transactionNo;
    }
}

