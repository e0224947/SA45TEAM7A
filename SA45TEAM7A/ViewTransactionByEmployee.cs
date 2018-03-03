using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM7A
{
    public partial class ViewTransactionByEmployee : Form
    {
        LibrarySevenAEntities context;
        public ViewTransactionByEmployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewTransactionByEmployee_Load(object sender, EventArgs e)
        {

        }
        private void populategrid()
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                context = new LibrarySevenAEntities();
                if (TransactionIDTextBox.Text != "")
                {
                    int j = Convert.ToInt32(TransactionIDTextBox.Text);
                    var q = context.BookTransactions.Where(x => x.TransactionID == j);
                    dataGridView1.DataSource = q.ToList();
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                else
                {
                    if (BookIDTextBox.Text == "")
                    {
                        if (MemberIDTextBox.Text == "")
                        {
                            var q = context.BookTransactions;
                            dataGridView1.DataSource = q.ToList();
                            dataGridView1.Columns[4].Visible = false;
                            dataGridView1.Columns[5].Visible = false;
                            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                        else if (MemberIDTextBox.Text != "")
                        {
                            short j = Convert.ToInt16(MemberIDTextBox.Text);
                            var q = context.BookTransactions.Where(x => x.MemberID == j);
                            dataGridView1.DataSource = q.ToList();
                            dataGridView1.Columns[4].Visible = false;
                            dataGridView1.Columns[5].Visible = false;
                            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                    else
                    {
                        List<BookTransDetail> LBTD = new List<BookTransDetail>();
                        int w = Convert.ToInt32(BookIDTextBox.Text);
                        LBTD = context.BookTransDetails.Where(x => x.BookID == w).ToList();
                        if (LBTD.Count > 0)
                        {
                            List<BookTransaction> LBKT = new List<BookTransaction>();
                            if (MemberIDTextBox.Text == "")
                            {
                                for (int i = 0; i < LBTD.Count; i++)
                                {
                                    int temp = Convert.ToInt32(LBTD[i].TransactionID.ToString());
                                    var q = context.BookTransactions.Where(x => x.TransactionID == temp);
                                    BookTransaction bkt = q.ToList().First();
                                    LBKT.Add(bkt);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < LBTD.Count; i++)
                                {
                                    int temp = Convert.ToInt32(LBTD[i].TransactionID.ToString());
                                    int j = Convert.ToInt16(MemberIDTextBox.Text);
                                    var q = context.BookTransactions.Where(x => x.TransactionID == temp &&
                                    x.MemberID == j);
                                    if (q.ToList().Count > 0)
                                    {
                                        BookTransaction bkt = q.ToList().First();
                                        LBKT.Add(bkt);
                                    }
                                }
                            }
                            dataGridView1.DataSource = LBKT;
                            dataGridView1.Columns[4].Visible = false;
                            dataGridView1.Columns[5].Visible = false;
                            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is InvalidOperationException)
                {
                    lblInputError.Text = "Incorrect Input, please check your search values";
                    return;
                }
            }
            
        }

        private void ShowDitailButton_Click(object sender, EventArgs e)
        {
            context = new LibrarySevenAEntities();
            int TrID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var q = context.BookTransDetails.Where(x => x.TransactionID == TrID);
            dataGridView2.DataSource = q.ToList();
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
        }
    }
}
