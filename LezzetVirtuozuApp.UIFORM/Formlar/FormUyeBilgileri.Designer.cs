namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    partial class FormUyeBilgileri
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
            txt_boy = new TextBox();
            txt_soyad = new TextBox();
            txt_ad = new TextBox();
            label5 = new Label();
            rdb_erkek = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_kaydet = new Button();
            btn_resimEkle = new Button();
            txt_kilo = new TextBox();
            cmb_alerji1 = new ComboBox();
            cmb_alerji2 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            pb_resimUye = new PictureBox();
            rdb_kadin = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            txt_yagOrani = new TextBox();
            label9 = new Label();
            txt_suTuketimi = new TextBox();
            dtp_dogumGunu = new DateTimePicker();
            label10 = new Label();
            chk_diyabetMi = new CheckBox();
            label11 = new Label();
            txt_kitleEndeksi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pb_resimUye).BeginInit();
            SuspendLayout();
            // 
            // txt_boy
            // 
            txt_boy.Location = new Point(185, 82);
            txt_boy.Name = "txt_boy";
            txt_boy.Size = new Size(205, 27);
            txt_boy.TabIndex = 3;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(185, 49);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(205, 27);
            txt_soyad.TabIndex = 2;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(185, 18);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(205, 27);
            txt_ad.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 118);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 17;
            label5.Text = "Kilo:";
            // 
            // rdb_erkek
            // 
            rdb_erkek.AutoSize = true;
            rdb_erkek.Location = new Point(204, 162);
            rdb_erkek.Name = "rdb_erkek";
            rdb_erkek.Size = new Size(65, 24);
            rdb_erkek.TabIndex = 16;
            rdb_erkek.TabStop = true;
            rdb_erkek.Text = "Erkek";
            rdb_erkek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 85);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 15;
            label3.Text = "Boy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 52);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 14;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 13;
            label1.Text = "Adı:";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_kaydet.FlatStyle = FlatStyle.Flat;
            btn_kaydet.Location = new Point(445, 399);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(118, 41);
            btn_kaydet.TabIndex = 24;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // btn_resimEkle
            // 
            btn_resimEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_resimEkle.FlatStyle = FlatStyle.Flat;
            btn_resimEkle.Location = new Point(606, 288);
            btn_resimEkle.Name = "btn_resimEkle";
            btn_resimEkle.Size = new Size(112, 48);
            btn_resimEkle.TabIndex = 22;
            btn_resimEkle.Text = "Resim Ekle";
            btn_resimEkle.UseVisualStyleBackColor = true;
            btn_resimEkle.Click += btn_resimEkle_Click;
            // 
            // txt_kilo
            // 
            txt_kilo.Location = new Point(185, 115);
            txt_kilo.Name = "txt_kilo";
            txt_kilo.Size = new Size(205, 27);
            txt_kilo.TabIndex = 4;
            // 
            // cmb_alerji1
            // 
            cmb_alerji1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_alerji1.FormattingEnabled = true;
            cmb_alerji1.Location = new Point(185, 354);
            cmb_alerji1.Name = "cmb_alerji1";
            cmb_alerji1.Size = new Size(205, 28);
            cmb_alerji1.TabIndex = 25;
            // 
            // cmb_alerji2
            // 
            cmb_alerji2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_alerji2.FormattingEnabled = true;
            cmb_alerji2.Location = new Point(185, 388);
            cmb_alerji2.Name = "cmb_alerji2";
            cmb_alerji2.Size = new Size(205, 28);
            cmb_alerji2.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 357);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 17;
            label4.Text = "Alerji1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 391);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 17;
            label6.Text = "Alerji2:";
            // 
            // pb_resimUye
            // 
            pb_resimUye.Location = new Point(564, 35);
            pb_resimUye.Name = "pb_resimUye";
            pb_resimUye.Size = new Size(197, 238);
            pb_resimUye.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_resimUye.TabIndex = 26;
            pb_resimUye.TabStop = false;
            // 
            // rdb_kadin
            // 
            rdb_kadin.AutoSize = true;
            rdb_kadin.Location = new Point(296, 162);
            rdb_kadin.Name = "rdb_kadin";
            rdb_kadin.Size = new Size(68, 24);
            rdb_kadin.TabIndex = 16;
            rdb_kadin.TabStop = true;
            rdb_kadin.Text = "Kadın";
            rdb_kadin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 164);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 17;
            label7.Text = "Cinsiyet:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 291);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 17;
            label8.Text = "Yağ Oranı (%):";
            // 
            // txt_yagOrani
            // 
            txt_yagOrani.Enabled = false;
            txt_yagOrani.Location = new Point(185, 288);
            txt_yagOrani.Name = "txt_yagOrani";
            txt_yagOrani.Size = new Size(205, 27);
            txt_yagOrani.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 324);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 17;
            label9.Text = "Su Tüketimi (lt):";
            // 
            // txt_suTuketimi
            // 
            txt_suTuketimi.Enabled = false;
            txt_suTuketimi.Location = new Point(185, 321);
            txt_suTuketimi.Name = "txt_suTuketimi";
            txt_suTuketimi.Size = new Size(205, 27);
            txt_suTuketimi.TabIndex = 6;
            // 
            // dtp_dogumGunu
            // 
            dtp_dogumGunu.Location = new Point(185, 209);
            dtp_dogumGunu.Name = "dtp_dogumGunu";
            dtp_dogumGunu.Size = new Size(205, 27);
            dtp_dogumGunu.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 214);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 28;
            label10.Text = "Doğum Tarihi:";
            // 
            // chk_diyabetMi
            // 
            chk_diyabetMi.AutoSize = true;
            chk_diyabetMi.Location = new Point(47, 428);
            chk_diyabetMi.Name = "chk_diyabetMi";
            chk_diyabetMi.Size = new Size(86, 24);
            chk_diyabetMi.TabIndex = 29;
            chk_diyabetMi.Text = "Diyabet:";
            chk_diyabetMi.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 258);
            label11.Name = "label11";
            label11.Size = new Size(96, 20);
            label11.TabIndex = 17;
            label11.Text = "Kitle Endeksi:";
            // 
            // txt_kitleEndeksi
            // 
            txt_kitleEndeksi.Enabled = false;
            txt_kitleEndeksi.Location = new Point(185, 255);
            txt_kitleEndeksi.Name = "txt_kitleEndeksi";
            txt_kitleEndeksi.Size = new Size(205, 27);
            txt_kitleEndeksi.TabIndex = 5;
            // 
            // FormUyeBilgileri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 464);
            Controls.Add(chk_diyabetMi);
            Controls.Add(label10);
            Controls.Add(dtp_dogumGunu);
            Controls.Add(pb_resimUye);
            Controls.Add(cmb_alerji2);
            Controls.Add(cmb_alerji1);
            Controls.Add(btn_kaydet);
            Controls.Add(btn_resimEkle);
            Controls.Add(txt_suTuketimi);
            Controls.Add(txt_kitleEndeksi);
            Controls.Add(txt_yagOrani);
            Controls.Add(txt_kilo);
            Controls.Add(txt_boy);
            Controls.Add(txt_soyad);
            Controls.Add(txt_ad);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(rdb_kadin);
            Controls.Add(rdb_erkek);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUyeBilgileri";
            Text = "FormUyeBilgileri";
            Load += FormUyeBilgileri_Load;
            ((System.ComponentModel.ISupportInitialize)pb_resimUye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_boy;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private Label label5;
        private RadioButton rdb_erkek;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_kaydet;
        private Button btn_resimEkle;
        private TextBox txt_kilo;
        private ComboBox cmb_alerji1;
        private ComboBox cmb_alerji2;
        private Label label4;
        private Label label6;
        private PictureBox pb_resimUye;
        private RadioButton rdb_kadin;
        private Label label7;
        private Label label8;
        private TextBox txt_yagOrani;
        private Label label9;
        private TextBox txt_suTuketimi;
        private DateTimePicker dtp_dogumGunu;
        private Label label10;
        private CheckBox chk_diyabetMi;
        private Label label11;
        private TextBox txt_kitleEndeksi;
    }
}