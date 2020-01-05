using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intro_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal sayi1 = 0, sayi2 = 0, c = 0, d = 0, g = 0, sonuc = 0, bolmeSonucu = 1, carpmaSonucu = 1;
        int virgulIndisi = 0;
        bool esittireBasildi = false; int i = 0, j = 0;
        decimal[] dizi = new decimal[1000];

        string islem = "";

        string deneme = "";

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

            if (txtSayi.Text.Length > 22)
            {
                txtSayi.Text = txtSayi.Text.Remove(txtSayi.Text.Length - 1);
            }
            if (txtSayi.Text == null)
            {
                txtSayi.Text = "0";
            }
            if (txtSayi.Text.IndexOf("0") == 0 && !txtSayi.Text.Contains(".") && txtSayi.Text.Length > 1)
            {
                txtSayi.Text = txtSayi.Text.Remove(0, 1);
            }
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        void IslemSec(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "+")
            {
                if (decimal.TryParse(txtSayi.Text, out sayi1))
                {
                    islem = "+";
                    if (esittireBasildi == true)
                    {
                        sonuc = 0;
                        
                        sonuc += sayi1;
                        esittireBasildi = false;
                    }
                    else
                    {
                        sonuc += sayi1;
                    }
                    sayi1 = sonuc;
                }


                txtSayi.Text = "0";
            }
            else if (btn.Text == "-")
            {
                decimal sonuc = 0;

                islem = "-";
                if (decimal.TryParse(txtSayi.Text, out sayi1))
                {
                    if (esittireBasildi == true)
                    {
                        i = 0;
                        dizi = new decimal[1000];
                        dizi[0] = sayi1;
                        if (dizi[1] != 0)
                        {
                            sonuc = dizi[0] - dizi[i];
                            dizi[0] = sonuc;
                        }


                        esittireBasildi = false;
                        i++;

                    }
                    else
                    {
                        dizi[i] = sayi1;
                        if (dizi[1] != 0)
                        {
                            sonuc = dizi[0] - dizi[i];
                            dizi[0] = sonuc;
                        }
                        sayi1 = dizi[0];

                        i++;

                    }
                }




                txtSayi.Text = "0";
            }
            else if (btn.Text == "*")
            {


                islem = "*";

                if (decimal.TryParse(txtSayi.Text, out sayi1))
                {
                    if (esittireBasildi == true)
                    {
                        carpmaSonucu = 1;
                        carpmaSonucu *= sayi1;
                        esittireBasildi = false;
                    }
                    else
                    {
                        carpmaSonucu *= sayi1;

                    }

                    txtSayi.Text = "0";
                }
                sayi1 = carpmaSonucu;


            }
            else if (btn.Text == "/")
            {
                islem = "/";


                if (decimal.TryParse(txtSayi.Text, out sayi1))
                {
                    if (esittireBasildi == true)
                    {
                        i = 0; j = 0; bolmeSonucu = 1;

                        dizi = new decimal[1000];
                        dizi[i] = sayi1;

                        if (dizi[1] != 0)
                        {

                            bolmeSonucu = dizi[0] / dizi[j];
                            dizi[0] = bolmeSonucu;

                        }
                        else
                        {
                            dizi[0] = sayi1;

                        }
                        txtSayi.Text = "0";



                        i++;
                        j++;
                        esittireBasildi = false;
                    }
                    else
                    {

                        dizi[i] = sayi1;

                        if (dizi[1] != 0)
                        {
                            bolmeSonucu = dizi[0] / dizi[j];
                            dizi[0] = bolmeSonucu;
                        }
                        else
                        {
                            sayi1 = dizi[0];

                        }
                        txtSayi.Text = "0";
                        sayi1 = dizi[0];



                        i++;
                        j++;
                    }
                }


            }
        }

        void Hesapla(decimal s1, decimal s2, string Islem)
        {
            decimal sonuc = 0;

            switch (Islem)
            {
                case "+":
                    sonuc = s1 + s2;
                    break;
                case "-":
                    sonuc = s1 - s2;
                    break;
                case "*":
                    sonuc = s1 * s2;
                    break;
                case "/":
                    if (s2 != 0)
                    {
                        sonuc = s1 / s2;
                    }
                    else
                    {
                        txtSayi.Text = "SYNTAX ERROR.";
                    }

                    break;
                default:
                    break;
            }
            if (islem != "")
            {
                txtSayi.Text = sonuc.ToString();
            }
        }
        void sayiYaz(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text != btnVirgul.Text)
            {
                txtSayi.Text += btn.Text;
            }
            else
            {
                if (!txtSayi.Text.Contains("."))
                {
                    if (txtSayi.Text.IndexOf("0") == 0)
                    {
                        txtSayi.Text += ".".ToString();
                    }
                    else
                    {
                        txtSayi.Text += ".".ToString();
                    }
                }
            }
        }


        void KarakterIslem(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "←")
            {
                if (txtSayi.Text.Length > 0)
                {
                    txtSayi.Text = txtSayi.Text.Substring(0, txtSayi.Text.Length - 1);
                    if (txtSayi.Text.Length == 0)
                    {
                        txtSayi.Text = "0";
                    }

                }
            }
            if (btn.Text == "CE")
            {

                txtSayi.Text = dizi[0].ToString();



                //if (txtSayi.Text.Length > 0)
                //{
                //    txtSayi.Text = txtSayi.Text.Remove(txtSayi.Text.Length - 1, 1);

                //    if (txtSayi.Text.Length == 0)
                //    {
                //        txtSayi.Text = "0";
                //    }
                //}

            }
            if (btn.Text == "C")
            {
                if (txtSayi.Text.Length > 0)
                {
                    txtSayi.Text = "0";
                    sayi1 = 0;
                    sayi2 = 0;
                    bolmeSonucu = 1;
                    sonuc = 0;
                    c = 0;
                    dizi = new decimal[1000];

                }
            }
            if (btn.Name == btnTamsayiPN.Name)
            {
                if (txtSayi.Text.Length > 0)
                {
                    if (decimal.TryParse(txtSayi.Text, out c))
                    {
                        c = c * -1;
                        txtSayi.Text = c.ToString();
                    }


                }
            }
        }
        private void btnEsittir_Click(object sender, EventArgs e)
        {

            esittireBasildi = true;

            sayi2 = Convert.ToDecimal(txtSayi.Text);

            Hesapla(sayi1, sayi2, islem);



            islem = "";

            if (txtSayi.Text.Contains("."))
            {
                virgulIndisi = txtSayi.Text.IndexOf(".");
                if (txtSayi.Text.Length > virgulIndisi && txtSayi.Text.Length > 2)
                {
                    deneme = txtSayi.Text.Substring(virgulIndisi + 1);

                    if (deneme.StartsWith("0") == true)
                    {
                        for (int k = 0; k < deneme.Length; k++)
                        {


                            if (deneme[k].ToString() == "0")
                            {
                                continue;
                            }
                            else
                            {
                                return;
                            }

                        }

                        txtSayi.Text = txtSayi.Text.Substring(0, virgulIndisi);

                    }
                }

            }


        }


    }
}
