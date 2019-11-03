using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication4
{
    class Database
    {
        // Database Connection

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=inventry+supplier");

        // insert method
        public void DBhand(String query)
        {
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, "Your details are successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e1)
            {
                MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, " " + e1, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        // Update Method
        public void Dbupdate(String query)
        {
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            MySqlCommand cmd = con.CreateCommand();

            try

            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, "Your details are succesfully updated.", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception e1)
            {
                MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, " " + e1, "Eror, You can't Update,Try again..", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            con.Close();
        }

        // Select method
        public DataSet dbse(string qu)
        {
            if (con.State.ToString() == "Closed")
            {

                con.Open();
            }
            try
            {
                MySqlCommand cmdg = con.CreateCommand();
                cmdg.Connection = con;
                cmdg.CommandType = CommandType.Text;

                cmdg.CommandText = qu;

                MySqlDataAdapter deta = new MySqlDataAdapter(cmdg);
                DataSet ds = new DataSet();
                deta.Fill(ds, "load");

                con.Close();
                return ds;
            }

            catch (Exception)
            {
                MessageBox.Show("Something wrong.Please check your database connection.");
                DataSet ee = new DataSet();
                return ee;
            }
        }

         // get db values
        public String dbgett(string qu)
        {
            String gett;

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            MySqlCommand cmd = con.CreateCommand();

            try
            {

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = qu;
               

                object p = cmd.ExecuteScalar();
                gett = p.ToString();
                con.Close();
                return gett;
            }

            catch (Exception e)
            {
                MessageBox.Show("Something Wrong.Please Check your Database Connection!"+e, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

                return "Error";
            }
        }

        }
        }

    


