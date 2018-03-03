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
    public partial class EmployeeLogIn : Form
    {
        public EmployeeLogIn()
        {
            InitializeComponent();
        }

        private void MemberPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MemberIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            LibrarySevenAEntities context = new LibrarySevenAEntities();
            try
            {
                var s = Convert.ToInt16(MemberIDTextBox.Text);
                if (context.Employees.Where(x => x.EmployeeID == s).ToList().Count > 0)
                {
                    Employee m = context.Employees.Where(x => x.EmployeeID == s).ToList().First();
                    if (m.EmployeePassword == MemberPasswordTextBox.Text)
                    {
                        temp1.empid = s;
                        MainForm f = new MainForm();
                        f.Show();
                        MemberIDTextBox.Text = "";
                        MemberPasswordTextBox.Text = "";
                        this.Hide();
                    }
                    else
                    {
                        lblPasswordError.Text = "Incorrect Password/ User ID";
                    }
                }
                else
                {
                    MessageBox.Show("User ID is incorrect!");
                }
            }
            catch (OverflowException)
            {
                lblError.Text = "User ID is a 4 digit number";
            }
            catch (FormatException)
            {
                lblError.Text = "User ID is numerical";
            }
        }

        private void EmployeeLogIn_Load(object sender, EventArgs e)
        {

        }
    }
    public static class temp1
    {
        public static Int16 empid;
    }
}
