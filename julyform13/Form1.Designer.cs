namespace julyform13
{
    partial class Classic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblusername = new Label();
            txtuser = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            Btncreate = new Button();
            Btnlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblusername.Location = new Point(398, 130);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(84, 19);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username";
            // 
            // txtuser
            // 
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Location = new Point(508, 134);
            txtuser.Name = "txtuser";
            txtuser.ScrollBars = ScrollBars.Vertical;
            txtuser.Size = new Size(210, 16);
            txtuser.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(508, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 16);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(398, 182);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.XF6gN63;
            pictureBox1.Location = new Point(3, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 307);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 35);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Castellar", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 9);
            label2.Name = "label2";
            label2.Size = new Size(173, 25);
            label2.TabIndex = 0;
            label2.Text = "login form";
            // 
            // Btncreate
            // 
            Btncreate.BackColor = Color.FromArgb(128, 64, 64);
            Btncreate.Location = new Point(408, 253);
            Btncreate.Name = "Btncreate";
            Btncreate.Size = new Size(106, 32);
            Btncreate.TabIndex = 6;
            Btncreate.Text = "Create account";
            Btncreate.UseVisualStyleBackColor = false;
            Btncreate.Click += button1_Click;
            // 
            // Btnlogin
            // 
            Btnlogin.BackColor = Color.FromArgb(255, 192, 128);
            Btnlogin.Location = new Point(627, 253);
            Btnlogin.Name = "Btnlogin";
            Btnlogin.Size = new Size(75, 32);
            Btnlogin.TabIndex = 7;
            Btnlogin.Text = "Login";
            Btnlogin.UseVisualStyleBackColor = false;
            Btnlogin.Click += button2_Click;
            // 
            // Classic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 307);
            Controls.Add(Btnlogin);
            Controls.Add(Btncreate);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtuser);
            Controls.Add(lblusername);
            Name = "Classic";
            Text = "Login";
            Load += classic_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private TextBox txtuser;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button Btncreate;
        private Button Btnlogin;
    }
}