namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    partial class FormKendiniziKiyaslayin
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
            btn_listele = new Button();
            lst_gunluk = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            dtp_tarih = new DateTimePicker();
            cmb_kiyasFaktoru = new ComboBox();
            cmb_ogun = new ComboBox();
            cmb_kategori = new ComboBox();
            label1 = new Label();
            lst_haftalik = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lst_aylik = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_listele
            // 
            btn_listele.Location = new Point(12, 168);
            btn_listele.Name = "btn_listele";
            btn_listele.Size = new Size(240, 43);
            btn_listele.TabIndex = 0;
            btn_listele.Text = "Listele";
            btn_listele.UseVisualStyleBackColor = true;
            btn_listele.Click += btn_listele_Click;
            // 
            // lst_gunluk
            // 
            lst_gunluk.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lst_gunluk.FullRowSelect = true;
            lst_gunluk.GridLines = true;
            lst_gunluk.Location = new Point(12, 262);
            lst_gunluk.Name = "lst_gunluk";
            lst_gunluk.Size = new Size(240, 176);
            lst_gunluk.TabIndex = 1;
            lst_gunluk.UseCompatibleStateImageBehavior = false;
            lst_gunluk.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Kullanıcı Adı";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Toplam Kalori";
            columnHeader2.Width = 115;
            // 
            // dtp_tarih
            // 
            dtp_tarih.Location = new Point(12, 135);
            dtp_tarih.Name = "dtp_tarih";
            dtp_tarih.Size = new Size(240, 27);
            dtp_tarih.TabIndex = 2;
            // 
            // cmb_kiyasFaktoru
            // 
            cmb_kiyasFaktoru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_kiyasFaktoru.FormattingEnabled = true;
            cmb_kiyasFaktoru.Items.AddRange(new object[] { "Kategoriye Göre", "Öğüne Göre" });
            cmb_kiyasFaktoru.Location = new Point(12, 33);
            cmb_kiyasFaktoru.Name = "cmb_kiyasFaktoru";
            cmb_kiyasFaktoru.Size = new Size(240, 28);
            cmb_kiyasFaktoru.TabIndex = 3;
            cmb_kiyasFaktoru.SelectedIndexChanged += cmb_kiyasFaktoru_SelectedIndexChanged;
            // 
            // cmb_ogun
            // 
            cmb_ogun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ogun.FormattingEnabled = true;
            cmb_ogun.Location = new Point(12, 67);
            cmb_ogun.Name = "cmb_ogun";
            cmb_ogun.Size = new Size(240, 28);
            cmb_ogun.TabIndex = 3;
            // 
            // cmb_kategori
            // 
            cmb_kategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_kategori.FormattingEnabled = true;
            cmb_kategori.Location = new Point(12, 101);
            cmb_kategori.Name = "cmb_kategori";
            cmb_kategori.Size = new Size(240, 28);
            cmb_kategori.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 238);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 4;
            label1.Text = "Günlük Kıyas:";
            // 
            // lst_haftalik
            // 
            lst_haftalik.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            lst_haftalik.FullRowSelect = true;
            lst_haftalik.GridLines = true;
            lst_haftalik.Location = new Point(280, 262);
            lst_haftalik.Name = "lst_haftalik";
            lst_haftalik.Size = new Size(240, 176);
            lst_haftalik.TabIndex = 5;
            lst_haftalik.UseCompatibleStateImageBehavior = false;
            lst_haftalik.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kullanıcı Adı";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Toplam Kalori";
            columnHeader4.Width = 115;
            // 
            // lst_aylik
            // 
            lst_aylik.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            lst_aylik.FullRowSelect = true;
            lst_aylik.GridLines = true;
            lst_aylik.Location = new Point(548, 262);
            lst_aylik.Name = "lst_aylik";
            lst_aylik.Size = new Size(240, 176);
            lst_aylik.TabIndex = 6;
            lst_aylik.UseCompatibleStateImageBehavior = false;
            lst_aylik.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kullanıcı Adı";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Toplam Kalori";
            columnHeader6.Width = 115;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 239);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 4;
            label2.Text = "Haftalık Kıyas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 239);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 4;
            label3.Text = "Aylık Kıyas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 7;
            label4.Text = "Kıyaslama Tercihi:";
            // 
            // FormKendiniziKiyaslayin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lst_aylik);
            Controls.Add(lst_haftalik);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_kategori);
            Controls.Add(cmb_ogun);
            Controls.Add(cmb_kiyasFaktoru);
            Controls.Add(dtp_tarih);
            Controls.Add(lst_gunluk);
            Controls.Add(btn_listele);
            Name = "FormKendiniziKiyaslayin";
            Text = "FormKendiniziKiyaslayin";
            Load += FormKendiniziKiyaslayin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listele;
        private ListView lst_gunluk;
        private DateTimePicker dtp_tarih;
        private ComboBox cmb_kiyasFaktoru;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ComboBox cmb_ogun;
        private ComboBox cmb_kategori;
        private Label label1;
        private ListView lst_haftalik;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lst_aylik;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}