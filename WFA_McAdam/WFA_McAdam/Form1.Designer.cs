namespace WFA_McAdam
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbKing = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.chkBarbeku = new System.Windows.Forms.CheckBox();
            this.chkBuffalo = new System.Windows.Forms.CheckBox();
            this.chkAciSos = new System.Windows.Forms.CheckBox();
            this.chkHardal = new System.Windows.Forms.CheckBox();
            this.chkCheddar = new System.Windows.Forms.CheckBox();
            this.chkRanch = new System.Windows.Forms.CheckBox();
            this.lblaciklama = new System.Windows.Forms.Label();
            this.lbltutar = new System.Windows.Forms.Label();
            this.lblaciklama2 = new System.Windows.Forms.Label();
            this.lbltoplamtutar = new System.Windows.Forms.Label();
            this.lblgeneltoplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu:";
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(73, 185);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(214, 24);
            this.cmbMenu.TabIndex = 2;
            this.cmbMenu.SelectedIndexChanged += new System.EventHandler(this.cmbMenu_SelectedIndexChanged);
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(20, 230);
            this.rbOrta.Margin = new System.Windows.Forms.Padding(4);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(57, 21);
            this.rbOrta.TabIndex = 3;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(111, 230);
            this.rbBuyuk.Margin = new System.Windows.Forms.Padding(4);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(68, 21);
            this.rbBuyuk.TabIndex = 3;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            this.rbBuyuk.CheckedChanged += new System.EventHandler(this.rbBuyuk_CheckedChanged);
            // 
            // rbKing
            // 
            this.rbKing.AutoSize = true;
            this.rbKing.Location = new System.Drawing.Point(201, 230);
            this.rbKing.Margin = new System.Windows.Forms.Padding(4);
            this.rbKing.Name = "rbKing";
            this.rbKing.Size = new System.Drawing.Size(57, 21);
            this.rbKing.TabIndex = 3;
            this.rbKing.TabStop = true;
            this.rbKing.Text = "King";
            this.rbKing.UseVisualStyleBackColor = true;
            this.rbKing.CheckedChanged += new System.EventHandler(this.rbKing_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet:";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(127, 462);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(4);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(160, 22);
            this.nudAdet.TabIndex = 6;
            this.nudAdet.ValueChanged += new System.EventHandler(this.nudAdet_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(295, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(864, 420);
            this.listBox1.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(309, 443);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(184, 43);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Sepete Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.LightGreen;
            this.btnSiparis.FlatAppearance.BorderSize = 0;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparis.Location = new System.Drawing.Point(976, 443);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(184, 43);
            this.btnSiparis.TabIndex = 8;
            this.btnSiparis.Text = "Siparis Ver";
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // chkBarbeku
            // 
            this.chkBarbeku.AutoSize = true;
            this.chkBarbeku.Location = new System.Drawing.Point(183, 375);
            this.chkBarbeku.Margin = new System.Windows.Forms.Padding(4);
            this.chkBarbeku.Name = "chkBarbeku";
            this.chkBarbeku.Size = new System.Drawing.Size(83, 21);
            this.chkBarbeku.TabIndex = 9;
            this.chkBarbeku.Text = "Barbeku";
            this.chkBarbeku.UseVisualStyleBackColor = true;
            this.chkBarbeku.CheckedChanged += new System.EventHandler(this.chkBarbeku_CheckedChanged);
            // 
            // chkBuffalo
            // 
            this.chkBuffalo.AutoSize = true;
            this.chkBuffalo.Location = new System.Drawing.Point(39, 375);
            this.chkBuffalo.Margin = new System.Windows.Forms.Padding(4);
            this.chkBuffalo.Name = "chkBuffalo";
            this.chkBuffalo.Size = new System.Drawing.Size(74, 21);
            this.chkBuffalo.TabIndex = 10;
            this.chkBuffalo.Text = "Buffalo";
            this.chkBuffalo.UseVisualStyleBackColor = true;
            this.chkBuffalo.CheckedChanged += new System.EventHandler(this.chkBuffalo_CheckedChanged);
            // 
            // chkAciSos
            // 
            this.chkAciSos.AutoSize = true;
            this.chkAciSos.Location = new System.Drawing.Point(183, 347);
            this.chkAciSos.Margin = new System.Windows.Forms.Padding(4);
            this.chkAciSos.Name = "chkAciSos";
            this.chkAciSos.Size = new System.Drawing.Size(77, 21);
            this.chkAciSos.TabIndex = 11;
            this.chkAciSos.Text = "Acı Sos";
            this.chkAciSos.UseVisualStyleBackColor = true;
            this.chkAciSos.CheckedChanged += new System.EventHandler(this.chkAciSos_CheckedChanged);
            // 
            // chkHardal
            // 
            this.chkHardal.AutoSize = true;
            this.chkHardal.Location = new System.Drawing.Point(184, 319);
            this.chkHardal.Margin = new System.Windows.Forms.Padding(4);
            this.chkHardal.Name = "chkHardal";
            this.chkHardal.Size = new System.Drawing.Size(72, 21);
            this.chkHardal.TabIndex = 12;
            this.chkHardal.Text = "Hardal";
            this.chkHardal.UseVisualStyleBackColor = true;
            this.chkHardal.CheckedChanged += new System.EventHandler(this.chkHardal_CheckedChanged_1);
            // 
            // chkCheddar
            // 
            this.chkCheddar.AutoSize = true;
            this.chkCheddar.Location = new System.Drawing.Point(39, 347);
            this.chkCheddar.Margin = new System.Windows.Forms.Padding(4);
            this.chkCheddar.Name = "chkCheddar";
            this.chkCheddar.Size = new System.Drawing.Size(84, 21);
            this.chkCheddar.TabIndex = 13;
            this.chkCheddar.Text = "Cheddar";
            this.chkCheddar.UseVisualStyleBackColor = true;
            this.chkCheddar.CheckedChanged += new System.EventHandler(this.chkCheddar_CheckedChanged);
            // 
            // chkRanch
            // 
            this.chkRanch.AutoSize = true;
            this.chkRanch.Location = new System.Drawing.Point(40, 319);
            this.chkRanch.Margin = new System.Windows.Forms.Padding(4);
            this.chkRanch.Name = "chkRanch";
            this.chkRanch.Size = new System.Drawing.Size(71, 21);
            this.chkRanch.TabIndex = 14;
            this.chkRanch.Text = "Ranch";
            this.chkRanch.UseVisualStyleBackColor = true;
            this.chkRanch.CheckedChanged += new System.EventHandler(this.chkRanch_CheckedChanged);
            // 
            // lblaciklama
            // 
            this.lblaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaciklama.Location = new System.Drawing.Point(37, 517);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(154, 28);
            this.lblaciklama.TabIndex = 15;
            this.lblaciklama.Text = "Birim Tutar";
            // 
            // lbltutar
            // 
            this.lbltutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltutar.Location = new System.Drawing.Point(184, 517);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(148, 28);
            this.lbltutar.TabIndex = 15;
            // 
            // lblaciklama2
            // 
            this.lblaciklama2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaciklama2.Location = new System.Drawing.Point(35, 545);
            this.lblaciklama2.Name = "lblaciklama2";
            this.lblaciklama2.Size = new System.Drawing.Size(154, 28);
            this.lblaciklama2.TabIndex = 15;
            this.lblaciklama2.Text = "Toplam tutar:";
            // 
            // lbltoplamtutar
            // 
            this.lbltoplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamtutar.Location = new System.Drawing.Point(184, 545);
            this.lbltoplamtutar.Name = "lbltoplamtutar";
            this.lbltoplamtutar.Size = new System.Drawing.Size(154, 28);
            this.lbltoplamtutar.TabIndex = 15;
            // 
            // lblgeneltoplam
            // 
            this.lblgeneltoplam.AutoSize = true;
            this.lblgeneltoplam.Location = new System.Drawing.Point(718, 505);
            this.lblgeneltoplam.Name = "lblgeneltoplam";
            this.lblgeneltoplam.Size = new System.Drawing.Size(0, 17);
            this.lblgeneltoplam.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 571);
            this.Controls.Add(this.lblgeneltoplam);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.lbltoplamtutar);
            this.Controls.Add(this.lblaciklama2);
            this.Controls.Add(this.lblaciklama);
            this.Controls.Add(this.chkBarbeku);
            this.Controls.Add(this.chkBuffalo);
            this.Controls.Add(this.chkAciSos);
            this.Controls.Add(this.chkHardal);
            this.Controls.Add(this.chkCheddar);
            this.Controls.Add(this.chkRanch);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbKing);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbKing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.CheckBox chkBarbeku;
        private System.Windows.Forms.CheckBox chkBuffalo;
        private System.Windows.Forms.CheckBox chkAciSos;
        private System.Windows.Forms.CheckBox chkHardal;
        private System.Windows.Forms.CheckBox chkCheddar;
        private System.Windows.Forms.CheckBox chkRanch;
        private System.Windows.Forms.Label lblaciklama;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Label lblaciklama2;
        private System.Windows.Forms.Label lbltoplamtutar;
        private System.Windows.Forms.Label lblgeneltoplam;
    }
}

