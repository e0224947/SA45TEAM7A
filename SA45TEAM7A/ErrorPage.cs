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
    public partial class ErrorPage : Form
    {
        public ErrorPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            AdvancedSearch f = new SA45TEAM7A.AdvancedSearch();

            DialogResult r = f.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            //label1.Text =  dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {


  
            DialogResult = DialogResult.OK;
        }
    
    }
}
