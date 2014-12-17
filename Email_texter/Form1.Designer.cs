namespace Email_texter
{
    partial class Form1
    {
        // need to know how to do this-> http://www.youtube.com/watch?v=CDOXzz_0gYE
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.message_TextBox = new System.Windows.Forms.RichTextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.to_label = new System.Windows.Forms.Label();
            this.subject_label = new System.Windows.Forms.Label();
            this.message_label = new System.Windows.Forms.Label();
            this.to_textBox = new System.Windows.Forms.TextBox();
            this.subject_textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logIntoEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Login_panel = new System.Windows.Forms.Panel();
            this.Login_button = new System.Windows.Forms.Button();
            this.LoginPassTBox = new System.Windows.Forms.TextBox();
            this.LoginUserNameTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.sendTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_panel = new System.Windows.Forms.Panel();
            this.Texter_subject_Tbox = new System.Windows.Forms.TextBox();
            this.Phone_Tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone_label = new System.Windows.Forms.Label();
            this.Texter_button = new System.Windows.Forms.Button();
            this.Texter_msg_Tbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sprint_radio = new System.Windows.Forms.RadioButton();
            this.Cricket_radio = new System.Windows.Forms.RadioButton();
            this.US_Cellular_radio = new System.Windows.Forms.RadioButton();
            this.TMobile_radio = new System.Windows.Forms.RadioButton();
            this.Verizon_radio = new System.Windows.Forms.RadioButton();
            this.ATT_radio = new System.Windows.Forms.RadioButton();
            this.Virgin_mobile_radio = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.Login_panel.SuspendLayout();
            this.Text_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // message_TextBox
            // 
            this.message_TextBox.Location = new System.Drawing.Point(12, 127);
            this.message_TextBox.Name = "message_TextBox";
            this.message_TextBox.Size = new System.Drawing.Size(389, 344);
            this.message_TextBox.TabIndex = 1;
            this.message_TextBox.Text = "";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(158, 477);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 2;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(12, 47);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(23, 13);
            this.to_label.TabIndex = 3;
            this.to_label.Text = "To:";
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(12, 78);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(43, 13);
            this.subject_label.TabIndex = 5;
            this.subject_label.Text = "Subject";
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Location = new System.Drawing.Point(12, 109);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(50, 13);
            this.message_label.TabIndex = 6;
            this.message_label.Text = "Message";
            // 
            // to_textBox
            // 
            this.to_textBox.Location = new System.Drawing.Point(61, 47);
            this.to_textBox.Name = "to_textBox";
            this.to_textBox.Size = new System.Drawing.Size(340, 20);
            this.to_textBox.TabIndex = 7;
            // 
            // subject_textBox
            // 
            this.subject_textBox.Location = new System.Drawing.Point(61, 75);
            this.subject_textBox.Name = "subject_textBox";
            this.subject_textBox.Size = new System.Drawing.Size(340, 20);
            this.subject_textBox.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logIntoEmailToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.sendTextToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logIntoEmailToolStripMenuItem
            // 
            this.logIntoEmailToolStripMenuItem.Name = "logIntoEmailToolStripMenuItem";
            this.logIntoEmailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logIntoEmailToolStripMenuItem.Text = "Log-in";
            this.logIntoEmailToolStripMenuItem.Click += new System.EventHandler(this.logIntoEmailToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Login_panel
            // 
            this.Login_panel.Controls.Add(this.Text_panel);
            this.Login_panel.Controls.Add(this.Login_button);
            this.Login_panel.Controls.Add(this.LoginPassTBox);
            this.Login_panel.Controls.Add(this.LoginUserNameTBox);
            this.Login_panel.Controls.Add(this.label2);
            this.Login_panel.Controls.Add(this.label1);
            this.Login_panel.Controls.Add(this.login_label);
            this.Login_panel.Location = new System.Drawing.Point(0, 0);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(412, 539);
            this.Login_panel.TabIndex = 10;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(158, 155);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // LoginPassTBox
            // 
            this.LoginPassTBox.Location = new System.Drawing.Point(91, 110);
            this.LoginPassTBox.Name = "LoginPassTBox";
            this.LoginPassTBox.PasswordChar = '*';
            this.LoginPassTBox.Size = new System.Drawing.Size(305, 20);
            this.LoginPassTBox.TabIndex = 4;
            // 
            // LoginUserNameTBox
            // 
            this.LoginUserNameTBox.Location = new System.Drawing.Point(91, 84);
            this.LoginUserNameTBox.Name = "LoginUserNameTBox";
            this.LoginUserNameTBox.Size = new System.Drawing.Size(305, 20);
            this.LoginUserNameTBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(111, 23);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(172, 24);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login to your Gmail";
            // 
            // sendTextToolStripMenuItem
            // 
            this.sendTextToolStripMenuItem.Name = "sendTextToolStripMenuItem";
            this.sendTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sendTextToolStripMenuItem.Text = "Send Text";
            this.sendTextToolStripMenuItem.Click += new System.EventHandler(this.sendTextToolStripMenuItem_Click);
            // 
            // Text_panel
            // 
            this.Text_panel.Controls.Add(this.groupBox1);
            this.Text_panel.Controls.Add(this.Texter_subject_Tbox);
            this.Text_panel.Controls.Add(this.Phone_Tbox);
            this.Text_panel.Controls.Add(this.label3);
            this.Text_panel.Controls.Add(this.label4);
            this.Text_panel.Controls.Add(this.Phone_label);
            this.Text_panel.Controls.Add(this.Texter_button);
            this.Text_panel.Controls.Add(this.Texter_msg_Tbox);
            this.Text_panel.Location = new System.Drawing.Point(0, 3);
            this.Text_panel.Name = "Text_panel";
            this.Text_panel.Size = new System.Drawing.Size(416, 536);
            this.Text_panel.TabIndex = 6;
            // 
            // Texter_subject_Tbox
            // 
            this.Texter_subject_Tbox.Location = new System.Drawing.Point(66, 98);
            this.Texter_subject_Tbox.Name = "Texter_subject_Tbox";
            this.Texter_subject_Tbox.Size = new System.Drawing.Size(335, 20);
            this.Texter_subject_Tbox.TabIndex = 15;
            // 
            // Phone_Tbox
            // 
            this.Phone_Tbox.Location = new System.Drawing.Point(66, 67);
            this.Phone_Tbox.Name = "Phone_Tbox";
            this.Phone_Tbox.Size = new System.Drawing.Size(335, 20);
            this.Phone_Tbox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subject";
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.Location = new System.Drawing.Point(14, 70);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(51, 13);
            this.Phone_label.TabIndex = 11;
            this.Phone_label.Text = "Phone #:";
            // 
            // Texter_button
            // 
            this.Texter_button.Location = new System.Drawing.Point(160, 500);
            this.Texter_button.Name = "Texter_button";
            this.Texter_button.Size = new System.Drawing.Size(75, 23);
            this.Texter_button.TabIndex = 10;
            this.Texter_button.Text = "Send";
            this.Texter_button.UseVisualStyleBackColor = true;
            this.Texter_button.Click += new System.EventHandler(this.Texter_button_Click);
            // 
            // Texter_msg_Tbox
            // 
            this.Texter_msg_Tbox.Location = new System.Drawing.Point(14, 150);
            this.Texter_msg_Tbox.Name = "Texter_msg_Tbox";
            this.Texter_msg_Tbox.Size = new System.Drawing.Size(389, 344);
            this.Texter_msg_Tbox.TabIndex = 9;
            this.Texter_msg_Tbox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Virgin_mobile_radio);
            this.groupBox1.Controls.Add(this.ATT_radio);
            this.groupBox1.Controls.Add(this.Verizon_radio);
            this.groupBox1.Controls.Add(this.TMobile_radio);
            this.groupBox1.Controls.Add(this.US_Cellular_radio);
            this.groupBox1.Controls.Add(this.Cricket_radio);
            this.groupBox1.Controls.Add(this.Sprint_radio);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 58);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrier of Number";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Sprint_radio
            // 
            this.Sprint_radio.AutoSize = true;
            this.Sprint_radio.Location = new System.Drawing.Point(98, 35);
            this.Sprint_radio.Name = "Sprint_radio";
            this.Sprint_radio.Size = new System.Drawing.Size(85, 17);
            this.Sprint_radio.TabIndex = 0;
            this.Sprint_radio.Text = "Sprint Nextel";
            this.Sprint_radio.UseVisualStyleBackColor = true;
            // 
            // Cricket_radio
            // 
            this.Cricket_radio.AutoSize = true;
            this.Cricket_radio.Location = new System.Drawing.Point(98, 14);
            this.Cricket_radio.Name = "Cricket_radio";
            this.Cricket_radio.Size = new System.Drawing.Size(58, 17);
            this.Cricket_radio.TabIndex = 1;
            this.Cricket_radio.Text = "Cricket";
            this.Cricket_radio.UseVisualStyleBackColor = true;
            // 
            // US_Cellular_radio
            // 
            this.US_Cellular_radio.AutoSize = true;
            this.US_Cellular_radio.Location = new System.Drawing.Point(203, 37);
            this.US_Cellular_radio.Name = "US_Cellular_radio";
            this.US_Cellular_radio.Size = new System.Drawing.Size(77, 17);
            this.US_Cellular_radio.TabIndex = 2;
            this.US_Cellular_radio.Text = "US Cellular";
            this.US_Cellular_radio.UseVisualStyleBackColor = true;
            // 
            // TMobile_radio
            // 
            this.TMobile_radio.AutoSize = true;
            this.TMobile_radio.Location = new System.Drawing.Point(203, 14);
            this.TMobile_radio.Name = "TMobile_radio";
            this.TMobile_radio.Size = new System.Drawing.Size(66, 17);
            this.TMobile_radio.TabIndex = 3;
            this.TMobile_radio.Text = "T-Mobile";
            this.TMobile_radio.UseVisualStyleBackColor = true;
            // 
            // Verizon_radio
            // 
            this.Verizon_radio.AutoSize = true;
            this.Verizon_radio.Checked = true;
            this.Verizon_radio.Location = new System.Drawing.Point(293, 14);
            this.Verizon_radio.Name = "Verizon_radio";
            this.Verizon_radio.Size = new System.Drawing.Size(60, 17);
            this.Verizon_radio.TabIndex = 4;
            this.Verizon_radio.TabStop = true;
            this.Verizon_radio.Text = "Verizon";
            this.Verizon_radio.UseVisualStyleBackColor = true;
            // 
            // ATT_radio
            // 
            this.ATT_radio.AutoSize = true;
            this.ATT_radio.Location = new System.Drawing.Point(36, 35);
            this.ATT_radio.Name = "ATT_radio";
            this.ATT_radio.Size = new System.Drawing.Size(52, 17);
            this.ATT_radio.TabIndex = 5;
            this.ATT_radio.Text = "AT&&T";
            this.ATT_radio.UseVisualStyleBackColor = true;
            // 
            // Virgin_mobile_radio
            // 
            this.Virgin_mobile_radio.AutoSize = true;
            this.Virgin_mobile_radio.Location = new System.Drawing.Point(294, 37);
            this.Virgin_mobile_radio.Name = "Virgin_mobile_radio";
            this.Virgin_mobile_radio.Size = new System.Drawing.Size(84, 17);
            this.Virgin_mobile_radio.TabIndex = 6;
            this.Virgin_mobile_radio.Text = "Virgin mobile";
            this.Virgin_mobile_radio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 539);
            this.Controls.Add(this.Login_panel);
            this.Controls.Add(this.subject_textBox);
            this.Controls.Add(this.to_textBox);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.subject_label);
            this.Controls.Add(this.to_label);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.message_TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Texter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            this.Text_panel.ResumeLayout(false);
            this.Text_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox message_TextBox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.TextBox to_textBox;
        private System.Windows.Forms.TextBox subject_textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logIntoEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox LoginPassTBox;
        private System.Windows.Forms.TextBox LoginUserNameTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.ToolStripMenuItem sendTextToolStripMenuItem;
        private System.Windows.Forms.Panel Text_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Texter_subject_Tbox;
        private System.Windows.Forms.TextBox Phone_Tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.Button Texter_button;
        private System.Windows.Forms.RichTextBox Texter_msg_Tbox;
        private System.Windows.Forms.RadioButton Virgin_mobile_radio;
        private System.Windows.Forms.RadioButton ATT_radio;
        private System.Windows.Forms.RadioButton Verizon_radio;
        private System.Windows.Forms.RadioButton TMobile_radio;
        private System.Windows.Forms.RadioButton US_Cellular_radio;
        private System.Windows.Forms.RadioButton Cricket_radio;
        private System.Windows.Forms.RadioButton Sprint_radio;
    }
}

