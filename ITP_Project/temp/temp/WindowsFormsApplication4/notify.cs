using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication4
{
    public partial class notify : UserControl
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        private static notify _instance;
        public static notify Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new notify();
                return _instance;

            }


        }
        public notify()
        {
            InitializeComponent();
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           if (txtTo.Text != "" && txtMessage.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                try {
                    login = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                    client = new SmtpClient(txtSmtp.Text);
                    client.Port = Convert.ToInt32(txtPort.Text);
                    client.EnableSsl = ChkSSL.Checked;
                    client.Credentials = login;
                    msg = new MailMessage { From = new MailAddress(txtUsername.Text + txtSmtp.Text.Replace("smtp.", "@"), "dinukachinthana", Encoding.UTF8) };
                    msg.To.Add(new MailAddress(txtTo.Text));
                    if (!string.IsNullOrEmpty(txtCC.Text))
                        msg.To.Add(new MailAddress(txtCC.Text));

                    msg.Subject = txtSubject.Text;
                    msg.Body = txtMessage.Text;
                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.Priority = MailPriority.Normal;
                    msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                    string userstate = "Sending...";
                    client.SendAsync(msg, userstate);

                }

                catch ( Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            else
            {

                MessageBox.Show("Some Important Fields are not Completed.!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
        

            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send cancelled.!", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your Message has been Succesfully Sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    

        private void button3_Click(object sender, EventArgs e)
        {
          
        
        }

        private void txtTo_Leave(object sender, EventArgs e)
        {
            if (txtTo.Text == "")
            {
                txtTo.Text = "Enter Email";
                txtTo.ForeColor = Color.DimGray;
            }

            try
            {

                if (!this.txtTo.Text.Contains('@') || !this.txtTo.Text.Contains('.'))
                {
                    MessageBox.Show("Enter a Valid Email Address", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChkSSL_OnChange(object sender, EventArgs e)
        {

        }

        private void btnSnd_Click(object sender, EventArgs e)
        {
            string to, from, msg, pwd;
            MailMessage message = new MailMessage();
            to = (txtPhone.Text).ToString();
            from = (txtGmail.Text).ToString();
            msg = (txtMess.Text).ToString();
            pwd = (txtPass.Text).ToString();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = msg;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pwd);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Message Send Succesfully.!", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtPhone.Text = " ";
            txtGmail.Text = " ";
            txtPass.Text = " ";
            txtMess.Text = " ";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (!panel1.Controls.Contains(EmailView.Instance))
            {
                panel1.Controls.Add(EmailView.Instance);
                EmailView.Instance.Dock = DockStyle.Fill;
                EmailView.Instance.BringToFront();
            }
            else
                EmailView.Instance.BringToFront();
                EmailView.Instance.Visible = true;
        }
    }
}
