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

    public partial class MemberLoginForm : Form
    {
        public MemberLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            LibrarySevenAEntities context = new LibrarySevenAEntities();
            try
            {
                var s = Convert.ToInt16(MemberIDTextBox.Text);
                if (context.Members.Where(x => x.MemberID == s).ToList().Count > 0)
                {
                    Member m = context.Members.Where(x => x.MemberID == s).ToList().First();
                    if (m.Password == MemberPasswordTextBox.Text)
                    {
                        A.ID = s;
                        CustomerInterfaceForm CIF = new CustomerInterfaceForm();
                        CIF.Show();
                        MemberIDTextBox.Text = "";
                        MemberPasswordTextBox.Text = "";
                    }
                    else
                    {
                        lblPasswordError.Text = "Incorrect Password/ User ID";
                    }
                }
                else
                {
                    MessageBox.Show("UserID is incorrect!");
                }
            }
            catch (OverflowException)
            {
                lblError.Text = "User ID is a 4 digit number";
            }catch (FormatException)
            {
                lblError.Text = "User ID is numerical";
            }
            

        }

        private void MemberLoginForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MemberIDTextBox_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblPasswordError.Text = "";
        }

        private void MemberPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            lblPasswordError.Text = "";
        }
    }

    public static class A
    {
        public static Int16 ID;
    }
}
