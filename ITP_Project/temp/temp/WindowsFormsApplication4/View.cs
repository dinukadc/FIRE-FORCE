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
    public partial class View : UserControl
    {
        

        private static View _instance;
        public static View Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new View();
                return _instance;

            }


        }

        public View()
        {
            InitializeComponent();
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM supplier");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
      
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (Search.Text != "")
            {
                try {
                    Database db = new Database();
                    DataSet ds = db.dbse("SELECT * FROM supplier WHERE Sup_Id='" + Search.Text + "'");
                    bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

            }
            else
                {
                MessageBox.Show("Please Insert ID to Search.! ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            Database db = new Database();
            DataSet ds = db.dbse("SELECT c.product_name,s.Name,s.Company_Name,s.E_Mail FROM supplier_category c,supplier s WHERE c.Sup_Id=s.Sup_Id AND c.sup_category = 'Hardware' AND c.product_name IN (SELECT c.product_name FROM supplier_category GROUP BY c.product_name);");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT c.product_name,s.Name,s.Company_Name,s.E_Mail FROM supplier_category c,supplier s WHERE c.Sup_Id=s.Sup_Id AND c.sup_category = 'Electricals' AND c.product_name IN (SELECT c.product_name FROM supplier_category GROUP BY c.product_name);");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
        
            Database db = new Database();
            DataSet ds = db.dbse("SELECT c.product_name,s.Name,s.Company_Name,s.E_Mail FROM supplier_category c,supplier s WHERE c.Sup_Id=s.Sup_Id AND c.sup_category = 'Chemicals' AND c.product_name IN (SELECT c.product_name FROM supplier_category GROUP BY c.product_name);");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
       
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
