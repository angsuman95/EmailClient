using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace EmailProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!emailTB.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("You need to provide an email @gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                sendEmailButton.Enabled = false;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(emailTB.Text);
                message.Subject = subjectTB.Text;
                message.Body = bodyTB.Text;
                foreach (string s in recipiantsTB.Text.Split(';'))
                    message.To.Add(s);
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(emailTB.Text, passwordTB.Text);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
            }

            catch
            {
                MessageBox.Show("There was an error sending the message. Make sure you have typed in\r\nyour credentials correctly and you have an internet connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                sendEmailButton.Enabled = true;
            }
        }
    }
}
