using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{
    public partial class suplier : UserControl
    {

        private static suplier _instance;
        public static suplier Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new suplier();
                return _instance;

            }
        }





        public suplier()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(custom.Instance))
            {
                panel1.Controls.Add(custom.Instance);
                custom.Instance.Dock = DockStyle.Fill;
                custom.Instance.BringToFront();
            }
            else
                custom.Instance.BringToFront();
            custom.Instance.Visible = true;


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(View.Instance))
            {
                panel1.Controls.Add(View.Instance);
                View.Instance.Dock = DockStyle.Fill;
                View.Instance.BringToFront();
            }
            else
                View.Instance.BringToFront();
            View.Instance.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text != "" && bunifuMaterialTextbox3.Text != "" && bunifuMaterialTextbox4.Text != "" && bunifuMaterialTextbox5.Text != "" && bunifuMaterialTextbox6.Text != "" && bunifuMaterialTextbox7.Text != "" && bunifuMaterialTextbox8.Text != "" && bunifuMaterialTextbox9.Text != "")
            {
                try
                {
                    Database db = new Database();
                    string qu = " insert into supplier (Company_Name,Name,Region,Country,City,Address,E_Mail,Telephone) values('" + bunifuMaterialTextbox2.Text + "', '" + bunifuMaterialTextbox3.Text + "', '" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox5.Text + "', '" + bunifuMaterialTextbox6.Text + "', '" + bunifuMaterialTextbox7.Text + "', '" + bunifuMaterialTextbox8.Text + "', '" + bunifuMaterialTextbox9.Text + "')";
                    db.DBhand(qu);
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }

            else {

                MessageBox.Show("Please Enter Data First.!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
       
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            bunifuMaterialTextbox2.Text = " ";
            bunifuMaterialTextbox3.Text = " ";
            bunifuMaterialTextbox4.Text = " ";
            bunifuMaterialTextbox5.Text = " ";
            bunifuMaterialTextbox6.Text = " ";
            bunifuMaterialTextbox7.Text = " ";
            bunifuMaterialTextbox8.Text = " ";
            bunifuMaterialTextbox9.Text = " ";

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                

        
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox9_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((bunifuMaterialTextbox9.Text.Length ==10) && (e.KeyChar != '.') && (e.KeyChar != 46) &&( e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox5_Enter(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox5_Leave(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox6_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_Leave(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox7_Enter(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox7_Leave(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox9_Enter(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox9_Leave(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox8_Enter(object sender, EventArgs e)
        {

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
        

        private void bunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

