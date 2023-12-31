namespace DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int Oyuncu1Toplam, Oyuncu2Toplam = 0;
        int a, b;
        private void zarAt()
        {
            a = rastgele.Next(1, 7);
            b = rastgele.Next(1, 7);

            if (a == 1)
            {
                pictureBox1.ImageLocation = "images\\1.jpg";
            }

            if (a == 2)
            {
                pictureBox1.ImageLocation = "images\\2.jpg";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "images\\3.jpg";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "images\\4.jpg";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "images\\5.jpg";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "images\\6.jpg";
            }
            if (b == 1)
            {
                pictureBox2.ImageLocation = "images\\1.jpg";
            }

            if (b == 2)
            {
                pictureBox2.ImageLocation = "images\\2.jpg";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "images\\3.jpg";
            }

            if (b == 4)
            {
                pictureBox2.ImageLocation = "images\\4.jpg";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "images\\5.jpg";
            }

            if (b == 6)
            {
                pictureBox2.ImageLocation = "images\\6.jpg";
            }


        }

        private void oyuncuSkor()
        {
            if (Oyuncu1Toplam >= Convert.ToInt32(txtf_puan.Text))
            {
                label6.Visible = true;
                label6.Text = "Oyuncu 1 Kazandý...";
                button_tekrar.Visible = true;
                button_oyuncu2.Enabled = false;
            }
            if (Oyuncu2Toplam >= Convert.ToInt32(txtf_puan.Text))
            {
                label6.Visible = true;
                label6.Text = "Oyuncu 2 Kazandý...";
                button_tekrar.Visible = true;
                button_oyuncu1.Enabled = false; //button2 yazýyordu button oyuncu 1 olarak deðiþtirdik.
            }

        }

        private void button_oyuncu1_Click(object sender, EventArgs e)
        {
            txtf_puan.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button_oyuncu1.Enabled = false;
            button_oyuncu2.Enabled = true;
            zarAt();
            Oyuncu1Toplam = Oyuncu1Toplam + a + b;
            label_oyuncu1.Text = Oyuncu1Toplam.ToString();
            oyuncuSkor();
        }

        private void button_oyuncu2_Click(object sender, EventArgs e)
        {
            txtf_puan.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button_oyuncu2.Enabled = false; // button oyuncu 1 idi biz onu 2 olarak deðiþtirdik.
            button_oyuncu1.Enabled = true;
            zarAt();
            Oyuncu2Toplam = Oyuncu2Toplam + a + b;
            label_oyuncu2.Text = Oyuncu2Toplam.ToString();
            oyuncuSkor();
        }

        private void button_tekrar_Click(object sender, EventArgs e)
        {
            txtf_puan.Enabled = true;
            txtf_puan.Text = "100";
            button_oyuncu1.Enabled = true;
            button_oyuncu2.Enabled = true;
            label3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            Oyuncu1Toplam = 0;
            Oyuncu2Toplam = 0;
            label_oyuncu1.Text = "0";
            label_oyuncu2.Text = "0";
            button_tekrar.Visible = false;
        }
    }


}