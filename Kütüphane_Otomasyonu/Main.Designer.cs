namespace Kütüphane_Otomasyonu
{
    partial class Main
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
            btnKitapEkle = new Button();
            txtKitapId = new TextBox();
            lblKitapId = new Label();
            label1 = new Label();
            txtKitapAdı = new TextBox();
            label2 = new Label();
            txtKitapYazarı = new TextBox();
            label3 = new Label();
            txtSayfa = new TextBox();
            btnKitapListele = new Button();
            dgwKitaplar = new DataGridView();
            btnOrderYazar = new Button();
            btnKitapFiltre = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwKitaplar).BeginInit();
            SuspendLayout();
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(65, 266);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(131, 49);
            btnKitapEkle.TabIndex = 0;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // txtKitapId
            // 
            txtKitapId.Location = new Point(172, 44);
            txtKitapId.Name = "txtKitapId";
            txtKitapId.Size = new Size(100, 23);
            txtKitapId.TabIndex = 1;
            // 
            // lblKitapId
            // 
            lblKitapId.AutoSize = true;
            lblKitapId.Location = new Point(65, 52);
            lblKitapId.Name = "lblKitapId";
            lblKitapId.Size = new Size(88, 15);
            lblKitapId.TabIndex = 2;
            lblKitapId.Text = "Kitap Numarası";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 91);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Kitap Adı";
            // 
            // txtKitapAdı
            // 
            txtKitapAdı.Location = new Point(172, 83);
            txtKitapAdı.Name = "txtKitapAdı";
            txtKitapAdı.Size = new Size(100, 23);
            txtKitapAdı.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 129);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Kitap Yazarı";
            // 
            // txtKitapYazarı
            // 
            txtKitapYazarı.Location = new Point(172, 121);
            txtKitapYazarı.Name = "txtKitapYazarı";
            txtKitapYazarı.Size = new Size(100, 23);
            txtKitapYazarı.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 167);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Sayfa Sayısı";
            // 
            // txtSayfa
            // 
            txtSayfa.Location = new Point(172, 159);
            txtSayfa.Name = "txtSayfa";
            txtSayfa.Size = new Size(100, 23);
            txtSayfa.TabIndex = 7;
            // 
            // btnKitapListele
            // 
            btnKitapListele.Location = new Point(229, 266);
            btnKitapListele.Name = "btnKitapListele";
            btnKitapListele.Size = new Size(131, 49);
            btnKitapListele.TabIndex = 9;
            btnKitapListele.Text = "Kitap Listele";
            btnKitapListele.UseVisualStyleBackColor = true;
            btnKitapListele.Click += btnKitapListele_Click;
            // 
            // dgwKitaplar
            // 
            dgwKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwKitaplar.Location = new Point(303, 12);
            dgwKitaplar.Name = "dgwKitaplar";
            dgwKitaplar.RowTemplate.Height = 25;
            dgwKitaplar.Size = new Size(455, 188);
            dgwKitaplar.TabIndex = 10;
            // 
            // btnOrderYazar
            // 
            btnOrderYazar.Location = new Point(397, 266);
            btnOrderYazar.Name = "btnOrderYazar";
            btnOrderYazar.Size = new Size(131, 49);
            btnOrderYazar.TabIndex = 11;
            btnOrderYazar.Text = "Yazara Göre Listele";
            btnOrderYazar.UseVisualStyleBackColor = true;
            btnOrderYazar.Click += btnOrderYazar_Click;
            // 
            // btnKitapFiltre
            // 
            btnKitapFiltre.Location = new Point(572, 266);
            btnKitapFiltre.Name = "btnKitapFiltre";
            btnKitapFiltre.Size = new Size(131, 49);
            btnKitapFiltre.TabIndex = 12;
            btnKitapFiltre.Text = "Kitaba Göre Listele";
            btnKitapFiltre.UseVisualStyleBackColor = true;
            btnKitapFiltre.Click += btnKitapFiltre_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKitapFiltre);
            Controls.Add(btnOrderYazar);
            Controls.Add(dgwKitaplar);
            Controls.Add(btnKitapListele);
            Controls.Add(label3);
            Controls.Add(txtSayfa);
            Controls.Add(label2);
            Controls.Add(txtKitapYazarı);
            Controls.Add(label1);
            Controls.Add(txtKitapAdı);
            Controls.Add(lblKitapId);
            Controls.Add(txtKitapId);
            Controls.Add(btnKitapEkle);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dgwKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKitapEkle;
        private TextBox txtKitapId;
        private Label lblKitapId;
        private Label label1;
        private TextBox txtKitapAdı;
        private Label label2;
        private TextBox txtKitapYazarı;
        private Label label3;
        private TextBox txtSayfa;
        private Button btnKitapListele;
        private DataGridView dgwKitaplar;
        private Button btnOrderYazar;
        private Button btnKitapFiltre;
    }
}