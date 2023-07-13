namespace julyform13
{
    partial class Createaccount
    {
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
            txtbuser = new TextBox();
            lblusername = new Label();
            lblconfpass = new Label();
            txtbpass = new TextBox();
            lblpass = new Label();
            txtcpass = new TextBox();
            lblpno = new Label();
            txtbno = new TextBox();
            lblmail = new Label();
            txtmail = new TextBox();
            lblgender = new Label();
            Rbtnmale = new RadioButton();
            rbtnothers = new RadioButton();
            rbtnfemale = new RadioButton();
            lblfname = new Label();
            txtbfname = new TextBox();
            Btnlogin = new Button();
            Btncreate = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtbuser
            // 
            txtbuser.Location = new Point(457, 105);
            txtbuser.Name = "txtbuser";
            txtbuser.Size = new Size(168, 23);
            txtbuser.TabIndex = 1;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(390, 113);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(60, 15);
            lblusername.TabIndex = 2;
            lblusername.Text = "Username";
            // 
            // lblconfpass
            // 
            lblconfpass.AutoSize = true;
            lblconfpass.Location = new Point(344, 258);
            lblconfpass.Name = "lblconfpass";
            lblconfpass.Size = new Size(107, 15);
            lblconfpass.TabIndex = 4;
            lblconfpass.Text = "Conferm password";
            // 
            // txtbpass
            // 
            txtbpass.Location = new Point(457, 209);
            txtbpass.Name = "txtbpass";
            txtbpass.Size = new Size(168, 23);
            txtbpass.TabIndex = 3;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(393, 217);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(57, 15);
            lblpass.TabIndex = 6;
            lblpass.Text = "Password";
            // 
            // txtcpass
            // 
            txtcpass.Location = new Point(457, 250);
            txtcpass.Name = "txtcpass";
            txtcpass.Size = new Size(168, 23);
            txtcpass.TabIndex = 5;
            // 
            // lblpno
            // 
            lblpno.AutoSize = true;
            lblpno.Location = new Point(365, 173);
            lblpno.Name = "lblpno";
            lblpno.Size = new Size(86, 15);
            lblpno.TabIndex = 8;
            lblpno.Text = "Phone number";
            // 
            // txtbno
            // 
            txtbno.Location = new Point(457, 173);
            txtbno.Name = "txtbno";
            txtbno.Size = new Size(168, 23);
            txtbno.TabIndex = 7;
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Location = new Point(393, 152);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(36, 15);
            lblmail.TabIndex = 10;
            lblmail.Text = "Email";
            // 
            // txtmail
            // 
            txtmail.Location = new Point(457, 144);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(168, 23);
            txtmail.TabIndex = 9;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(393, 306);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(45, 15);
            lblgender.TabIndex = 11;
            lblgender.Text = "Gender";
            // 
            // Rbtnmale
            // 
            Rbtnmale.AutoSize = true;
            Rbtnmale.Location = new Point(457, 304);
            Rbtnmale.Name = "Rbtnmale";
            Rbtnmale.Size = new Size(51, 19);
            Rbtnmale.TabIndex = 12;
            Rbtnmale.TabStop = true;
            Rbtnmale.Text = "male";
            Rbtnmale.UseVisualStyleBackColor = true;
            // 
            // rbtnothers
            // 
            rbtnothers.AutoSize = true;
            rbtnothers.Location = new Point(596, 304);
            rbtnothers.Name = "rbtnothers";
            rbtnothers.Size = new Size(60, 19);
            rbtnothers.TabIndex = 13;
            rbtnothers.TabStop = true;
            rbtnothers.Text = "Others";
            rbtnothers.UseVisualStyleBackColor = true;
            // 
            // rbtnfemale
            // 
            rbtnfemale.AutoSize = true;
            rbtnfemale.Location = new Point(514, 304);
            rbtnfemale.Name = "rbtnfemale";
            rbtnfemale.Size = new Size(63, 19);
            rbtnfemale.TabIndex = 14;
            rbtnfemale.TabStop = true;
            rbtnfemale.Text = "Female";
            rbtnfemale.UseVisualStyleBackColor = true;
            rbtnfemale.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // lblfname
            // 
            lblfname.AutoSize = true;
            lblfname.Location = new Point(393, 84);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(56, 15);
            lblfname.TabIndex = 16;
            lblfname.Text = "Fullname";
            // 
            // txtbfname
            // 
            txtbfname.Location = new Point(457, 76);
            txtbfname.Name = "txtbfname";
            txtbfname.Size = new Size(168, 23);
            txtbfname.TabIndex = 15;
            // 
            // Btnlogin
            // 
            Btnlogin.Location = new Point(344, 338);
            Btnlogin.Name = "Btnlogin";
            Btnlogin.Size = new Size(75, 39);
            Btnlogin.TabIndex = 17;
            Btnlogin.Text = "Login";
            Btnlogin.UseVisualStyleBackColor = true;
            Btnlogin.Click += btnlogin_Click;
            // 
            // Btncreate
            // 
            Btncreate.Location = new Point(616, 338);
            Btncreate.Name = "Btncreate";
            Btncreate.Size = new Size(75, 39);
            Btncreate.TabIndex = 18;
            Btncreate.Text = "Create";
            Btncreate.UseVisualStyleBackColor = true;
            Btncreate.Click += btncreate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 389);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 152);
            label1.Name = "label1";
            label1.Size = new Size(172, 27);
            label1.TabIndex = 0;
            label1.Text = "Create accout";
            // 
            // Createaccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(760, 389);
            Controls.Add(panel1);
            Controls.Add(Btncreate);
            Controls.Add(Btnlogin);
            Controls.Add(lblfname);
            Controls.Add(txtbfname);
            Controls.Add(rbtnfemale);
            Controls.Add(rbtnothers);
            Controls.Add(Rbtnmale);
            Controls.Add(lblgender);
            Controls.Add(lblmail);
            Controls.Add(txtmail);
            Controls.Add(lblpno);
            Controls.Add(txtbno);
            Controls.Add(lblpass);
            Controls.Add(txtcpass);
            Controls.Add(lblconfpass);
            Controls.Add(txtbpass);
            Controls.Add(lblusername);
            Controls.Add(txtbuser);
            Name = "Createaccount";
            RightToLeftLayout = true;
            Text = "Createaccount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbuser;
        private Label lblusername;
        private Label lblconfpass;
        private TextBox txtbpass;
        private Label lblpass;
        private TextBox txtcpass;
        private Label lblpno;
        private TextBox txtbno;
        private Label lblmail;
        private TextBox txtmail;
        private Label lblgender;
        private RadioButton Rbtnmale;
        private RadioButton rbtnothers;
        private RadioButton rbtnfemale;
        private Label lblfname;
        private TextBox txtbfname;
        private Button Btnlogin;
        private Button Btncreate;
        private Panel panel1;
        private Label label1;
    }
}