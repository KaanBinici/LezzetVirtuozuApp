namespace DiyetUygulama.UI
{
    partial class GirisEkrani
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
            btn_uye = new Button();
            btn_admin = new Button();
            label1 = new Label();
            label2 = new Label();
            lbl_kayit = new Label();
            SuspendLayout();
            // 
            // btn_uye
            // 
            btn_uye.Location = new Point(231, 111);
            btn_uye.Name = "btn_uye";
            btn_uye.Size = new Size(130, 72);
            btn_uye.TabIndex = 2;
            btn_uye.Text = "Üye Girişi";
            btn_uye.UseVisualStyleBackColor = true;
            btn_uye.Click += btn_uye_Click;
            // 
            // btn_admin
            // 
            btn_admin.Location = new Point(39, 111);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(130, 72);
            btn_admin.TabIndex = 1;
            btn_admin.Text = "Admin Girişi";
            btn_admin.UseVisualStyleBackColor = true;
            btn_admin.Click += btn_admin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 37);
            label1.Name = "label1";
            label1.Size = new Size(255, 35);
            label1.TabIndex = 1;
            label1.Text = "DİYET UYGULAMASI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 269);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 3;
            label2.Text = "Üye Kaydı İçin";
            // 
            // lbl_kayit
            // 
            lbl_kayit.AutoSize = true;
            lbl_kayit.ForeColor = Color.Blue;
            lbl_kayit.Location = new Point(219, 269);
            lbl_kayit.Name = "lbl_kayit";
            lbl_kayit.Size = new Size(43, 20);
            lbl_kayit.TabIndex = 3;
            lbl_kayit.Text = "Tıkla.";
            lbl_kayit.Click += lbl_kayit_Click;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 298);
            Controls.Add(lbl_kayit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_admin);
            Controls.Add(btn_uye);
            Name = "GirisEkrani";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_uye;
        private Button btn_admin;
        private Label label1;
        private Label label2;
        private Label lbl_kayit;
    }
}
