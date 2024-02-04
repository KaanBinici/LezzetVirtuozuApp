namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    partial class FormVucutKitleIndeksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVucutKitleIndeksi));
            label1 = new Label();
            txt_boyKitle = new TextBox();
            label2 = new Label();
            txt_kiloKitle = new TextBox();
            btn_hesapla = new Button();
            label3 = new Label();
            txt_vucutEndeksi = new TextBox();
            lbl_durum = new Label();
            
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 40);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Boyunuz:";
            // 
            // txt_boyKitle
            // 
            txt_boyKitle.Location = new Point(152, 37);
            txt_boyKitle.Name = "txt_boyKitle";
            txt_boyKitle.PlaceholderText = "__(cm)";
            txt_boyKitle.Size = new Size(179, 27);
            txt_boyKitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 73);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Kilonuz:";
            // 
            // txt_kiloKitle
            // 
            txt_kiloKitle.Location = new Point(152, 70);
            txt_kiloKitle.Name = "txt_kiloKitle";
            txt_kiloKitle.PlaceholderText = "__(kg)";
            txt_kiloKitle.Size = new Size(179, 27);
            txt_kiloKitle.TabIndex = 1;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Location = new Point(423, 37);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(75, 67);
            btn_hesapla.TabIndex = 2;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 143);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 3;
            label3.Text = "Vücut Kitle Endeksi:";
            // 
            // txt_vucutEndeksi
            // 
            txt_vucutEndeksi.Enabled = false;
            txt_vucutEndeksi.Location = new Point(39, 176);
            txt_vucutEndeksi.Name = "txt_vucutEndeksi";
            txt_vucutEndeksi.Size = new Size(240, 27);
            txt_vucutEndeksi.TabIndex = 4;
            // 
            // lbl_durum
            // 
            lbl_durum.AutoSize = true;
            lbl_durum.Location = new Point(340, 179);
            lbl_durum.Name = "lbl_durum";
            lbl_durum.Size = new Size(50, 20);
            lbl_durum.TabIndex = 5;
            lbl_durum.Text = "label4";
            // 
            
            // 
            // FormVucutKitleIndeksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            
            Controls.Add(lbl_durum);
            Controls.Add(txt_vucutEndeksi);
            Controls.Add(label3);
            Controls.Add(btn_hesapla);
            Controls.Add(txt_kiloKitle);
            Controls.Add(label2);
            Controls.Add(txt_boyKitle);
            Controls.Add(label1);
            Name = "FormVucutKitleIndeksi";
            Text = "FormVucutKitleIndeksi";
            
            
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox txt_boyKitle;
        private Label label2;
        private TextBox txt_kiloKitle;
        private Button btn_hesapla;
        private Label label3;
        private TextBox txt_vucutEndeksi;
        private Label lbl_durum;
        
    }
}