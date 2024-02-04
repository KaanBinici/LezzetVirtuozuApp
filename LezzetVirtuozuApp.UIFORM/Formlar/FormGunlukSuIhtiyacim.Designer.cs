namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    partial class FormGunlukSuIhtiyacim
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
            pb_resimSu = new PictureBox();
            label1 = new Label();
            txt_kilo = new TextBox();
            label2 = new Label();
            txt_suIhtiyaci = new TextBox();
            btn_hesapla = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_resimSu).BeginInit();
            SuspendLayout();
            // 
            // pb_resimSu
            // 
            pb_resimSu.Location = new Point(326, 26);
            pb_resimSu.Name = "pb_resimSu";
            pb_resimSu.Size = new Size(448, 412);
            pb_resimSu.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_resimSu.TabIndex = 0;
            pb_resimSu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 88);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Kilonuz:";
            // 
            // txt_kilo
            // 
            txt_kilo.Enabled = false;
            txt_kilo.Location = new Point(51, 122);
            txt_kilo.Name = "txt_kilo";
            txt_kilo.PlaceholderText = "__(kg)";
            txt_kilo.Size = new Size(210, 27);
            txt_kilo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 271);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 1;
            label2.Text = "Günlük Su İhtiyacınız (lt):";
            // 
            // txt_suIhtiyaci
            // 
            txt_suIhtiyaci.Enabled = false;
            txt_suIhtiyaci.Location = new Point(51, 305);
            txt_suIhtiyaci.Name = "txt_suIhtiyaci";
            txt_suIhtiyaci.Size = new Size(210, 27);
            txt_suIhtiyaci.TabIndex = 2;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Location = new Point(51, 182);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(75, 56);
            btn_hesapla.TabIndex = 3;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // FormGunlukSuIhtiyacim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_hesapla);
            Controls.Add(txt_suIhtiyaci);
            Controls.Add(label2);
            Controls.Add(txt_kilo);
            Controls.Add(label1);
            Controls.Add(pb_resimSu);
            Name = "FormGunlukSuIhtiyacim";
            Text = "FormGunlukSuIhtiyacim";
            ((System.ComponentModel.ISupportInitialize)pb_resimSu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_resimSu;
        private Label label1;
        private TextBox txt_kilo;
        private Label label2;
        private TextBox txt_suIhtiyaci;
        private Button btn_hesapla;
    }
}