using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM7A
{
    public partial class SearchBookForm : Form
    {
        LibrarySevenAEntities context = new LibrarySevenAEntities();
        public SearchBookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int bookID = Convert.ToInt32(BookIDtext.Text);
                List<book> j = context.books.Where(x => x.BookID == bookID).ToList();
                dgvSearch.DataSource = j;
                
            }
            catch (Exception ex)
            {
                if (ex is OverflowException || ex is FormatException)
                {
                    lblBookIDerror.Text = "Wrong Book ID format";
                }
            }
        }

        private void BookIDtext_TextChanged(object sender, EventArgs e)
        {
            lblBookIDerror.Text = "";
        }
    }
}