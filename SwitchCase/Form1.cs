using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(textBox1.Text);
            label2.Visible = true; //görünürlüğünü aktif edip değeri gösteririz 
            switch (ay)
            {
                case 1:
                    label2.Text = "Ocak";
                    break;
                case 2:
                    label2.Text = "Subat";
                    break;
                case 3:
                    label2.Text = "Mart";
                    break;
                case 4:
                    label2.Text = "Nisan";
                    break;
                case 5:
                    label2.Text = "Mayıs";
                    break;
                case 6:
                    label2.Text = "Haziran";
                    break;
                case 7:
                    label2.Text = "Temmuz";
                    break;
                case 8:
                    label2.Text = "Ağustos";
                    break;
                case 9:
                    label2.Text = "Eylül";
                    break;
                case 10:
                    label2.Text = "Ekim";
                    break;
                case 11:
                    label2.Text = "Kasım";
                    break;
                case 12:
                    label2.Text = "Aralık";
                    break;
                default:
                    label2.Text = "Bu ay tanımlı değil";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string mevsim = textBox2.Text;
            label3.Visible = true;
            switch (mevsim)
            {
                case "YAZ" :
                    label3.Text = "Haziran Temmuz Ağustos";
                    break;
                case "SONBAHAR":
                    label3.Text = "Eylül Ekim Kasım";
                    break;
                case "KIŞ":
                    label3.Text = "Aralık Ocak Şubat";
                    break;
                case "İLKBAHAR":
                    label3.Text = "Mart Nisan Mayıs";
                    break;

                default:
                    label3.Text = "Böyle bir mevsim yok";
                    MessageBox.Show("Mevsim ismini tamamen büyük harfle giriniz");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox3.Text);
            string sembol = textBox4.Text;
            int sayi2 = Convert.ToInt32(textBox5.Text);
            label6.Visible = true;
            switch (sembol)
            {
                case "+":
                    int toplam = sayi1 + sayi2;
                    label6.Text = toplam.ToString();
                    break;
                case "-":
                    int cikar = sayi1 - sayi2;
                    label6.Text = cikar.ToString() ;
                    break;
                case "*":
                    int carp = sayi1 * sayi2;
                    label6.Text = carp.ToString();
                    break;
                case "/":
                    double bol = Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2);
                    label6.Text = bol.ToString();
                    break;
                default:
                    label6.Text = "Hatalı işlem sembolü hesap makinesine göre giriniz:";
                    break;  
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
