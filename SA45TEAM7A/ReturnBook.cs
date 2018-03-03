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
    public partial class ReturnBook : Form
    {
        LibrarySevenAEntities context = new LibrarySevenAEntities();
        int returnBookID;
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txtReturnBookID_TextChanged(object sender, EventArgs e)
        {
            if (txtReturnBookID.TextLength == 10)
            {
                try
                {
                    returnBookID = Convert.ToInt32(txtReturnBookID.Text);
                    //next check if book has already been returned. 
                    if (context.books.Where(x => x.BookID == returnBookID).First().LoanStatus == true)
                    {
                        using (TransactionScope ts = new TransactionScope())
                        {
                            updateBookInventory();
                            updateBookLoanstatus();
                            updateTransactionDetailsAndFine();                            
                            
                            context.SaveChanges();
                            ts.Complete();
                            txtReturnSuccess.Visible = true;
                            txtReturnSuccess.Text = returnBookID.ToString() + " has been returned successfully";
                            txtReturnBookID.Text = "";
                            
                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            timer.Interval = 5000;
                            timer.Tick += (source, m) =>
                            {
                                txtReturnSuccess.Visible = false;
                                timer.Stop();
                            };
                            timer.Start();
                        }

                    }
                    else
                    {
                        txtReturnError.Text = "Item has already been returned. Please check";
                        txtReturnBookID.Text = "";
                    }
                }
                //catch (InvalidOperationException)
                //{
                //    txtReturnError.Text = "Book not found. Please try again.";
                //    txtReturnBookID.Text = "";
                //}
                catch (FormatException)
                {
                    txtReturnError.Text = "Wrong Input. Please try again.";
                    txtReturnBookID.Text = "";
                }
            }
        }

        private void updateBookInventory()
        {
            string bookISBN = context.books.Where(x => x.BookID == returnBookID).First().ISBN;
            BookInventory k = context.BookInventories.Where(x => x.ISBN == bookISBN).First();
            k.InventoryLibrary++;
            k.InventoryLoan--;
        }
        private void updateBookLoanstatus()
        {
            book k = context.books.Where(x => x.BookID == returnBookID).First();
            k.LoanStatus = false; 
        }
        private void updateTransactionDetailsAndFine()
        {
            BookTransDetail k = context.BookTransDetails.Where(x => x.BookID == returnBookID && !x.RentalStatus).First();
            k.RentalStatus = true;
            k.DateReturn = DateTime.Today.Date;
            if (k.DateReturn > k.DateDue)
            {
                FineTran f = new FineTran();
                f.MemberID = context.BookTransactions.Where(x => x.TransactionID == k.TransactionID).First().MemberID;
                f.TransactionID = k.TransactionID;
                f.FineAmount = Convert.ToDecimal(((Convert.ToDateTime(k.DateReturn) - k.DateDue).TotalDays)*0.30);
                f.FineStatus = false;
            }

        }


    }
}

