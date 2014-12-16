using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Email_texter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //https://www.digitalocean.com/community/tutorials/how-to-use-google-s-smtp-server
        private void send_button_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 465);// (SMTP server, port)
            client.Credentials = new NetworkCredential("userName@company.com", "password");// user name and password
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(from_textBox.Text);//(from, display name)
            msg.To.Add(new MailAddress(to_textBox.Text));// can have multiple To
            msg.Subject = subject_textBox.Text;
            msg.Body = message_TextBox.Text;
            //msg.Attachments.Add(new Attachment(@"C:/Users?My Documents/...", "application/octet-stream"));// Might have to look this one up not sure how to fully use
            try
            {
                client.Send(msg);
            }
            catch(Exception dang)
            {
                MessageBox.Show("The message did not go through due to the following error: " + dang.Message);
            }
        }

        private void logIntoEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_panel.Visible = true;
        }

        private void Login_button_Click(object sender, EventArgs e)
        {

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_panel.Visible = false;
        }
    }
}
