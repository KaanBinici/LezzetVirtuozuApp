namespace DiyetUygulama.UI
{
    partial class AdminGirisPaneli
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
            label1 = new Label();
            txt_email = new TextBox();
            btn_giris = new Button();
            label2 = new Label();
            txt_sifre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "E-Mail:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(154, 29);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(256, 27);
            txt_email.TabIndex = 1;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(154, 95);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(256, 32);
            btn_giris.TabIndex = 2;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 65);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Şifre:";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(154, 62);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(256, 27);
            txt_sifre.TabIndex = 1;
            // 
            // AdminGirisPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 164);
            Controls.Add(btn_giris);
            Controls.Add(txt_sifre);
            Controls.Add(label2);
            Controls.Add(txt_email);
            Controls.Add(label1);
            Name = "AdminGirisPaneli";
            Text = "AdminPaneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_email;
        private Button btn_giris;
        private Label label2;
        private TextBox txt_sifre;
    }
}