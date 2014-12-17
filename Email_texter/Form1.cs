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

            Login_panel.Visible = true;
            Text_panel.Visible = false;
        }
        
        private string Login { get; set; }
        private string Password { get; set; }

        private void email_init(string to, string subject, string body)
        {

            MailMessage msg = new MailMessage();//from/to
            msg.From = new MailAddress(Login, "Test");// Email/name of person
            msg.To.Add(to);//this is the address the message will go to
            // msg.From = new MailAddress(from_textBox.Text);//(from, display name)
            // msg.To.Add(new MailAddress(to_textBox.Text));// can have multiple To
            msg.Subject = subject;
            msg.Body = body;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);// (SMTP server, port)
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(Login, Password);// user name and password
            client.EnableSsl = true;
            //msg.Attachments.Add(new Attachment(@"C:/Users?My Documents/...", "application/octet-stream"));// Might have to look this one up not sure how to fully use
            try
            {
                client.Send(msg);
            }
            catch (Exception dang)
            {
                MessageBox.Show("The message did not go through due to the following error: " + dang.Message);
            }

        }

        //https://www.digitalocean.com/community/tutorials/how-to-use-google-s-smtp-server
        private void send_button_Click(object sender, EventArgs e)
        {
            email_init(to_textBox.Text, subject_textBox.Text, message_TextBox.Text);
        }

        private void logIntoEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_panel.Visible = true;
            Text_panel.Visible = false;
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Login = LoginUserNameTBox.Text;
            Password = LoginPassTBox.Text;
            Login_panel.Visible = false;
            Text_panel.Visible = true;
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_panel.Visible = false;
            Text_panel.Visible = false;
        }

        private void sendTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_panel.Visible = false;
            Text_panel.Visible = true;
        }

        private void Texter_button_Click(object sender, EventArgs e)
        {
            if (Verizon_radio.Checked == true)
            {
                email_init(Phone_Tbox.Text + "@vtext.com", Texter_subject_Tbox.Text, Texter_msg_Tbox.Text);
            }
            else if (ATT_radio.Checked == true)
            {
                email_init(Phone_Tbox.Text + "@text.att.net", Texter_subject_Tbox.Text, Texter_msg_Tbox.Text);
            }
            else if (Sprint_radio.Checked == true)
            {
                email_init(Phone_Tbox.Text + "@text.att.net", Texter_subject_Tbox.Text, Texter_msg_Tbox.Text);
            }
            else if (TMobile_radio.Checked == true)
            {
                email_init(Phone_Tbox.Text + "@tmomail.net", Texter_subject_Tbox.Text, Texter_msg_Tbox.Text);
            }
            else if (US_Cellular_radio.Checked == true)
            {
                email_init(Phone_Tbox.Text + "@email.uscc.net", Texter_subject_Tbox.Text, Texter_msg_Tbox.Text);
            }
            else if (Virgin_mobile_radio.Checked == true)
            {
                email_init(Phone_Tbox.Text + "@vmobl.com", Texter_subject_Tbox.Text, Texter_msg_Tbox.Text);
            }
            else if (Cricket_radio.Checked == true)
            {
                email_init(Phone_Tbox.Text + "@sms.mycricket.com", Texter_subject_Tbox.Text, Texter_msg_Tbox.Text);
            }
        }
    }
}
