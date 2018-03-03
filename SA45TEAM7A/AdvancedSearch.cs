using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM7A
{
    public partial class AdvancedSearch : Form
    {


        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
       
        string commend;
       
        public AdvancedSearch()
        {
            InitializeComponent();


        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string conS = "data source=(local); integrated security=SSPI; initial catalog=LibrarySevenA";
            cn = new SqlConnection(conS);
            cn.Open();
            AutoCompleteStringCollection cateCollection = new AutoCompleteStringCollection();

            SqlCommand cm = new SqlCommand("Select BookCategory from books ", cn);
            SqlDataReader rd = cm.ExecuteReader();
            while (rd.Read())
            {
                cateCollection.Add(rd[0].ToString());

            }
          

            rd.Close();
            cn.Close();

            textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox3.AutoCompleteCustomSource = cateCollection;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            count.Visible = false;
            this.dataGridView1.DataSource = null;
                string title = textBox1.Text;
                string author = textBox2.Text;
                string BookCategory = textBox3.Text;

                string language = textBox5.Text.ToLower();


            this.dataGridView1.DataSource = null;
            
            count.Visible = true;
            
           
           

                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox5.Checked == true)
                {
                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                   + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                   "where BookTitle ='" + title + "' and Author ='" + author + "' and BookCategory ='" + BookCategory + "' and Language ='" + language + "'"
                    + ")";
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition 

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookTitle ='" + title + "' and Author ='" + author + "' and BookCategory ='" + BookCategory + "'";

                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                     + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                     "where BookTitle ='" + title + "' and Author ='" + author + "' and BookCategory ='" + BookCategory + "' and Language ='" + language + "'"
                      + ")";

                }

                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox5.Checked == true)
                {
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookTitle ='" + title + "' and Author ='" + author + "' and Language ='" + language + "'";
                    commend = "select distinct BookTitle,author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                         + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                         "where BookTitle ='" + title + "' and Author ='" + author + "'and Language ='" + language + "'"
                          + ")";
                }



                else if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox5.Checked == true)
                {
                    //commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookTitle ='" + title + "' and Author ='" + author + "' and Language ='" + language + "'";
                    commend = "select distinct BookTitle,author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                     + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                     "where Author ='" + author + "' and BookCategory ='" + BookCategory + "' and Language ='" + language + "'"
                      + ")";
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookTitle ='" + title + "' and Author ='" + author + "'";
                    commend = "select distinct BookTitle,author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                     + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                     "where BookTitle ='" + title + "' and Author ='" + author + "'"
                      + ")";
                }


                else if (checkBox1.Checked == true && checkBox3.Checked == true)
                {
                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                    + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                    "where BookTitle ='" + title + "' and BookCategory ='" + BookCategory + "'"
                     + ")";
                    //commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookTitle ='" + title + "' and BookCategory ='" + BookCategory + "'";

                }

                else if (checkBox1.Checked == true && checkBox5.Checked == true)
                {

                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                    + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                    "where BookTitle ='" + title + "'and Language ='" + language + "'"
                     + ")";
                    //commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookCategory ='" + BookCategory + "' and Language ='" + language + "'";


                }
                else if (checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where Author ='" + author + "' and BookCategory ='" + BookCategory + "'";
                    commend = "select distinct BookTitle,author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                     + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                     "where Author ='" + author + "' and BookCategory ='" + BookCategory + "'"
                      + ")";
                }
                else if (checkBox2.Checked == true && checkBox5.Checked == true)
                {
                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                    + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                    "where Author ='" + author + "' and Language ='" + language + "'"
                     + ")";
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where Author ='" + author + "' and Language ='" + language + "'";
                }
                else if (checkBox3.Checked == true && checkBox5.Checked == true)
                {
                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                    + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                    "where BookCategory ='" + BookCategory + "' and Language ='" + language + "'"
                     + ")";
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookCategory ='" + BookCategory + "' and Language ='" + language + "'";

                }

                else if (checkBox1.Checked == true)
                {
                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                      + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                      "where BookTitle ='" + title + "')";
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookTitle ='" + title + "'";

                }
                else if (checkBox2.Checked == true)
                {
                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                    + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                    "where Author ='" + author + "')";
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where Author ='" + author + "'";


                }
                else if (checkBox3.Checked == true)
                {
                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                                    + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                                    "where BookCategory ='" + BookCategory + "')";
                    // commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books where BookCategory ='" + BookCategory + "'";


                }
                else if (checkBox5.Checked == true)
                {

                    commend = "select distinct BookTitle,Author,InventoryLibrary,Language,Edition,PublishedYear from books s, BookInventory i "
                                   + "where i.ISBN = s.ISBN and i.ISBN in " + "(select distinct isbn from books " +
                                   "where Language ='" + language + "')";
                    //commend = "select distinct BookTitle,Author,BookCategory, PublishedYear,Language,Edition from books  where Language ='" + language + "'";


                }
            
            
            //MessageBox.Show(commend);
            cn.Open();


            cm = new SqlCommand(commend, cn);
              
             da = new SqlDataAdapter(cm);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                ErrorPage f = new SA45TEAM7A.ErrorPage();

                DialogResult r = f.ShowDialog();
            }
            else
            {
                
                count.Text = dt.Rows.Count.ToString() + " Records found ";
                dataGridView1.DataSource = dt;

              //  dataGridView1.Columns[2].HeaderText = "AvailableInLibrary";
                //this.dataGridView1.Columns.Add("Avaliabilty", HeaderText);
            }

            
                cn.Close();
               




            }

        //public string checkAvailable(string isbn)
        //{
        //    SqlCommand sql = new SqlCommand("select InventoryLibrary from BookInventory where ISBN='" + isbn + "'", cn);
        //    string result = Convert.ToString(sql.ExecuteScalar());

        //    return result.ToString();

        //}


        //private string checkCon(int cc)
        //{

        //    if (cc != 0)
        //        return " and";
        //    else
        //        return null;

        //}
        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void TextBoxClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {

                textBox1.Enabled = true;

            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Clear();
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                textBox2.Enabled = true;

            }
            else
            {

                textBox2.Enabled = false;
                textBox2.Clear();
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {

                textBox3.Enabled = true;
                textBox2.Clear();

            }
            else
            {

                textBox3.Enabled = false;
                textBox3.Clear();
            }
        }



        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
               
                textBox5.Enabled = true;

            }
            else
            {
                
                textBox5.Enabled = false;
                textBox5.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            count.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            count.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            count.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            count.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }
