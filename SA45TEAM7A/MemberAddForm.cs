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
    public partial class MemberAddForm : Form
    {
        LibrarySevenAEntities context = new LibrarySevenAEntities();

        public MemberAddForm()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            Member k = new Member();
            int error = 0;
           
            if (MemberNametext.Text == "")
            {
                lblNameError.Text = "This field is required";
                error++;
            }
            else
            {
                k.MemberName = MemberNametext.Text;
            }
            if (txtMemberType.Text == "")
            {
                lblMemberTypeError.Text = "This field is required";
                error++;
            }
            else
            {
                k.MemberType = txtMemberType.Text;
            }
            k.MemberType = txtMemberType.Text;
            if (GenderText.Text == "")
            {
                lblGenderError.Text = "This field is required";
                error++;
            }
            else
            {
                k.Gender = GenderText.Text;
            }
            k.Country = Countrytext.Text;
            if (!isDigitOnly(PostalCodetext.Text))
            {
                lblPostalCodeError.Text = "Postal code must be numerical";
                error++;
            }
            else
            {
                k.PostalCode = PostalCodetext.Text;
            }
            if (!isDigitOnly(Agetext.Text))
            {
                lblAgeError.Text = "Age must be numerical";
                error++;
            }
            else
            {
                Int16 age = Convert.ToInt16(Agetext.Text);
                k.Age = age;
            }

            if (!isDigitOnly(ContactNumbertext.Text))
            {
                lblContactError.Text = "Contact must be numerical";
                error++;
            }
            else
            {
                k.ContactNumber = ContactNumbertext.Text;
            }

            k.Address = Addresstext.Text;
            k.EmailAddress = EmailAddresstext.Text;
            k.Remarks = Remarkstext.Text;
            k.Password = Passwordtext.Text;
            k.ContactTitle = txtTitle.Text;
            if (error == 0)
            {
                context.Members.Add(k);
                context.SaveChanges();
                MessageBox.Show("Member Added");
            }

        }


        private void MemberAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
