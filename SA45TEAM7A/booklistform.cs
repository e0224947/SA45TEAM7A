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
    public partial class booklistform : Form
    {
        public booklistform()
        {
            InitializeComponent();
        }

        private void booklistform_Load(object sender, EventArgs e)
        {
            DataSetforCrystalReport booklist = new DataSetforCrystalReport();
            DataSetforCrystalReportTableAdapters.CRbooksTableAdapter ta = new DataSetforCrystalReportTableAdapters.CRbooksTableAdapter();
            ta.Fill(booklist.CRbooks);

            BookList cr1 = new BookList();
            cr1.SetDataSource(booklist);
            crystalReportViewer1.ReportSource = cr1;

        }
    }
}
