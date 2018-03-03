using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM7A
{
    public partial class Libextendbook : Form
    {

        LibrarySevenAEntities context = new LibrarySevenAEntities();
        short memberID;
        public Libextendbook()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            btnExtend.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                memberID = Convert.ToInt16(txtMemberID.Text);
                Member k = context.Members.Where(x => x.MemberID == memberID).First();
                if (k.Password == txtPassWord.Text)
                {
                    dataGridView1.Visible = true;
                    btnExtend.Visible = true;
                    LoadDGV();
                    txtMemberType.Text = k.MemberType;
                    txtMemberID.Enabled = false;
                    txtPassWord.Enabled = false;
                    btnLogIn.Enabled = false;
                }
                else
                {
                    lblPasswordError.Text = "Wrong Password";
                }
            }catch (Exception ex)
            {
                if (ex is FormatException || ex is InvalidOperationException)
                {
                    lblMemberIDError.Text = "Incorrect User ID";
                    return;
                }
            }
        }
        private void LoadDGV()
        {
            context = new LibrarySevenAEntities();
            List<BookTransaction> lbt = new List<BookTransaction>();
            try
            {

                lbt = context.BookTransactions.Where(x => x.MemberID == memberID).ToList();
                if (lbt.Count > 0)
                {
                    List<object> lbtd = new List<object>();
                    for (int i = 0; i < lbt.Count; i++)
                    {
                        int temp = Convert.ToInt32(lbt[i].TransactionID.ToString());
                        var q = from x in context.BookTransDetails
                                where x.TransactionID == temp && x.RentalStatus == false
                                select new { x.TransactionID, x.BookID, x.book.BookTitle, x.DateDue };
                        if (q.ToList().Count > 0)
                        {
                            object bktd = q.ToList().First();
                            lbtd.Add(bktd);

                        }

                    }
                    dataGridView1.DataSource = lbtd;
                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No previous transaction found!");
            }
        }
        private void Libextendbook_Load(object sender, EventArgs e)
        {
            context = new LibrarySevenAEntities();
            List<BookTransaction> lbt = new List<BookTransaction>();
            try
            {
            
                lbt = context.BookTransactions.Where(x => x.MemberID == memberID).ToList();
                if (lbt.Count > 0)
                {
                    List<object> lbtd = new List<object>();
                    for (int i = 0; i < lbt.Count; i++)
                    {
                        int temp = Convert.ToInt32(lbt[i].TransactionID.ToString());
                        var q = from x in context.BookTransDetails
                                where x.TransactionID == temp && x.RentalStatus == false
                                select new { x.TransactionID, x.BookID, x.book.BookTitle, x.DateDue };
                        if (q.ToList().Count > 0)
                        {
                            object bktd = q.ToList().First();
                            lbtd.Add(bktd);

                        }

                    }
                    dataGridView1.DataSource = lbtd;
                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No previous transaction found!");
            }
        }

        private void ExtendButton_Click(object sender, EventArgs e)
        {
            DateTime datedue = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            int TrID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int BID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            context = new LibrarySevenAEntities();
            var QBT = context.BookTransactions.Where(x => x.TransactionID == TrID);
            BookTransaction bk = QBT.First();
            if (bk.OriginalDateDue == datedue)
            {
                var QBTD = context.BookTransDetails.Where(x => x.TransactionID == TrID && x.BookID == BID);
                BookTransDetail btd = QBTD.First();
                btd.DateDue = datedue.AddDays(21);
                context.SaveChanges();
                //refresh
                context = new LibrarySevenAEntities();
                List<BookTransaction> lbt = new List<BookTransaction>();
                lbt = context.BookTransactions.Where(x => x.MemberID == memberID).ToList();
                if (lbt.Count > 0)
                {
                    List<object> lbtd = new List<object>();

                    for (int i = 0; i < lbt.Count; i++)
                    {
                        int temp = Convert.ToInt32(lbt[i].TransactionID.ToString());
                        var q = from x in context.BookTransDetails
                                where x.TransactionID == temp && x.RentalStatus == false
                                select new { x.TransactionID, x.BookID, x.book.BookTitle, x.DateDue };
                        if (q.ToList().Count > 0)
                        {
                            object bktd = q.ToList().First();
                            lbtd.Add(bktd);
                        }

                    }
                    dataGridView1.DataSource = lbtd;
                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
            else
            {
                MessageBox.Show("Unable to extend, this book has previously been extended");
            }
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            lblMemberIDError.Text = "";
            lblPasswordError.Text = "";
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            lblMemberIDError.Text = "";
        }
    }
}
