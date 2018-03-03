using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace SA45TEAM7A
{
    public partial class Search1 : Form
    {

        SqlConnection cn;
        SqlCommand cm;
        DataTable dataTable;
       SqlDataAdapter da;
        DataSet ds;

       

        public Search1()
        {
          //  this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.;

            InitializeComponent();


        }


        private void Search1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string conS = "data source=(local); integrated security=SSPI; initial catalog=LibrarySevenA";
            cn = new SqlConnection(conS);
            loadData();
            
        }


        public void loadData()
        {
            cn.Open();
            AutoCompleteStringCollection namCollection = new AutoCompleteStringCollection();
            string querry = "select distinct BookTitle as names from books union select distinct Author as names from books";
            SqlCommand cmd = new SqlCommand(querry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
          

                while (dr.Read())
                    namCollection.Add(dr[0].ToString().ToLower());



            dr.Close();
            cn.Close();

            textBox1.AutoCompleteMode = AutoCompleteMode.None;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = namCollection;
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            count.Visible = false;
            this.dataGridView1.DataSource = null;
            label2.Visible = true;
            if (textBox1.Text.Length == 0)
            {
                hideResults();
                label2.Visible = false;
                
                
                return;
            }

            listBox1.Items.Clear();
            string a = textBox1.Text;
            hideResults();
            foreach (String s in textBox1.AutoCompleteCustomSource)
            {
                if (s.StartsWith(a))
                {
                    listBox1.Items.Add(s);
                    listBox1.Visible = true;

                }

            }
           

            if(listBox1.Items.Count<5)
            {
                foreach (String s in textBox1.AutoCompleteCustomSource)
                {
                    if (s.Contains(a) && (!s.StartsWith(a)))
                    {
                        listBox1.Items.Add(s);
                        listBox1.Visible = true;

                    }

                }
            }
        }

        


        void hideResults()
        {
            listBox1.Visible = false;
        }



        

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            hideResults();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            var regexItem = new Regex("^[a-zA-Z0-9]");
            count.Visible = true;
            string s = textBox1.Text;
            if (s.Length == 0)
            {
                count.Text = "Please Enter search item. You can search by book tile and author name ";
            }

            else if (!regexItem.IsMatch(s))
            {
                count.Text = "Wrong input, Please check your input";
            }
            else
            {


                cn.Open();
                string query = "select distinct BookTitle, author, InventoryLibrary, language, edition, PublishedYear from books s, BookInventory i where i.ISBN = s.ISBN and i.ISBN in(select distinct isbn from books where booktitle like '%"+s+ "%' or author like '%" + s + "%')";

                //string querry = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books s where Author like'%" + s + "%' or BookTitle like'%" + s + "%'";
                cm = new SqlCommand(query, cn);

                da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    count.Text = "Sorry, Your search did not find any records\nCheck your spelling or Try Using Different Words";
                }
                else
                {
                    count.Text = dt.Rows.Count.ToString() + " Records found ";
                    dataGridView1.DataSource = dt;
                }


                cn.Close();

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
           
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            Form f = new AdvancedSearch();
            textBox1.Text = "";
            dataGridView1.Refresh();
            f.Show();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
