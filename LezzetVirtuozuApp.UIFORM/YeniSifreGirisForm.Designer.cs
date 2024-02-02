namespace LezzetVirtuozuApp.UIFORM
{
    partial class YeniSifreGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniSifreGirisForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtsifre = new TextBox();
            pictureBox1 = new PictureBox();
            btnolustur = new Button();
            txtsifreTekrar = new TextBox();
            pbKilitFoto = new PictureBox();
            btnCikis = new Button();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKilitFoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 553);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 55);
            label2.Name = "label2";
            label2.Size = new Size(181, 34);
            label2.TabIndex = 2;
            label2.Text = "Hoş Geldiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(214, 34);
            label1.TabIndex = 1;
            label1.Text = "Lezzet Virtüözü";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(txtsifre);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnolustur);
            panel2.Controls.Add(txtsifreTekrar);
            panel2.Controls.Add(pbKilitFoto);
            panel2.Controls.Add(btnCikis);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(321, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 553);
            panel2.TabIndex = 5;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(166, 236);
            txtsifre.Name = "txtsifre";
            txtsifre.PlaceholderText = "Yeni Şifrenizi Giriniz";
            txtsifre.Size = new Size(376, 27);
            txtsifre.TabIndex = 12;
            txtsifre.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnolustur
            // 
            btnolustur.Cursor = Cursors.Hand;
            btnolustur.FlatStyle = FlatStyle.Flat;
            btnolustur.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnolustur.Location = new Point(166, 374);
            btnolustur.Name = "btnolustur";
            btnolustur.Size = new Size(94, 29);
            btnolustur.TabIndex = 10;
            btnolustur.Text = "Oluştur";
            btnolustur.UseVisualStyleBackColor = true;
            btnolustur.Click += btnOnay_Click;
            // 
            // txtsifreTekrar
            // 
            txtsifreTekrar.Location = new Point(166, 307);
            txtsifreTekrar.Name = "txtsifreTekrar";
            txtsifreTekrar.PlaceholderText = "Yeni Şifrenizi Tekrar Giriniz";
            txtsifreTekrar.Size = new Size(376, 27);
            txtsifreTekrar.TabIndex = 9;
            txtsifreTekrar.UseSystemPasswordChar = true;
            // 
            // pbKilitFoto
            // 
            pbKilitFoto.Image = (Image)resources.GetObject("pbKilitFoto.Image");
            pbKilitFoto.Location = new Point(91, 305);
            pbKilitFoto.Name = "pbKilitFoto";
            pbKilitFoto.Size = new Size(35, 29);
            pbKilitFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKilitFoto.TabIndex = 8;
            pbKilitFoto.TabStop = false;
            pbKilitFoto.Click += pbKilitFoto_Click;
            // 
            // btnCikis
            // 
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.OrangeRed;
            btnCikis.Location = new Point(621, 0);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(40, 40);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(571, 527);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 4;
            label4.Text = "Kaan Binici";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(531, 510);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 3;
            label3.Text = "Develop By";
            // 
            // YeniSifreGirisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YeniSifreGirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKilitFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCikis;
        private Label label4;
        private Panel panel4;
        private TextBox txtsifreTekrar;
        private PictureBox pbKilitFoto;
        private Panel panel3;
        private Button btnolustur;
        private Button button1;
        private TextBox txtsifre;
        private PictureBox pictureBox1;
    }
}
