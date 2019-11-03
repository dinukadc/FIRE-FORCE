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
    public partial class custom : UserControl
    {

        private static custom _instance;
        public static custom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new custom();
                return _instance;

            }


        }

            public custom()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text != "" && bunifuMaterialTextbox3.Text != "" && bunifuMaterialTextbox4.Text != "" && bunifuMaterialTextbox5.Text != "" && bunifuMaterialTextbox6.Text != "" && bunifuMaterialTextbox7.Text != "" && bunifuMaterialTextbox8.Text != "" && bunifuMaterialTextbox9.Text != "")
            {
                try
                {

                    Database db = new Database();
                    string qu = "UPDATE supplier SET Company_Name ='" + bunifuMaterialTextbox2.Text + "',Name ='" + bunifuMaterialTextbox3.Text + "',Region ='" + bunifuMaterialTextbox4.Text + "',Country ='" + bunifuMaterialTextbox5.Text + "',City ='" + bunifuMaterialTextbox6.Text + "',Address ='" + bunifuMaterialTextbox7.Text + "',E_Mail ='" + bunifuMaterialTextbox8.Text + "',Telephone='" + bunifuMaterialTextbox9.Text + "' WHERE Sup_Id=" + int.Parse(Search.Text);

                    db.Dbupdate(qu);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            else
            {

                MessageBox.Show("No Valid data to update.!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

            }
        
        private void button2_Click(object sender, EventArgs e)
        {

            if (bunifuMaterialTextbox2.Text != "" && bunifuMaterialTextbox3.Text != "" && bunifuMaterialTextbox4.Text != "" && bunifuMaterialTextbox5.Text != "" && bunifuMaterialTextbox6.Text != "" && bunifuMaterialTextbox7.Text != "" && bunifuMaterialTextbox8.Text != "" && bunifuMaterialTextbox9.Text != "")
            {
                try
                {
                    Database db = new Database();
                    string qu = "DELETE FROM supplier WHERE Sup_Id='" + Search.Text + "'";
                    db.DBhand(qu);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            else
            {

                MessageBox.Show("No Valid Data to Delete.!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

         }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //search

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
        

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {// table load
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM supplier");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;

            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows [r];

            Search.Text = selectedRow.Cells[0].Value.ToString();
            bunifuMaterialTextbox2.Text = selectedRow.Cells[1].Value.ToString();
            bunifuMaterialTextbox3.Text = selectedRow.Cells[2].Value.ToString();
            bunifuMaterialTextbox4.Text = selectedRow.Cells[3].Value.ToString();
            bunifuMaterialTextbox5.Text = selectedRow.Cells[4].Value.ToString();
            bunifuMaterialTextbox6.Text = selectedRow.Cells[5].Value.ToString();
            bunifuMaterialTextbox7.Text = selectedRow.Cells[6].Value.ToString();
            bunifuMaterialTextbox8.Text = selectedRow.Cells[7].Value.ToString();
            bunifuMaterialTextbox9.Text = selectedRow.Cells[8].Value.ToString();


        }

        private void bunifuMaterialTextbox8_Leave(object sender, EventArgs e)
        {

            if (bunifuMaterialTextbox8.Text == "")
            {
                bunifuMaterialTextbox8.Text = "Enter Email";
                bunifuMaterialTextbox8.ForeColor = Color.DimGray;
            }

            try
            {

                if (!this.bunifuMaterialTextbox8.Text.Contains('@') || !this.bunifuMaterialTextbox8.Text.Contains('.'))
                {
                    MessageBox.Show("Enter a Valid Email Address", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((bunifuMaterialTextbox9.Text.Length == 10) && (e.KeyChar != '.') && (e.KeyChar != 46) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
