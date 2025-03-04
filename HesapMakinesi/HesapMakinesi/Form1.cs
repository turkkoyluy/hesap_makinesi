using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        
        private char _islem;
        bool _ekranTemizlenmisMi;
        private double _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }


        private void number1_Click_1(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi=false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmisMi)
            {
                label1.Text = "";
                _ekranTemizlenmisMi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
           label1.Text = "0";
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "-";

        }

        private void buttontoplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenmisMi = true;
            _ilkSayi=Convert.ToDouble(label1.Text);   
        }

        private void buttonçarpma_Click(object sender, EventArgs e)
        {
            _islem = 'X';
            _ekranTemizlenmisMi = true;
            _ilkSayi = Convert.ToDouble (label1.Text);
        }

        private void buttonbölme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenmisMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void buttonyüzde_Click(object sender, EventArgs e)
        {
            _islem = '%';
            _ekranTemizlenmisMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void buttonvirgül_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += ",";
        }

        private void buttonçıkarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenmisMi = true;
            _ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void buttoneşit_Click(object sender, EventArgs e)
        {
            double ikinciSayi=Convert.ToDouble(label1.Text);
            double sonuc=0;
            switch (_islem) {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '%':
                    sonuc = _ilkSayi * ikinciSayi / 100;
                    break;
                case 'X':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
            }
            label1.Text = Convert.ToString(sonuc);


        }
    }

}
