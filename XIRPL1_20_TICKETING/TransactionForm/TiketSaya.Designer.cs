namespace XIRPL1_20_TICKETING.TransactionForm
{
    partial class TiketSaya
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
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(174, 32);
            label6.TabIndex = 11;
            label6.Text = "< Tiket Saya";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 41);
            label7.Name = "label7";
            label7.Size = new Size(259, 15);
            label7.TabIndex = 27;
            label7.Text = "Semua tiket anda yang aktif akan muncul di sini";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(27, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 202);
            panel3.TabIndex = 28;
            // 
            // TiketSaya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "TiketSaya";
            Text = "TiketSaya";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label7;
        private Panel panel3;
    }
}