namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    partial class FormVucutYagOrani
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
            txt_boy = new TextBox();
            label2 = new Label();
            txt_boyun = new TextBox();
            label3 = new Label();
            txt_bel = new TextBox();
            label4 = new Label();
            txt_kalca = new TextBox();
            rdb_erkek = new RadioButton();
            rdb_kadin = new RadioButton();
            btn_hesapla = new Button();
            label5 = new Label();
            txt_yagOrani = new TextBox();
            pb_resim = new PictureBox();
            lbl_oranSonucu = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_resim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 22);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Boyunuz";
            // 
            // txt_boy
            // 
            txt_boy.Location = new Point(55, 55);
            txt_boy.Name = "txt_boy";
            txt_boy.PlaceholderText = "__(cm)";
            txt_boy.Size = new Size(221, 27);
            txt_boy.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 95);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 0;
            label2.Text = "Boyun Çevresi";
            // 
            // txt_boyun
            // 
            txt_boyun.Location = new Point(55, 128);
            txt_boyun.Name = "txt_boyun";
            txt_boyun.PlaceholderText = "__(cm)";
            txt_boyun.Size = new Size(221, 27);
            txt_boyun.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 176);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 0;
            label3.Text = "Bel Çevresi ";
            // 
            // txt_bel
            // 
            txt_bel.Location = new Point(55, 209);
            txt_bel.Name = "txt_bel";
            txt_bel.PlaceholderText = "__(cm)";
            txt_bel.Size = new Size(221, 27);
            txt_bel.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 256);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 0;
            label4.Text = "Kalça Çevresi ";
            // 
            // txt_kalca
            // 
            txt_kalca.Location = new Point(55, 289);
            txt_kalca.Name = "txt_kalca";
            txt_kalca.PlaceholderText = "__(cm)";
            txt_kalca.Size = new Size(221, 27);
            txt_kalca.TabIndex = 1;
            // 
            // rdb_erkek
            // 
            rdb_erkek.AutoSize = true;
            rdb_erkek.Location = new Point(65, 340);
            rdb_erkek.Name = "rdb_erkek";
            rdb_erkek.Size = new Size(65, 24);
            rdb_erkek.TabIndex = 2;
            rdb_erkek.TabStop = true;
            rdb_erkek.Text = "Erkek";
            rdb_erkek.UseVisualStyleBackColor = true;
            // 
            // rdb_kadin
            // 
            rdb_kadin.AutoSize = true;
            rdb_kadin.Location = new Point(188, 340);
            rdb_kadin.Name = "rdb_kadin";
            rdb_kadin.Size = new Size(68, 24);
            rdb_kadin.TabIndex = 2;
            rdb_kadin.TabStop = true;
            rdb_kadin.Text = "Kadın";
            rdb_kadin.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Location = new Point(102, 371);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(110, 58);
            btn_hesapla.TabIndex = 3;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 369);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 0;
            label5.Text = "Yağ Oranınız";
            // 
            // txt_yagOrani
            // 
            txt_yagOrani.Enabled = false;
            txt_yagOrani.Location = new Point(307, 402);
            txt_yagOrani.Name = "txt_yagOrani";
            txt_yagOrani.Size = new Size(221, 27);
            txt_yagOrani.TabIndex = 1;
            // 
            // pb_resim
            // 
            pb_resim.Location = new Point(407, 22);
            pb_resim.Name = "pb_resim";
            pb_resim.Size = new Size(290, 336);
            pb_resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_resim.TabIndex = 4;
            pb_resim.TabStop = false;
            // 
            // lbl_oranSonucu
            // 
            lbl_oranSonucu.AutoSize = true;
            lbl_oranSonucu.Location = new Point(558, 405);
            lbl_oranSonucu.Name = "lbl_oranSonucu";
            lbl_oranSonucu.Size = new Size(50, 20);
            lbl_oranSonucu.TabIndex = 5;
            lbl_oranSonucu.Text = "label6";
            // 
            // FormVucutYagOrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_oranSonucu);
            Controls.Add(pb_resim);
            Controls.Add(btn_hesapla);
            Controls.Add(rdb_kadin);
            Controls.Add(rdb_erkek);
            Controls.Add(txt_kalca);
            Controls.Add(label4);
            Controls.Add(txt_bel);
            Controls.Add(label3);
            Controls.Add(txt_boyun);
            Controls.Add(label2);
            Controls.Add(txt_yagOrani);
            Controls.Add(txt_boy);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "FormVucutYagOrani";
            Text = "FormVucutYagOrani";
            ((System.ComponentModel.ISupportInitialize)pb_resim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_boy;
        private Label label2;
        private TextBox txt_boyun;
        private Label label3;
        private TextBox txt_bel;
        private Label label4;
        private TextBox txt_kalca;
        private RadioButton rdb_erkek;
        private RadioButton rdb_kadin;
        private Button btn_hesapla;
        private Label label5;
        private TextBox txt_yagOrani;
        private PictureBox pb_resim;
        private Label lbl_oranSonucu;
    }
}