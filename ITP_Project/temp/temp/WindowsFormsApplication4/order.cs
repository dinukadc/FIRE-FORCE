using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class order : UserControl
    {


        private static order _instance;
        public static order Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new order();
                return _instance;

            }


        }
        public order()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChart();

            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM valid_orders");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadChart1();
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM  dispatch_orders");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {  

            if (materialSingleLineTextField2.Text != "")
            {
                try
                {
                    Database db = new Database();
                    DataSet ds = db.dbse("SELECT * FROM valid_orders WHERE V_ID='" + materialSingleLineTextField2.Text + "'");
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {  // should change


            if (materialSingleLineTextField1.Text != "")
            {
                try
                {

                    Database db = new Database();
                    DataSet ds = db.dbse("SELECT * FROM dispatch_orders WHERE D_ID ='" + materialSingleLineTextField1.Text + "'");
                    bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
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

        }
        public void LoadChart()
        {
            try
            {
                this.chart1.Series.Clear();
                this.chart1.Series.Add("Valid Orders");
                string query = "SELECT Validated_Date,Valid_Qty FROM valid_orders";
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=ffdb");
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmnd.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart1.Series["Valid Orders"].Points.AddXY(myReader.GetString("Validated_Date"), myReader.GetString("Valid_Qty"));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        public void LoadChart1()
        {
            try
            {
                this.chart2.Series.Clear();
                this.chart2.Series.Add("Dispatch Orders");
                string query = "SELECT Dispatched_Date,Dispatch_Qty FROM dispatch_orders";
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=ffdb");
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmnd.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart2.Series["Dispatch Orders"].Points.AddXY(myReader.GetString("Dispatched_Date"), myReader.GetString("Dispatch_Qty"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
