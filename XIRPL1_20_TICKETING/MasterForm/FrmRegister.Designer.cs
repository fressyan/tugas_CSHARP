namespace XIRPL1_20_TICKETING.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtNmrtlpn = new TextBox();
            txtTgllahir = new TextBox();
            txtNama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtLinkLabel = new LinkLabel();
            btnDaftar = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(164, 101);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(164, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtNmrtlpn
            // 
            txtNmrtlpn.Location = new Point(164, 188);
            txtNmrtlpn.Name = "txtNmrtlpn";
            txtNmrtlpn.Size = new Size(100, 23);
            txtNmrtlpn.TabIndex = 2;
            // 
            // txtTgllahir
            // 
            txtTgllahir.Location = new Point(164, 159);
            txtTgllahir.Name = "txtTgllahir";
            txtTgllahir.Size = new Size(100, 23);
            txtTgllahir.TabIndex = 3;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(164, 130);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(100, 23);
            txtNama.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 101);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 217);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 188);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 7;
            label3.Text = "Nomer Telepon";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 159);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 8;
            label4.Text = "Tanggal Lahir";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 130);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Nama";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(9, 9);
            label6.Name = "label6";
            label6.Size = new Size(149, 32);
            label6.TabIndex = 10;
            label6.Text = "Daftar akun";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 41);
            label7.Name = "label7";
            label7.Size = new Size(304, 15);
            label7.TabIndex = 11;
            label7.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Location = new Point(402, 426);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(37, 15);
            txtLinkLabel.TabIndex = 13;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Login";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(307, 277);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(75, 23);
            btnDaftar.TabIndex = 14;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 426);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 15;
            label8.Text = "Sudah punya akun?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 155);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(btnDaftar);
            Controls.Add(txtLinkLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNama);
            Controls.Add(txtTgllahir);
            Controls.Add(txtNmrtlpn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "FrmRegister";
            Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNmrtlpn;
        private TextBox txtTgllahir;
        private TextBox txtNama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private LinkLabel txtLinkLabel;
        private Button btnDaftar;
        private Label label8;
        private PictureBox pictureBox1;
    }
}