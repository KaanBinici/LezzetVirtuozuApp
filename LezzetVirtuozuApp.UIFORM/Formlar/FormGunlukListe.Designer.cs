namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    partial class FormGunlukListe
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
            dtp_tarih = new DateTimePicker();
            lst_sabah = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbl_kaloriToplamSabah = new Label();
            lbl_proteinToplamSabah = new Label();
            lbl_karbonhidratToplamSabah = new Label();
            lbl_yagToplamSabah = new Label();
            lst_ogle = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lbl_kaloriToplamOgle = new Label();
            lbl_proteinToplamOgle = new Label();
            lbl_karbonhidratToplamOgle = new Label();
            lbl_yagToplamOgle = new Label();
            lst_aksam = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            lbl_kaloriToplamAksam = new Label();
            lbl_proteinToplamAksam = new Label();
            lbl_karbonhidratToplamAksam = new Label();
            lbl_yagToplamAksam = new Label();
            lbl_toplamKalori = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // dtp_tarih
            // 
            dtp_tarih.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_tarih.Location = new Point(256, 5);
            dtp_tarih.Name = "dtp_tarih";
            dtp_tarih.Size = new Size(215, 26);
            dtp_tarih.TabIndex = 0;
            dtp_tarih.ValueChanged += dtp_tarih_ValueChanged;
            // 
            // lst_sabah
            // 
            lst_sabah.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lst_sabah.FullRowSelect = true;
            lst_sabah.Location = new Point(12, 39);
            lst_sabah.Name = "lst_sabah";
            lst_sabah.Size = new Size(459, 143);
            lst_sabah.TabIndex = 1;
            lst_sabah.UseCompatibleStateImageBehavior = false;
            lst_sabah.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Yemek Adı";
            columnHeader1.Width = 90;
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
            columnHeader4.Text = "Karbonhidrat (g)";
            columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Yağ (g)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 2;
            label1.Text = "Sabah Öğünü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "Öğle Öğünü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 354);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Akşam Öğünü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(477, 53);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Toplam Kalori:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(477, 85);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 3;
            label5.Text = "Toplam Protein:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(477, 117);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 3;
            label6.Text = "Toplam Karbonhidrat:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(477, 149);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 3;
            label7.Text = "Toplam Yağ:";
            // 
            // lbl_kaloriToplamSabah
            // 
            lbl_kaloriToplamSabah.AutoSize = true;
            lbl_kaloriToplamSabah.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kaloriToplamSabah.Location = new Point(657, 53);
            lbl_kaloriToplamSabah.Name = "lbl_kaloriToplamSabah";
            lbl_kaloriToplamSabah.Size = new Size(0, 20);
            lbl_kaloriToplamSabah.TabIndex = 4;
            // 
            // lbl_proteinToplamSabah
            // 
            lbl_proteinToplamSabah.AutoSize = true;
            lbl_proteinToplamSabah.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_proteinToplamSabah.Location = new Point(657, 85);
            lbl_proteinToplamSabah.Name = "lbl_proteinToplamSabah";
            lbl_proteinToplamSabah.Size = new Size(0, 20);
            lbl_proteinToplamSabah.TabIndex = 4;
            // 
            // lbl_karbonhidratToplamSabah
            // 
            lbl_karbonhidratToplamSabah.AutoSize = true;
            lbl_karbonhidratToplamSabah.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_karbonhidratToplamSabah.Location = new Point(657, 117);
            lbl_karbonhidratToplamSabah.Name = "lbl_karbonhidratToplamSabah";
            lbl_karbonhidratToplamSabah.Size = new Size(0, 20);
            lbl_karbonhidratToplamSabah.TabIndex = 4;
            // 
            // lbl_yagToplamSabah
            // 
            lbl_yagToplamSabah.AutoSize = true;
            lbl_yagToplamSabah.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_yagToplamSabah.Location = new Point(657, 149);
            lbl_yagToplamSabah.Name = "lbl_yagToplamSabah";
            lbl_yagToplamSabah.Size = new Size(0, 20);
            lbl_yagToplamSabah.TabIndex = 4;
            // 
            // lst_ogle
            // 
            lst_ogle.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lst_ogle.FullRowSelect = true;
            lst_ogle.Location = new Point(12, 208);
            lst_ogle.Name = "lst_ogle";
            lst_ogle.Size = new Size(459, 143);
            lst_ogle.TabIndex = 5;
            lst_ogle.UseCompatibleStateImageBehavior = false;
            lst_ogle.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Yemek Adı";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kalori (kcal)";
            columnHeader7.Width = 95;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Protein (g)";
            columnHeader8.Width = 85;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Karbonhidrat (g)";
            columnHeader9.Width = 125;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Yağ (g)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(477, 219);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 3;
            label8.Text = "Toplam Kalori:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(477, 251);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 3;
            label9.Text = "Toplam Protein:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(477, 283);
            label10.Name = "label10";
            label10.Size = new Size(163, 20);
            label10.TabIndex = 3;
            label10.Text = "Toplam Karbonhidrat:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(477, 315);
            label11.Name = "label11";
            label11.Size = new Size(95, 20);
            label11.TabIndex = 3;
            label11.Text = "Toplam Yağ:";
            // 
            // lbl_kaloriToplamOgle
            // 
            lbl_kaloriToplamOgle.AutoSize = true;
            lbl_kaloriToplamOgle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kaloriToplamOgle.Location = new Point(657, 219);
            lbl_kaloriToplamOgle.Name = "lbl_kaloriToplamOgle";
            lbl_kaloriToplamOgle.Size = new Size(0, 20);
            lbl_kaloriToplamOgle.TabIndex = 4;
            // 
            // lbl_proteinToplamOgle
            // 
            lbl_proteinToplamOgle.AutoSize = true;
            lbl_proteinToplamOgle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_proteinToplamOgle.Location = new Point(657, 251);
            lbl_proteinToplamOgle.Name = "lbl_proteinToplamOgle";
            lbl_proteinToplamOgle.Size = new Size(0, 20);
            lbl_proteinToplamOgle.TabIndex = 4;
            // 
            // lbl_karbonhidratToplamOgle
            // 
            lbl_karbonhidratToplamOgle.AutoSize = true;
            lbl_karbonhidratToplamOgle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_karbonhidratToplamOgle.Location = new Point(657, 283);
            lbl_karbonhidratToplamOgle.Name = "lbl_karbonhidratToplamOgle";
            lbl_karbonhidratToplamOgle.Size = new Size(0, 20);
            lbl_karbonhidratToplamOgle.TabIndex = 4;
            // 
            // lbl_yagToplamOgle
            // 
            lbl_yagToplamOgle.AutoSize = true;
            lbl_yagToplamOgle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_yagToplamOgle.Location = new Point(657, 315);
            lbl_yagToplamOgle.Name = "lbl_yagToplamOgle";
            lbl_yagToplamOgle.Size = new Size(0, 20);
            lbl_yagToplamOgle.TabIndex = 4;
            // 
            // lst_aksam
            // 
            lst_aksam.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15 });
            lst_aksam.FullRowSelect = true;
            lst_aksam.Location = new Point(12, 377);
            lst_aksam.Name = "lst_aksam";
            lst_aksam.Size = new Size(459, 143);
            lst_aksam.TabIndex = 6;
            lst_aksam.UseCompatibleStateImageBehavior = false;
            lst_aksam.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Yemek Adı";
            columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Kalori (kcal)";
            columnHeader12.Width = 95;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Protein (g)";
            columnHeader13.Width = 85;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Karbonhidrat (g)";
            columnHeader14.Width = 125;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Yağ (g)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(477, 388);
            label16.Name = "label16";
            label16.Size = new Size(108, 20);
            label16.TabIndex = 3;
            label16.Text = "Toplam Kalori:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(477, 420);
            label17.Name = "label17";
            label17.Size = new Size(119, 20);
            label17.TabIndex = 3;
            label17.Text = "Toplam Protein:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(477, 452);
            label18.Name = "label18";
            label18.Size = new Size(163, 20);
            label18.TabIndex = 3;
            label18.Text = "Toplam Karbonhidrat:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(477, 484);
            label19.Name = "label19";
            label19.Size = new Size(95, 20);
            label19.TabIndex = 3;
            label19.Text = "Toplam Yağ:";
            // 
            // lbl_kaloriToplamAksam
            // 
            lbl_kaloriToplamAksam.AutoSize = true;
            lbl_kaloriToplamAksam.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kaloriToplamAksam.Location = new Point(657, 388);
            lbl_kaloriToplamAksam.Name = "lbl_kaloriToplamAksam";
            lbl_kaloriToplamAksam.Size = new Size(0, 20);
            lbl_kaloriToplamAksam.TabIndex = 4;
            // 
            // lbl_proteinToplamAksam
            // 
            lbl_proteinToplamAksam.AutoSize = true;
            lbl_proteinToplamAksam.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_proteinToplamAksam.Location = new Point(657, 420);
            lbl_proteinToplamAksam.Name = "lbl_proteinToplamAksam";
            lbl_proteinToplamAksam.Size = new Size(0, 20);
            lbl_proteinToplamAksam.TabIndex = 4;
            // 
            // lbl_karbonhidratToplamAksam
            // 
            lbl_karbonhidratToplamAksam.AutoSize = true;
            lbl_karbonhidratToplamAksam.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_karbonhidratToplamAksam.Location = new Point(657, 452);
            lbl_karbonhidratToplamAksam.Name = "lbl_karbonhidratToplamAksam";
            lbl_karbonhidratToplamAksam.Size = new Size(0, 20);
            lbl_karbonhidratToplamAksam.TabIndex = 4;
            // 
            // lbl_yagToplamAksam
            // 
            lbl_yagToplamAksam.AutoSize = true;
            lbl_yagToplamAksam.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_yagToplamAksam.Location = new Point(657, 484);
            lbl_yagToplamAksam.Name = "lbl_yagToplamAksam";
            lbl_yagToplamAksam.Size = new Size(0, 20);
            lbl_yagToplamAksam.TabIndex = 4;
            // 
            // lbl_toplamKalori
            // 
            lbl_toplamKalori.AutoSize = true;
            lbl_toplamKalori.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_toplamKalori.ForeColor = Color.Red;
            lbl_toplamKalori.Location = new Point(657, 11);
            lbl_toplamKalori.Name = "lbl_toplamKalori";
            lbl_toplamKalori.Size = new Size(0, 22);
            lbl_toplamKalori.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(477, 9);
            label12.Name = "label12";
            label12.Size = new Size(163, 20);
            label12.TabIndex = 8;
            label12.Text = "Günlük Toplam Kalori:";
            // 
            // FormGunlukListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 558);
            Controls.Add(label12);
            Controls.Add(lbl_toplamKalori);
            Controls.Add(lst_aksam);
            Controls.Add(lst_ogle);
            Controls.Add(lbl_yagToplamAksam);
            Controls.Add(lbl_yagToplamOgle);
            Controls.Add(lbl_yagToplamSabah);
            Controls.Add(lbl_karbonhidratToplamAksam);
            Controls.Add(lbl_karbonhidratToplamOgle);
            Controls.Add(lbl_karbonhidratToplamSabah);
            Controls.Add(lbl_proteinToplamAksam);
            Controls.Add(lbl_proteinToplamOgle);
            Controls.Add(lbl_proteinToplamSabah);
            Controls.Add(lbl_kaloriToplamAksam);
            Controls.Add(lbl_kaloriToplamOgle);
            Controls.Add(lbl_kaloriToplamSabah);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label17);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label16);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lst_sabah);
            Controls.Add(dtp_tarih);
            Name = "FormGunlukListe";
            Text = "FormGunlukListe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_tarih;
        private ListView lst_sabah;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbl_kaloriToplamSabah;
        private Label lbl_proteinToplamSabah;
        private Label lbl_karbonhidratToplamSabah;
        private Label lbl_yagToplamSabah;
        private ListView lst_ogle;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lbl_kaloriToplamOgle;
        private Label lbl_proteinToplamOgle;
        private Label lbl_karbonhidratToplamOgle;
        private Label lbl_yagToplamOgle;
        private ListView lst_aksam;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label lbl_kaloriToplamAksam;
        private Label lbl_proteinToplamAksam;
        private Label lbl_karbonhidratToplamAksam;
        private Label lbl_yagToplamAksam;
        private Label lbl_toplamKalori;
        private Label label12;
    }
}