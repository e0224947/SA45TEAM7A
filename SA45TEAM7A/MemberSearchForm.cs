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
    public partial class MemberSearchForm : Form
    {
        LibrarySevenAEntities context = new LibrarySevenAEntities();
    
        public MemberSearchForm()
        {
            InitializeComponent();
        }
         private void button1_Click(object sender, EventArgs e)
        {try
            {
                int memberID = Convert.ToInt32(MemberIdtext.Text);
                List<Member> mList = context.Members.Where(x => x.MemberID == memberID).ToList();
                dgvMemberGrid.DataSource = mList;
            }
            catch (FormatException)
            {
                lblInputError.Text = "Wrong Input";
            }
        }

        private void MemberIdtext_TextChanged(object sender, EventArgs e)
        {
            lblInputError.Text = "";
        }
    }
}
