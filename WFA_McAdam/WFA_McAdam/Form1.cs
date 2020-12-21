using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] menuler = { "Whopper", "Whopper Jr.", "Big King", "King Chicken", "Texas Smokehouse", "SteakHouse", "Klasik Gurme Tavuk" };
        double[] fiyatlar = { 26.95, 24.95, 24.95, 17.50, 31.50, 32.50, 26.95};

        double minisos = 1;
        double ortaboy = 0;
        double buyuk = 2.50;
        double king = 3.75;

        double tutar;
        int hata = 0;
        string hatalar;
        string sandvic, secim;
        string[] yansos;
        int adet = 1;

        void guncelle()
        {
            lblgeneltoplam.Visible = false;
            hata = 0;

                int x = cmbMenu.SelectedIndex;
                for (int i = 0; i < fiyatlar.Length; i++)
                {

                    if (i == x)
                    {

                        tutar = fiyatlar[i];
                        lbltutar.Text = tutar.ToString();

                    }
                }
                if (rbBuyuk.Checked)
                {
                    tutar = tutar + buyuk;
                    lbltutar.Text = tutar.ToString();
                secim = "büyük seçim";
                }
                else if (rbKing.Checked)
                {
                    tutar = tutar + king;
                    lbltutar.Text = tutar.ToString();
                secim = "King seçim";
                }

                int kacyansos = 0;

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox && ((CheckBox)ctrl).Checked == true)
                    {
                        kacyansos++;
                    }
                }
                yansos = new string[kacyansos];
                int sayac = -1;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox ch = (CheckBox)ctrl;
                        if (ch.Checked == true)
                        {
                            sayac++;
                            yansos[sayac] = ch.Text;
                            tutar = tutar + 1;
                            lbltutar.Text = tutar.ToString();
                        }
                    }
                }

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is NumericUpDown)
                    {
                        NumericUpDown nud = (NumericUpDown)ctrl;

                        adet = Convert.ToInt16(nud.Value);
                        Double toplamtutar = adet * tutar;
                        lbltoplamtutar.Text = toplamtutar.ToString();
                    }
                } 

        }
        double geneltoplam = 0;
        void ekle()
        {
            lblgeneltoplam.Visible = false;
            sandvic = cmbMenu.Text;
            if (sandvic.Length < 3)
            {
                hata++;
                hatalar = hatalar + " \n Lütfen boş bırakmayın.";
            }
            if (hata > 0)
            {
                MessageBox.Show(hatalar);
                hata = 0;
            }
            else
            {
                if (rbBuyuk.Checked)
                {
                    tutar = tutar + buyuk;
                    lbltutar.Text = tutar.ToString();
                    secim = "büyük seçim";
                }
                else if (rbKing.Checked)
                {
                    tutar = tutar + king;
                    lbltutar.Text = tutar.ToString();
                    secim = "King seçim";
                }
                else
                {
                    rbOrta.Checked = true;
                    secim = "orta boy seçim";
                }
                int kacyansos = 0;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox && ((CheckBox)ctrl).Checked == true)
                    {
                        kacyansos++;
                    }
                }

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox && ((CheckBox)ctrl).Checked == true)
                    {
                        ((CheckBox)ctrl).Checked = false;
                    }
                }

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is RadioButton && ((RadioButton)ctrl).Checked == true)
                    {
                        ((RadioButton)ctrl).Checked = false;
                    }
                }

               
                listBox1.Items.Add(adet + " ADET: " + sandvic + " - " + secim + " " + kacyansos + " tane yan sos");
                double oncekitoplam = Convert.ToDouble(lbltoplamtutar.Text);
                geneltoplam = geneltoplam + oncekitoplam;
                cmbMenu.Text = "";

                lblgeneltoplam.Text = geneltoplam.ToString();
                tutar = 0;
                lbltutar.Text = tutar.ToString();
                lbltoplamtutar.Text = "0";
                nudAdet.Value = 1;
            }
        }
       
        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            guncelle();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblgeneltoplam.Visible = false;
            for (int i = 0; i<menuler.Length;i++)
            {
                cmbMenu.Items.Add(string.Format("{0} > {1} TL",menuler[i],fiyatlar[i]));
            }

            nudAdet.Value = 1;
        }

        private void chkHardal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBuyuk_CheckedChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void rbKing_CheckedChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void chkRanch_CheckedChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void chkHardal_CheckedChanged_1(object sender, EventArgs e)
        {
            guncelle();
        }

        private void chkCheddar_CheckedChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void chkAciSos_CheckedChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void chkBuffalo_CheckedChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void chkBarbeku_CheckedChanged(object sender, EventArgs e)
        {
            guncelle();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {

            lblgeneltoplam.Visible = true;
            lblgeneltoplam.Text = "Toplam ödemeniz gereken tutar: " + lblgeneltoplam.Text;

                DialogResult result = MessageBox.Show(""+lblgeneltoplam.Text+" TL ödemek istediğinzden emin misinz", "Burger King",
                 MessageBoxButtons.OKCancel);
                switch (result)
                {
   
                }
            
        }
  
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekle();
  

        }
    }
}
