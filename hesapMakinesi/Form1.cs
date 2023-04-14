namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double sayi1 = 0;
        double sayi2 = 0;
        string islem = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sifir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void btn_cift_sifir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void btn_bir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn_iki_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn_uc_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn_dort_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn_bes_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void btn_alti_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn_yedi_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn_sekiz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn_dokuz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn_nokta_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                textBox1.Text += ".";
            }
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi1 = double.Parse(textBox1.Text);
                islem = "+";
                textBox1.Text = "";
            }
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi1 = double.Parse(textBox1.Text);
                islem = "-";
                textBox1.Text = "";
            }
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi1 = double.Parse(textBox1.Text);
                islem = "*";
                textBox1.Text = "";
            }
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi1 = double.Parse(textBox1.Text);
                islem = "/";
                textBox1.Text = "";
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi1 = double.Parse(textBox1.Text);
                islem = "%";
                textBox1.Text = "";
            }
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi2 = double.Parse(textBox1.Text);

                double sonuc = 0;

                switch (islem)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                        sonuc = sayi1 / sayi2;
                        break;
                    case "%":
                        sonuc = sayi1 % sayi2;
                        break;
                }

                textBox1.Text = sonuc.ToString();
            }
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}