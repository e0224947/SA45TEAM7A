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
    public partial class CRformReceipt : Form
    {
        int transNumber;

        public CRformReceipt(int TransactionNumber)
        {
            InitializeComponent();
            transNumber = TransactionNumber;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CRformReceipt_Load(object sender, EventArgs e)
        {
            DataSetforCrystalReport td = new DataSetforCrystalReport();
            DataSetforCrystalReportTableAdapters.CRBooksTrainDetailTableAdapter tta = new DataSetforCrystalReportTableAdapters.CRBooksTrainDetailTableAdapter();
            DataSetforCrystalReportTableAdapters.CRbooksTableAdapter ta = new DataSetforCrystalReportTableAdapters.CRbooksTableAdapter();
            DataSetforCrystalReportTableAdapters.CRMemberTableAdapter mta = new DataSetforCrystalReportTableAdapters.CRMemberTableAdapter();
            DataSetforCrystalReportTableAdapters.CRBookTransactionTableAdapter ttta = new DataSetforCrystalReportTableAdapters.CRBookTransactionTableAdapter();

            ta.Fill(td.CRbooks);
            tta.Fill(td.CRBooksTrainDetail);
            mta.Fill(td.CRMember);
            ttta.Fill(td.CRBookTransaction);

            crystalReportViewer1.SelectionFormula = "{CRBookTransaction.TransactionID} =" + transNumber;


            Receipt rp = new Receipt();
            rp.SetDataSource(td);

            crystalReportViewer1.ReportSource = rp;
        }
    }
}
