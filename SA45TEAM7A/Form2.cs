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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataSetforCrystalReport piechar = new DataSetforCrystalReport();
            DataSetforCrystalReportTableAdapters.CRbooksTableAdapter ta = new DataSetforCrystalReportTableAdapters.CRbooksTableAdapter();
            ta.Fill(piechar.CRbooks);
            
            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(piechar);
            crystalReportViewer1.ReportSource = cr1;

        }
    }
}
