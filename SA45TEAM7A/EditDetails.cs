using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM7A
{
    public partial class EditDetailsForm : Form
    {
        LibrarySevenAEntities context;
        Member m;
        public EditDetailsForm()
        {
            InitializeComponent();
        }

        private void EditDetailsForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            context = new LibrarySevenAEntities();
            m = context.Members.Where(x => x.MemberID == A.ID).ToList().First();
            ID.Text = m.MemberID.ToString();
            Name1.Text = m.MemberName;
            Type.Text = m.MemberType;
            Gender.Text = m.Gender;
            Age.Text = m.Age.ToString();
            Address.Text = m.Address;
            Country.Text = m.Country;
            Postalcode.Text = m.PostalCode;
            ContactNum.Text = m.ContactNumber;
            cBTitle.Text = m.ContactTitle;
            EmaiAddress.Text = m.EmailAddress;
            Remark.Text = m.Remarks;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public bool noNumSpecialChar(string input)
        {

            return Regex.IsMatch(input, @"[\p{L} ]+$");
        }

        public bool isDigitOnly(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (Name1.Text == string.Empty)
            {

                lblNameError.Text = "Name cannot be empty";
                error++;
            }
            else if (!noNumSpecialChar(Name1.Text))
            {
                lblNameError.Text = "Please only input alphabetical characters";
                error++;
            }
            else
            {
                m.MemberName = Name1.Text;
                lblNameError.Text = "";
            }


            m.Address = Address.Text;
            m.PostalCode = Postalcode.Text;         
            m.EmailAddress = EmaiAddress.Text;
            if (!isDigitOnly(ContactNum.Text))
            {
                lblContactError.Text = "Please only enter numbers for contact number";
                error++;
            }
            else
            {
                m.ContactNumber = ContactNum.Text;
                lblContactError.Text = "";
            }
            m.Remarks = Remark.Text;
            m.ContactTitle = cBTitle.Text;
            
            if (error > 0)
                return;
            context.SaveChanges();
            MessageBox.Show("Edit Successful");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
