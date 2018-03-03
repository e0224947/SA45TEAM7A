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
    public partial class AddBookForm : Form
    {

        public AddBookForm()
        {
            InitializeComponent();
        }
        LibrarySevenAEntities context = new LibrarySevenAEntities();

        private void button1_Click(object sender, EventArgs e)
        {

            using (TransactionScope ts = new TransactionScope())
            {

                

                if (BookTitletext.Text == "" || Authortext.Text == "" || Publishertext.Text == "" || BookCategorycomboBox.Text == "" || BookTypetext.Text == "" || ISBNtext.Text == "" || Editiontext.Text == "")
                {

                    MessageBox.Show("Please input all fields");
                    return;
                }

                else
                {



                

                    DateTime PublishedYear;
                    DateTime.TryParse(PublishedYeartext.Text, out PublishedYear);
                    PublishedYear.ToString();

                    
                   
                    var q = context.BkCategories.Where(x => x.BookCategory == BookCategorycomboBox.Text && x.BookType == BookTypetext.Text).ToList();
                    if (q.Count == 0)
                    {
                        BkCategory bcategory = new BkCategory();
                        bcategory.BookCategory = BookCategorycomboBox.Text;
                        bcategory.BookType = BookTypetext.Text;
                        context.BkCategories.Add(bcategory);
                        context.SaveChanges();
                    }

                    var m = context.BookInventories.Where(x => x.ISBN == ISBNtext.Text).ToList();
                    if (m.Count == 0)
                    {
                        BookInventory BInventory = new BookInventory();
                        BInventory.ISBN = ISBNtext.Text;
                        BInventory.InventoryLibrary = 1;
                        BInventory.InventoryLoan = 0;
                        context.BookInventories.Add(BInventory);
                        context.SaveChanges();

                    }
                    else
                    {
                        BookInventory J = m.First();
                        J.InventoryLibrary++;
                   
                    }
                 


                    book b = new book();


                    b.BookTitle = BookTitletext.Text;
                    b.Author = Authortext.Text;
                    b.Publisher = Publishertext.Text;
                    b.BookCategory = BookCategorycomboBox.Text;
                    b.BookType = BookTypetext.Text;
                    b.LoanStatus = false;
                    b.ISBN = ISBNtext.Text;
                    b.Edition = Editiontext.Text;
                    b.Language = Languagetext.Text;
                    b.PublishedYear = PublishedYear;
                    context.books.Add(b);
                    context.SaveChanges();



                    //insert/update book inventory
                  


                        //insert book category
                    

                    

                    ts.Complete();
                    MessageBox.Show("Book Record Added Successfully");

                }
                //this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


