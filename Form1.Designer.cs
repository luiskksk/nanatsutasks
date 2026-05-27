namespace NanatusuTasks
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblTittle = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            txtEmailLogin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(312, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 461);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fa85c1b40eea45ef823660d05c176f65;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 461);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(lblTittle);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(txtEmailLogin);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(249, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 461);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.png_transparent_the_seven_deadly_sins_meliodas_tattoo_nanatzu_no_taizai_leaf_symmetry_sticker;
            pictureBox3.Location = new Point(232, 395);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(269, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(253, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log-in your Account";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(10, 337);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(244, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register your Account";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Viner Hand ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTittle.Location = new Point(125, 26);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(297, 44);
            lblTittle.TabIndex = 4;
            lblTittle.Text = "Create your Account";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(9, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Type you Password";
            txtPassword.Size = new Size(516, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(10, 218);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 26);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(10, 143);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 26);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail";
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.BackColor = SystemColors.Window;
            txtEmailLogin.Location = new Point(10, 172);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.PlaceholderText = "Type you EMAIL";
            txtEmailLogin.Size = new Size(516, 23);
            txtEmailLogin.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label lblEmail;
        private TextBox txtEmailLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblTittle;
        private PictureBox pictureBox3;
    }
}
