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
    public partial class DetailSearch : Form
    {
        public DetailSearch()
        {
            InitializeComponent();
        }

        private void DetailSearch_Load(object sender, EventArgs e)
        {
            //string conS = "data source=(local); integrated security=SSPI; initial catalog=LibrarySevenA";
            //cn = new SqlConnection(conS);
            //cn.Open();
            //commend = "select distinct * from books where BookTitle='" + s + "'";

            //cm = new SqlCommand(commend, cn);

            //SqlDataReader rd = cm.ExecuteReader();
            //while (rd.Read())
            //{
            //    for (int i = 0; i < rd.FieldCount; i++)
            //    {
            //        Title.Text = rd["BookTitle"].ToString();
            //        author.Text = rd["Author"].ToString();
            //        category.Text = rd["BookCategory"].ToString();
            //        publisher.Text = rd["Publisher"].ToString();
            //        year.Text = rd["PublishedYear"].ToString();
            //        language.Text = rd["Language"].ToString();
            //        //  available.Text = checkAvailable(rd["ISBN"].ToString);


            //    }
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
