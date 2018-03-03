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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataSetforCrystalReport hh = new DataSetforCrystalReport();
            
            DataSetforCrystalReportTableAdapters.CRMemberTableAdapter mta = new DataSetforCrystalReportTableAdapters.CRMemberTableAdapter();
           
      
            mta.Fill(hh.CRMember);
        

            


            memberList rt = new memberList();
            rt.SetDataSource(hh);

            crystalReportViewer1.ReportSource = rt;
        }
    }
}
