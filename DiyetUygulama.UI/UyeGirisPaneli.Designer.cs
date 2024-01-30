namespace DiyetUygulama.UI
{
    partial class UyeGirisPaneli
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
            label2 = new Label();
            txt_sifre = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "E-Mail:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(140, 40);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(256, 27);
            txt_email.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 76);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Şifre:";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(140, 73);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(256, 27);
            txt_sifre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(140, 106);
            button1.Name = "button1";
            button1.Size = new Size(256, 32);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // UyeGirisPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 180);
            Controls.Add(button1);
            Controls.Add(txt_sifre);
            Controls.Add(label2);
            Controls.Add(txt_email);
            Controls.Add(label1);
            Name = "UyeGirisPaneli";
            Text = "UyeGirisPaneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_sifre;
        private Button button1;
    }
}