namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    partial class FormYiyecekveIcecek
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
            label2 = new Label();
            txt_arama = new TextBox();
            pb_yiyecekResmi = new PictureBox();
            lst_liste = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            cmb_kategori = new ComboBox();
            cmb_ogun = new ComboBox();
            chk_gluten = new CheckBox();
            chk_laktoz = new CheckBox();
            btn_yiyecekAra = new Button();
            label3 = new Label();
            btn_oguneEkle = new Button();
            btn_listele = new Button();
            lst_urunListesi = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            btn_guncelle = new Button();
            btn_tumListe = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_yiyecekResmi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 4;
            label2.Text = "Öğün:";
            // 
            // txt_arama
            // 
            txt_arama.Location = new Point(12, 193);
            txt_arama.Name = "txt_arama";
            txt_arama.Size = new Size(317, 27);
            txt_arama.TabIndex = 12;
            // 
            // pb_yiyecekResmi
            // 
            pb_yiyecekResmi.Location = new Point(345, 12);
            pb_yiyecekResmi.Name = "pb_yiyecekResmi";
            pb_yiyecekResmi.Size = new Size(234, 266);
            pb_yiyecekResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_yiyecekResmi.TabIndex = 14;
            pb_yiyecekResmi.TabStop = false;
            // 
            // lst_liste
            // 
            lst_liste.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lst_liste.FullRowSelect = true;
            lst_liste.GridLines = true;
            lst_liste.Location = new Point(12, 296);
            lst_liste.Name = "lst_liste";
            lst_liste.Size = new Size(864, 236);
            lst_liste.TabIndex = 15;
            lst_liste.UseCompatibleStateImageBehavior = false;
            lst_liste.View = View.Details;
            lst_liste.MouseClick += lst_liste_MouseClick;
            lst_liste.MouseDoubleClick += lst_liste_MouseDoubleClick;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ürün";
            columnHeader7.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Yiyecek Adı";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kalori (kcal)";
            columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Protein (g)";
            columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Yağ (g)";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Karbonhidrat (g)";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Porsiyon";
            columnHeader6.Width = 120;
            // 
            // cmb_kategori
            // 
            cmb_kategori.FormattingEnabled = true;
            cmb_kategori.Location = new Point(112, 31);
            cmb_kategori.Name = "cmb_kategori";
            cmb_kategori.Size = new Size(217, 28);
            cmb_kategori.TabIndex = 16;
            // 
            // cmb_ogun
            // 
            cmb_ogun.FormattingEnabled = true;
            cmb_ogun.Location = new Point(112, 69);
            cmb_ogun.Name = "cmb_ogun";
            cmb_ogun.Size = new Size(217, 28);
            cmb_ogun.TabIndex = 16;
            cmb_ogun.SelectedValueChanged += cmb_ogun_SelectedValueChanged;
            // 
            // chk_gluten
            // 
            chk_gluten.AutoSize = true;
            chk_gluten.Location = new Point(12, 114);
            chk_gluten.Name = "chk_gluten";
            chk_gluten.Size = new Size(91, 24);
            chk_gluten.TabIndex = 17;
            chk_gluten.Text = "Glutensiz";
            chk_gluten.UseVisualStyleBackColor = true;
            // 
            // chk_laktoz
            // 
            chk_laktoz.AutoSize = true;
            chk_laktoz.Location = new Point(135, 114);
            chk_laktoz.Name = "chk_laktoz";
            chk_laktoz.Size = new Size(95, 24);
            chk_laktoz.TabIndex = 17;
            chk_laktoz.Text = "Laktozsuz";
            chk_laktoz.UseVisualStyleBackColor = true;
            // 
            // btn_yiyecekAra
            // 
            btn_yiyecekAra.BackColor = SystemColors.ControlLightLight;
            btn_yiyecekAra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_yiyecekAra.Location = new Point(12, 225);
            btn_yiyecekAra.Name = "btn_yiyecekAra";
            btn_yiyecekAra.Size = new Size(91, 53);
            btn_yiyecekAra.TabIndex = 18;
            btn_yiyecekAra.Text = "Yiyeceği Ara";
            btn_yiyecekAra.UseVisualStyleBackColor = false;
            btn_yiyecekAra.Click += btn_yiyecekAra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 4;
            label3.Text = "Aramak istediğiniz yiyeceği girin";
            // 
            // btn_oguneEkle
            // 
            btn_oguneEkle.Location = new Point(238, 226);
            btn_oguneEkle.Name = "btn_oguneEkle";
            btn_oguneEkle.Size = new Size(91, 53);
            btn_oguneEkle.TabIndex = 19;
            btn_oguneEkle.Text = "Öğün Ekle";
            btn_oguneEkle.UseVisualStyleBackColor = true;
            btn_oguneEkle.Click += btn_oguneEkle_Click;
            // 
            // btn_listele
            // 
            btn_listele.Location = new Point(242, 103);
            btn_listele.Name = "btn_listele";
            btn_listele.Size = new Size(87, 35);
            btn_listele.TabIndex = 20;
            btn_listele.Text = "Listele";
            btn_listele.UseVisualStyleBackColor = true;
            btn_listele.Click += btn_listele_Click;
            // 
            // lst_urunListesi
            // 
            lst_urunListesi.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11 });
            lst_urunListesi.FullRowSelect = true;
            lst_urunListesi.GridLines = true;
            lst_urunListesi.Location = new Point(599, 12);
            lst_urunListesi.Name = "lst_urunListesi";
            lst_urunListesi.Size = new Size(277, 266);
            lst_urunListesi.TabIndex = 21;
            lst_urunListesi.UseCompatibleStateImageBehavior = false;
            lst_urunListesi.View = View.Details;
            lst_urunListesi.MouseDoubleClick += lst_urunListesi_MouseDoubleClick;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Yemek Adı";
            columnHeader10.Width = 135;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Kalori (kcal)";
            columnHeader11.Width = 135;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(125, 225);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(91, 53);
            btn_guncelle.TabIndex = 19;
            btn_guncelle.Text = "Öğün Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_tumListe
            // 
            btn_tumListe.Location = new Point(242, 149);
            btn_tumListe.Name = "btn_tumListe";
            btn_tumListe.Size = new Size(87, 35);
            btn_tumListe.TabIndex = 20;
            btn_tumListe.Text = "Tüm Liste";
            btn_tumListe.UseVisualStyleBackColor = true;
            btn_tumListe.Click += btn_tumListe_Click;
            // 
            // FormYiyecekveIcecek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 551);
            Controls.Add(lst_urunListesi);
            Controls.Add(btn_tumListe);
            Controls.Add(btn_listele);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_oguneEkle);
            Controls.Add(btn_yiyecekAra);
            Controls.Add(chk_laktoz);
            Controls.Add(chk_gluten);
            Controls.Add(cmb_ogun);
            Controls.Add(cmb_kategori);
            Controls.Add(lst_liste);
            Controls.Add(pb_yiyecekResmi);
            Controls.Add(txt_arama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormYiyecekveIcecek";
            Text = "FormYiyecekveIcecek";
            Load += FormYiyecekveIcecek_Load;
            ((System.ComponentModel.ISupportInitialize)pb_yiyecekResmi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_tumListe;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox txt_arama;
        private PictureBox pb_yiyecekResmi;
        private ListView lst_liste;
        private ComboBox cmb_kategori;
        private ComboBox cmb_ogun;
        private CheckBox chk_gluten;
        private CheckBox chk_laktoz;
        private Button btn_yiyecekAra;
        private Label label3;
        private Button btn_oguneEkle;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btn_listele;
        private ColumnHeader columnHeader7;
        private ListView lst_urunListesi;
        private Button btn_guncelle;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}