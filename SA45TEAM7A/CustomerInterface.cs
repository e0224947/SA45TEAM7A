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
    public partial class CustomerInterfaceForm : Form
    {
        LibrarySevenAEntities context = new LibrarySevenAEntities();
        Member m; 
        public CustomerInterfaceForm()
        {
            InitializeComponent();
        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            m = context.Members.Where(x => x.MemberID == A.ID).First();
            label1.Text = "Welcome, " + m.MemberName;
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            EditDetailsForm edf = new EditDetailsForm();
            edf.Show();
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
                ViewTransactionDetailForm VTDF = new ViewTransactionDetailForm();
                VTDF.Show();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {//check for fines
            List<FineTran> ft = context.FineTrans.Where(x => x.MemberID == m.MemberID && x.FineStatus == false).ToList();
            if (ft.Count > 0)
            {
                UnpaidFine UF = new UnpaidFine();
                UF.Show();
            }
            else
            {
                BorrowBook BB = new BorrowBook();
                BB.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "MemberLoginForm")
                    f.Close();
            }

        }
    }
}
