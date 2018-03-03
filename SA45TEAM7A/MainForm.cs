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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberAddForm f2 = new MemberAddForm();
            f2.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchBookForm f = new SearchBookForm();
            f.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddBookForm f = new AddBookForm();
            f.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberSearchForm f3 = new MemberSearchForm();
            f3.Show();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibBorrowBook f = new LibBorrowBook();
            f.Show();
        }

        private void extendBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libextendbook f = new Libextendbook();
            f.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransactionByEmployee f = new ViewTransactionByEmployee();
            f.Show();
        }

        private void bookCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new SA45TEAM7A.Form2();
            f.Show();
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            booklistform f = new booklistform();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LibrarySevenAEntities context = new LibrarySevenAEntities();
            Employee emp = context.Employees.Where(x => x.EmployeeID == temp1.empid).ToList().First();
            string str = emp.EmployeeName.ToString();
            label1.Text = "Welcome! " + str;
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f = new SA45TEAM7A.Form3();
            f.Show();
        }
    }
}
