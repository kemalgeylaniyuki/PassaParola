using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:

                        if (textBox1.Text == "akdeniz")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor= Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 2:

                        if (textBox1.Text == "bursa")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 3:

                        if (textBox1.Text == "cuma")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 4:

                        if (textBox1.Text == "diyarbakır")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 5:

                        if (textBox1.Text == "eski")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 6:

                        if (textBox1.Text == "ferman")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 7:

                        if (textBox1.Text == "güneş")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 8:

                        if (textBox1.Text == "halı")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 9:

                        if (textBox1.Text == "ısparta")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 10:

                        if (textBox1.Text == "içel")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 11:

                        if (textBox1.Text == "jandarma")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 12:

                        if (textBox1.Text == "kayısı")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 13:

                        if (textBox1.Text == "lale")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 14:

                        if (textBox1.Text == "mart")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 15:

                        if (textBox1.Text == "ney")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 16:

                        if (textBox1.Text == "ozan")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 17:

                        if (textBox1.Text == "pırasa")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 18:

                        if (textBox1.Text == "ramazan")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 19:

                        if (textBox1.Text == "snake")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 20:

                        if (textBox1.Text == "tarkan")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 21:

                        if (textBox1.Text == "umut")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 22:

                        if (textBox1.Text == "van")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 23:

                        if (textBox1.Text == "yıldırım")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 24:

                        if (textBox1.Text == "zeytin")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                        default:
                        MessageBox.Show("Tekrar Deneyiniz");
                        break;





                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
            soruno++;
            this.Text = soruno.ToString(); // this.text  = forumun sol üst köşesi  // soruno dan gelen değeri ata

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi? ";
                button22.BackColor = Color.Yellow;
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşillği ile ünlü marmara ilimiz? ";
                button23.BackColor = Color.Yellow;
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü? ";
                button24.BackColor = Color.Yellow;
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz? ";
                button7.BackColor = Color.Yellow;
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı? ";
                button1.BackColor = Color.Yellow;
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Padişah emirlerinin yazılı hali? ";
                button2.BackColor = Color.Yellow;
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı? ";
                button3.BackColor = Color.Yellow;
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencinin kötü karne getirince bakıştığı nesne? ";
                button4.BackColor = Color.Yellow;
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "Gülü ile ünlü ilimiz? ";
                button5.BackColor = Color.Yellow;
            }

            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi? ";
                button6.BackColor = Color.Yellow;
            }

            if (soruno == 11)
            {
                richTextBox1.Text = "Askeeri bir topluluk? ";
                button8.BackColor = Color.Yellow;
            }

            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi? ";
                button10.BackColor = Color.Yellow;
            }

            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl baharda düzenlenen meşhur çiçek festivali? ";
                button9.BackColor = Color.Yellow;
            }

            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı? ";
                button11.BackColor = Color.Yellow;
            }

            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli müzik aleti? ";
                button12.BackColor = Color.Yellow;
            }

            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi? ";
                button13.BackColor = Color.Yellow;
            }

            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzelerle yapılan yemek? ";
                button14.BackColor = Color.Yellow;
            }

            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayın sultanı? ";
                button15.BackColor = Color.Yellow;
            }

            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan? ";
                button16.BackColor = Color.Yellow;
            }

            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı? ";
                button17.BackColor = Color.Yellow;
            }

            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı? ";
                button18.BackColor = Color.Yellow;
            }

            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz? ";
                button19.BackColor = Color.Yellow;
            }

            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı? ";
                button20.BackColor = Color.Yellow;
            }

            if (soruno == 24)
            {
                richTextBox1.Text = "Yağı en pahalı olan kahvaltılık besin? ";
                button21.BackColor = Color.Yellow;
            }

           









        }
    }
}
