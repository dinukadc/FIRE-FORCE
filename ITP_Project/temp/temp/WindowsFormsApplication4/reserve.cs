using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication4
{
    public partial class reserve : UserControl
    {

        private static reserve _instance;
        public static reserve Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new reserve();
                return _instance;
            }
        }

        public reserve()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
         
               

        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (Search.Text != "")
            {
                try
                {

                    Database db = new Database();
                    DataSet ds = db.dbse("SELECT Sup_Id,Name,Company_Name,E_Mail FROM supplier WHERE Sup_Id='" + Search.Text + "'");
                    bunifuCustomDataGrid1.DataSource = ds.Tables["load"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

            }
            else
            {
                MessageBox.Show("Please Insert ID to Search.! ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Database db = new Database();
            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[r];
            Search.Text = selectedRow.Cells[0].Value.ToString();
            string num1 = db.dbgett("SELECT COUNT(status)FROM stock WHERE status=1 AND Sup_Id='" + Search.Text + "'");
            string num2 = db.dbgett("SELECT COUNT(status)FROM stock WHERE Sup_Id='" + Search.Text + "'");

            int fin_num1 = Convert.ToInt32(num1);
            int fin_num2 = Convert.ToInt32(num2);

            


            if (fin_num1 > 5)
            {

                double stp_1 = fin_num1 - 5;
                double stp_2 = stp_1 / fin_num2;
                double stp_3 = stp_2 * 100;
                int stp_4 = Convert.ToInt32(stp_3);
                label1.Text = Convert.ToString(stp_4 +"%");




                // int tot =((fin_num1 - 5) / fin_num2) * 100;
                //int final_tot = Convert.ToInt32(tot);


                //string final_output = Convert.ToString(final_tot);



            } //circularProgressBar1.Value = tot;
              // textBox1.Text = Convert.ToString(tot);

            // for (int i = 1; i <= tot; i++)
            //{

            //  circularProgressBar1.Value = i;

            // }

            // }
            else
           {

                MessageBox.Show("Supplier is still not exeeded the sells limit successfully.!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            /* try
            {
                int r = e.RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[r];
                Search.Text = selectedRow.Cells[0].Value.ToString();
                string qu = "SELECT COUNT(Sell_confrm)FROM add_product a ,product p WHERE a.Pro_Id=p.Pro_Id AND Sell_confrm=1 AND Sup_Id='" + Search.Text + "'";
                
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=ffdb");
                MySqlCommand cmnd = new MySqlCommand(qu, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmnd.ExecuteReader();
                //cell
                int num1, no;
                int tot;
                // Database db = new Database();
                while (myReader.Read())
                {
                    num1 = Convert.ToInt32(myReader.GetString(0));
                    no = getValue(Search.Text);
                    if (num1>5)
                    {
                        tot = ((num1-5)/no) *100;
                        //final_Val = Convert.ToInt32(tot);
                        circularProgressBar1.Value= tot;
                    }
                    else
                    {

                        MessageBox.Show("Supplier is still not exeeded the sells limit successfully.!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                for (int i = 1; i <= tot; i++)
                {

                    circularProgressBar1.Value = i;

                }




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
       // int num2;
        /*public int getValue(string st)
        {
            /* int num2;
             Database db2 = new Database();
             string qu2 = "SELECT COUNT(Sell_confrm)FROM add_product a ,product p WHERE a.Pro_Id=p.Pro_Id AND Sup_Id='" + Search.Text + "'";
             num2 = Convert.ToInt32(db2.dbgett(qu2));
             return num2;*/
            
         /*   string qu2 = "SELECT COUNT(Sell_confrm)FROM add_product a ,product p WHERE a.Pro_Id=p.Pro_Id AND Sup_Id='" + st + "'";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=ffdb");
            MySqlCommand cmnd = new MySqlCommand(qu2, con);
            MySqlDataReader myReader;
            con.Open();
            myReader = cmnd.ExecuteReader();
            while (myReader.Read())
            {
                num2 = Convert.ToInt32(myReader.GetString(0));
            }
            return num2;


        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT Sup_Id,Name,Company_Name,E_Mail FROM supplier");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        void AutoCompleteText()
        {
          
        }
        private void Search_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT Sup_Id,Name,Company_Name,E_Mail FROM supplier WHERE Sup_Id ='" + Search.Text + "'");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void reserve_Load(object sender, EventArgs e)
        {
            

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
           


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           // circularProgressBar1.Value = 0;
           // circularProgressBar1.Minimum = 0;
           // circularProgressBar1.Maximum = 100;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadChart()
        {
            try
            {
                this.chart1.Series.Clear();
                this.chart1.Series.Add("quantity");
                this.chart1.Series.Add("total_price");
                string query = "SELECT date,quantity,quantity*unit_price AS total_price FROM stock s ,product p WHERE s.product_id=p.product_id AND s.status=1";
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=inventry+supplier");
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmnd.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart1.Series["quantity"].Points.AddXY(myReader.GetString("date"), myReader.GetString("quantity"));
                    this.chart1.Series["total_price"].Points.AddXY(myReader.GetString("date"), myReader.GetString("total_price"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
