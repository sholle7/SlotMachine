using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Runtime.InteropServices;

namespace MaturskiProjekat
{
    public partial class Form4 : Form
    {
        PictureBox[] pictureSimboli = new PictureBox[8];
        PictureBox[] pictureKarte = new PictureBox[2];
        int i = 0, brkrt = 0,br = 0, CrvCr,A, B, C,karta;
        public int pozadina;
        Random r = new Random();
        Random r1 = new Random();
        int br0 = 0, br1 = 0, br2 = 0, br3 = 0, br4 = 0, br5 = 0, br6 = 0, br7 = 0;
        WindowsMediaPlayer ZvukZavrti = new WindowsMediaPlayer();
        WindowsMediaPlayer ZvukDobitak = new WindowsMediaPlayer();
        WindowsMediaPlayer ZvukDodavanjaNovca = new WindowsMediaPlayer();
        Image BelaPozadina = Image.FromFile("Materijal\\BelaPozadina.png");
        Point PritisniPoint;
        public Form4()
        {
            InitializeComponent();
        }
        protected override void OnLocationChanged(EventArgs e)
        {
            DoubleBuffered = true;
            //  SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            if (this.Location.X + 1000 >= Screen.PrimaryScreen.WorkingArea.Width)
            {
                this.SetBounds(Screen.PrimaryScreen.WorkingArea.Width - this.Width, this.Location.Y, 1000, 750);
            }
            if (this.Location.X <= Screen.PrimaryScreen.WorkingArea.X)
            {
                this.SetBounds(0, this.Location.Y, 1000, 750);
            }
            if (this.Location.Y + this.Height >= Screen.PrimaryScreen.WorkingArea.Height)
            {
                this.SetBounds(this.Location.X, Screen.PrimaryScreen.WorkingArea.Height - this.Height, 1000, 750);
            }
            if (this.Location.Y <= Screen.PrimaryScreen.WorkingArea.Y)
            {
                this.SetBounds(this.Location.X, 0, 1000, 750);
            }
        }
        public void ProveriNovac()
        {
            string s = labelUlog.Text, s1 = labelStanje.Text;
            int ulog = Convert.ToInt32(s), stanje = Convert.ToInt32(s1);
            if (stanje >= 10 && stanje < 20) labelUlog.Text = Convert.ToString(10);
            if (stanje >= 20 && stanje < 50) labelUlog.Text = Convert.ToString(20);
            if (stanje >= 50 && stanje < 100) labelUlog.Text = Convert.ToString(50);
            if (stanje >= 100 && stanje < 200) labelUlog.Text = Convert.ToString(100);
            if (stanje >= 200 && stanje < 500) labelUlog.Text = Convert.ToString(200);
            if (stanje >= 500 && stanje < 1000) labelUlog.Text = Convert.ToString(500);
            if (stanje >= 1000 && stanje < 2000) labelUlog.Text = Convert.ToString(1000);
            if (stanje >= 2000 && stanje < 5000) labelUlog.Text = Convert.ToString(2000);
            if (stanje >= 5000) labelUlog.Text = Convert.ToString(5000);
        }
        public void PromeniPozadinu()
        {

            pozadina++;
            if (pozadina == 4) pozadina = 1;
            if (pozadina == 1)
            {
                BackgroundImage = Image.FromFile("Materijal\\Pozadina1.jpg");
                StreamWriter sw = new StreamWriter("Materijal\\Pozadina.txt");
                sw.WriteLine("1");
                sw.Close();
            }
            if (pozadina == 2)
            {
                BackgroundImage = Image.FromFile("Materijal\\Pozadina2.jpg");
                StreamWriter sw = new StreamWriter("Materijal\\Pozadina.txt");
                sw.WriteLine("2");
                sw.Close();
            }
            if (pozadina == 3)
            {
                BackgroundImage = Image.FromFile("Materijal\\Pozadina3.jpg");
                StreamWriter sw = new StreamWriter("Materijal\\Pozadina.txt");
                sw.WriteLine("3");
                sw.Close();
            }

        }
        private void button100RSD_Click(object sender, EventArgs e)
        {

            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 100 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 100);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void button200RSD_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 200 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 200);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void button500RSD_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 500 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 500);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void button1000RSD_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 1000 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 1000);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void button2000RSD_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 2000 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 2000);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void button5000RSD_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 5000 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 5000);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            labelUlog.Text = "10";
            timerUlog.Enabled = true;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            ProveriNovac();
            timerUlog.Enabled = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

            string s = labelUlog.Text;
            if (s == "20") labelUlog.Text = "10";
            if (s == "50") labelUlog.Text = "20";
            if (s == "100") labelUlog.Text = "50";
            if (s == "200") labelUlog.Text = "100";
            if (s == "500") labelUlog.Text = "200";
            if (s == "1000") labelUlog.Text = "500";
            if (s == "2000") labelUlog.Text = "1000";
            if (s == "5000") labelUlog.Text = "2000";
            timerUlog.Enabled = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {


            string s = labelUlog.Text;
            if (s == "10") labelUlog.Text = "20";
            if (s == "20") labelUlog.Text = "50";
            if (s == "50") labelUlog.Text = "100";
            if (s == "100") labelUlog.Text = "200";
            if (s == "200") labelUlog.Text = "500";
            if (s == "500") labelUlog.Text = "1000";
            if (s == "1000") labelUlog.Text = "2000";
            if (s == "2000") labelUlog.Text = "5000";
            timerUlog.Enabled = true;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.StartPosition = FormStartPosition.CenterScreen;
            forma2.ShowDialog();
        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelStanje.Text = "0";
            labelDobitak.Text = "0";
            labelUlog.Text = "10";
            labelNedovoljnoNovca.Visible = true;
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void dobitneKombinacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 forma5 = new Form5();
            forma5.StartPosition = FormStartPosition.CenterScreen;
            forma5.ShowDialog();
        }

        private void timerZavrti_Tick(object sender, EventArgs e)
        {
            int a = r.Next(0, 8), b = r.Next(0, 8), c = r.Next(0, 8);
            if (buttonZavrti.Enabled == true) buttonZavrti.Enabled = false;
            if (br == 15)
            {
                pictureRucicaGore.Visible = true;
                pictureRucicaGore.Enabled = false;
                pictureRucicaDole.Visible = false;
            }
            if (br == 85)
            {              
                br = 0;
                timerDobitak.Enabled = true;
                pictureRucicaGore.Enabled = false;
                timerZavrti.Enabled = false;              
            }
            else
            {
                i++;
                if (br < 50)
                {

                    if (i == 1)
                    {
                        pictureBoxSlot1Gore.Image = BelaPozadina;
                        pictureBoxSlot1.Image = pictureSimboli[a].Image;
                    }
                    if (i == 2)
                    {
                        pictureBoxSlot1.Image = BelaPozadina;
                        pictureBoxSlot1Dole.Image = pictureSimboli[a].Image;
                    }
                    if (i == 3)
                    {
                        pictureBoxSlot1Dole.Image = BelaPozadina;
                        pictureBoxSlot1Gore.Image = pictureSimboli[a].Image;
                    }

                }
                if (br == 49)
                {
                    pictureBoxSlot1Dole.Image = BelaPozadina;
                    pictureBoxSlot1Gore.Image = BelaPozadina;
                    pictureBoxSlot1.Image = pictureSimboli[a].Image;
                    A = a;
                }

                if (br < 70)
                {
                    if (i == 1)
                    {
                        pictureBoxSlot2Gore.Image = BelaPozadina;
                        pictureBoxSlot2.Image = pictureSimboli[b].Image;
                    }
                    if (i == 2)
                    {
                        pictureBoxSlot2.Image = BelaPozadina;
                        pictureBoxSlot2Dole.Image = pictureSimboli[b].Image;
                    }
                    if (i == 3)
                    {
                        pictureBoxSlot2Dole.Image = BelaPozadina;
                        pictureBoxSlot2Gore.Image = pictureSimboli[b].Image;
                    }
                }

                if (br == 69)
                {
                    pictureBoxSlot2Dole.Image = BelaPozadina;
                    pictureBoxSlot2Gore.Image = BelaPozadina;
                    pictureBoxSlot2.Image = pictureSimboli[b].Image;
                    B = b;
                }
                if (br < 85)
                {
                    if (i == 1)
                    {
                        pictureBoxSlot3Gore.Image = BelaPozadina;
                        pictureBoxSlot3.Image = pictureSimboli[c].Image;
                    }
                    if (i == 2)
                    {
                        pictureBoxSlot3.Image = BelaPozadina;
                        pictureBoxSlot3Dole.Image = pictureSimboli[c].Image;
                    }
                    if (i == 3)
                    {
                        pictureBoxSlot3Dole.Image = BelaPozadina;
                        pictureBoxSlot3Gore.Image = pictureSimboli[c].Image;
                    }
                }
                if (br == 84)
                {
                    pictureBoxSlot3Dole.Image = BelaPozadina;
                    pictureBoxSlot3Gore.Image = BelaPozadina;
                    pictureBoxSlot3.Image = pictureSimboli[c].Image;
                    C = c;
                }             
                if (i == 3) i = 0;
                br++;
            }
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.StartPosition = FormStartPosition.CenterScreen;
            forma2.ShowDialog();
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void timerDobitak_Tick(object sender, EventArgs e)
        {

            for (int i = 1; i <= 1; i++)
            {
                if (A == 0) br0++;
                if (A == 1) br1++;
                if (A == 2) br2++;
                if (A == 3) br3++;
                if (A == 4) br4++;
                if (A == 5) br5++;
                if (A == 6) br6++;
                if (A == 7) br7++;

                if (B == 0) br0++;
                if (B == 1) br1++;
                if (B == 2) br2++;
                if (B == 3) br3++;
                if (B == 4) br4++;
                if (B == 5) br5++;
                if (B == 6) br6++;
                if (B == 7) br7++;

                if (C == 0) br0++;
                if (C == 1) br1++;
                if (C == 2) br2++;
                if (C == 3) br3++;
                if (C == 4) br4++;
                if (C == 5) br5++;
                if (C == 6) br6++;
                if (C == 7) br7++;         
            }
            if (br0 < 2 && br1 < 2 && br2 < 2 && br3 < 2 && br4 < 2 && br5 < 2 && br6 < 2 && br7 < 2) labelDobitak.Text = "0";
            if (br0 == 2 || br1 == 2 || br2 == 2 || br3 == 2 || br4 == 2 || br5 == 2 || br6 == 2 || br7 == 2)
            {                            
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text));
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                
            }

            if (br0 == 3 || br1 == 3 || br2 == 3 || br3 == 3 || br4 == 3 || br5 == 3 || br6 == 3 || br7 == 3)
            {
                if (br0 == 3)
                {
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text) * 100);
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                    MessageBox.Show("OSVOJILI STE MEGA JACKPOT!", "Bravo");

                }             
                if (br1 == 3)
                {
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text) * 20);
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                    MessageBox.Show("OSVOJILI STE JACKPOT!", "Bravo");

                }
                if (br2 == 3)
                {
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text) * 25);
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                    MessageBox.Show("OSVOJILI STE JACKPOT!", "Bravo");

                }
                if (br3 == 3)
                {
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text) * 5);
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                    MessageBox.Show("OSVOJILI STE JACKPOT!", "Bravo");

                }
                if (br4 == 3)
                {
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text) * 50);
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                    MessageBox.Show("OSVOJILI STE JACKPOT!", "Bravo");

                }
                if (br5 == 3)
                {
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text) * 15);
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                    MessageBox.Show("OSVOJILI STE JACKPOT!", "Bravo");

                }
                if (br6 == 3)
                {
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text) * 10);
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                    MessageBox.Show("OSVOJILI STE JACKPOT!", "Bravo");

                }
                if(br7==3)
                {
                    labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelUlog.Text) * 75);
                    ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                    ZvukDobitak.controls.play();
                    MessageBox.Show("OSVOJILI STE JACKPOT!", "Bravo");
                }
            }
                     
           
            br0 = br1 = br2 = br3 = br4 = br5 = br6 = br7=0 ;
            if (Convert.ToInt32(labelDobitak.Text) != 0)
            {
                buttonDuploNista.Enabled = true;
                buttonPreskoci.Enabled = true;
                buttonZavrti.Enabled = false;
                pictureRucicaGore.Enabled = false;
                buttonMax.Enabled = false;
                buttonMin.Enabled = false;
                buttonPlus.Enabled = false;
                buttonMinus.Enabled = false;
            }
            else
            {
                buttonDuploNista.Enabled = false;
                buttonPreskoci.Enabled = false;
                buttonZavrti.Enabled = true;
                pictureRucicaGore.Enabled = true;
            }
            for (int i = 1; i <= 9; i++)
            {
                string s = labelUlog.Text, s1 = labelStanje.Text,s2=labelDobitak.Text;
                int ulog = Convert.ToInt32(s), stanje = Convert.ToInt32(s1),dobitak=Convert.ToInt32(s2);
                if (stanje + dobitak >= ulog) labelUlog.Text = s;
                else
                {
                    switch (ulog)
                    {

                        case 10:
                            {
                                labelNedovoljnoNovca.Visible = true;
                                buttonZavrti.Enabled = false;
                                pictureRucicaGore.Enabled = false;
                                break;
                            }
                        case 20:
                            labelUlog.Text = "10"; break;
                        case 50:
                            labelUlog.Text = "20"; break;
                        case 100:
                            labelUlog.Text = "50"; break;
                        case 200:
                            labelUlog.Text = "100"; break;
                        case 500:
                            labelUlog.Text = "200"; break;
                        case 1000:
                            labelUlog.Text = "500"; break;
                        case 2000:
                            labelUlog.Text = "1000"; break;
                        case 5000:
                            labelUlog.Text = "2000"; break;
                    }
                }
            }
            if (labelDobitak.Text == "0")
            {
                button10RSD.Enabled = true;
                button20RSD.Enabled = true;
                button50RSD.Enabled = true;
                button100RSD.Enabled = true;
                button200RSD.Enabled = true;
                button500RSD.Enabled = true;
                button1000RSD.Enabled = true;
                button2000RSD.Enabled = true;
                button5000RSD.Enabled = true;

                buttonMin.Enabled = true;
                buttonMinus.Enabled = true;
                buttonPlus.Enabled = true;
                buttonMax.Enabled = true;
                timerUlog.Enabled = true;
            }
            timerDobitak.Enabled = false;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - PritisniPoint.X;
                this.Top += e.Y - PritisniPoint.Y;
            }
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            PritisniPoint = new Point(e.X, e.Y);
        }

        private void timerVreme_Tick(object sender, EventArgs e)
        {
            labelVreme.Text = Convert.ToString(DateTime.Now);
        }

        private void simboliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 forma6 = new Form6();
            forma6.StartPosition = FormStartPosition.CenterScreen;
            forma6.ShowDialog();
        }

        private void buttonDuploNista_Click(object sender, EventArgs e)
        {
            pictureKarta.Image = picturePozadinaKarte.Image;
            buttonCrvena.Visible = true;
            buttonCrvena.Enabled = true;
            buttonCrna.Visible = true;
            buttonCrna.Enabled = true;
            pictureKarta.Visible = true;
            pictureKarta.Enabled = true;
            buttonPreskoci.Enabled = false;
        }

        private void buttonPreskoci_Click(object sender, EventArgs e)
        {
            labelStanje.Text = Convert.ToString(Convert.ToInt32(labelStanje.Text) + Convert.ToInt32(labelDobitak.Text));
            timerUlog.Enabled = true;
            buttonDuploNista.Enabled = false;
            buttonZavrti.Enabled = true;
            buttonMax.Enabled = true;
            buttonMin.Enabled = true;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;

            button10RSD.Enabled = true;
            button20RSD.Enabled = true;
            button50RSD.Enabled = true;
            button100RSD.Enabled = true;
            button200RSD.Enabled = true;
            button500RSD.Enabled = true;
            button1000RSD.Enabled = true;
            button2000RSD.Enabled = true;
            button5000RSD.Enabled = true;

            buttonPreskoci.Enabled = false;
        }

        private void buttonCrvena_Click(object sender, EventArgs e)
        {
            CrvCr = 1;
            timer2x0.Enabled = true;
            buttonCrna.Enabled = false;
            buttonCrvena.Enabled = false;
            buttonDuploNista.Enabled = false;
        }

        private void buttonCrna_Click(object sender, EventArgs e)
        {
            CrvCr = 0;
            timer2x0.Enabled = true;
            buttonCrvena.Enabled = false;
            buttonCrna.Enabled = false;
            buttonDuploNista.Enabled = false;
        }

        private void timer2x0_Tick(object sender, EventArgs e)
        {
            int a = r1.Next(0, 2);
            if (brkrt == 30)
            {
                timer2x0Dobitak.Enabled = true;
                brkrt = 0;
                timer2x0.Enabled = false;
            }
            else
            {
                pictureKarta.Image = pictureKarte[a].Image;
                if (brkrt == 29) karta = a;
                brkrt++;
            }
        }

        private void timer2x0Dobitak_Tick(object sender, EventArgs e)
        {
            if (karta == CrvCr)
            {
                ZvukDobitak.URL = "Materijal\\SlotMasinaDobitak1.mp3";
                ZvukDobitak.controls.play();
                labelDobitak.Text = Convert.ToString(Convert.ToInt32(labelDobitak.Text) * 2);
                labelStanje.Text = Convert.ToString(Convert.ToInt32(labelStanje.Text) + Convert.ToInt32(labelDobitak.Text));
                timerUlog.Enabled = true;
                buttonZavrti.Enabled = true;
                buttonDuploNista.Enabled = false;
                buttonPreskoci.Enabled = false;

                button10RSD.Enabled = true;
                button20RSD.Enabled = true;
                button50RSD.Enabled = true;
                button100RSD.Enabled = true;
                button200RSD.Enabled = true;
                button500RSD.Enabled = true;
                button1000RSD.Enabled = true;
                button2000RSD.Enabled = true;
                button5000RSD.Enabled = true;

                timer2x0Dobitak.Enabled = false;
            }
            else
            {
                labelDobitak.Text = "0";
                timerUlog.Enabled = true;
                buttonZavrti.Enabled = true;
                buttonDuploNista.Enabled = false;
                buttonPreskoci.Enabled = false;
                for (int i = 1; i <= 9; i++)
                {
                    string s = labelUlog.Text, s1 = labelStanje.Text, s2 = labelDobitak.Text;
                    int ulog = Convert.ToInt32(s), stanje = Convert.ToInt32(s1), dobitak = Convert.ToInt32(s2);
                    if (stanje + dobitak >= ulog) labelUlog.Text = s;
                    else
                    {
                        switch (ulog)
                        {

                            case 10:
                                {
                                    labelNedovoljnoNovca.Visible = true;
                                    buttonZavrti.Enabled = false;
                                    pictureRucicaGore.Enabled = false;
                                    break;
                                }
                            case 20:
                                labelUlog.Text = "10"; break;
                            case 50:
                                labelUlog.Text = "20"; break;
                            case 100:
                                labelUlog.Text = "50"; break;
                            case 200:
                                labelUlog.Text = "100"; break;
                            case 500:
                                labelUlog.Text = "200"; break;
                            case 1000:
                                labelUlog.Text = "500"; break;
                            case 2000:
                                labelUlog.Text = "1000"; break;
                            case 5000:
                                labelUlog.Text = "2000"; break;
                        }
                    }
                }

                button10RSD.Enabled = true;
                button20RSD.Enabled = true;
                button50RSD.Enabled = true;
                button100RSD.Enabled = true;
                button200RSD.Enabled = true;
                button500RSD.Enabled = true;
                button1000RSD.Enabled = true;
                button2000RSD.Enabled = true;
                button5000RSD.Enabled = true;

                timer2x0Dobitak.Enabled = false;
            }
        }

        private void pictureRucicaDole_Click(object sender, EventArgs e)
        {

        }

        private void pravilaIgreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 forma7 = new Form7();
            forma7.StartPosition = FormStartPosition.CenterScreen;
            forma7.ShowDialog();
        }

        private void fajlToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            fajlToolStripMenuItem.ShowDropDown();
        }

        private void fajlToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void opcijeToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            opcijeToolStripMenuItem.ShowDropDown();
        }

        private void opcijeToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            
          
        }

        private void button50RSD_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 50 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 50);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void button20RSD_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 20 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 20);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void pictureRucicaGore_Click(object sender, EventArgs e)
        {

            button10RSD.Enabled = false;
            button20RSD.Enabled = false;
            button50RSD.Enabled = false;
            button100RSD.Enabled = false;
            button200RSD.Enabled = false;
            button500RSD.Enabled = false;
            button1000RSD.Enabled = false;
            button2000RSD.Enabled = false;
            button5000RSD.Enabled = false;

            buttonMin.Enabled = false;
            buttonMinus.Enabled = false;
            buttonPlus.Enabled = false;
            buttonMax.Enabled = false;

            buttonDuploNista.Enabled = false;
            buttonCrvena.Visible = false;
            buttonCrna.Visible = false;
            pictureKarta.Visible = false;
            ZvukZavrti.URL = "Materijal\\SlotMasinaZavrtiZvuk.mp3";
            ZvukZavrti.controls.play();
            ZvukDobitak.controls.stop();
            int stanje = Convert.ToInt32(labelStanje.Text), ulog = Convert.ToInt32(labelUlog.Text);
            labelStanje.Text = Convert.ToString(stanje - ulog);
            labelDobitak.Text = "0";
            pictureRucicaGore.Visible = false;
            pictureRucicaDole.Visible = true;
            timerZavrti.Enabled = true;
            buttonZavrti.Enabled = false;
            pictureRucicaGore.Enabled = false;
        }

        private void button10RSD_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(labelStanje.Text);
            if (s + 10 > 20000) MessageBox.Show("Prekoračen limit unosa!", "Greska");
            else
            {
                labelStanje.Text = Convert.ToString(s + 10);
                ZvukDodavanjaNovca.URL = "Materijal\\DodavanjeNovcaZvuk.mp3";
                ZvukDodavanjaNovca.controls.play();
            }
            timerUlog.Enabled = true;
        }

        private void timerUlog_Tick(object sender, EventArgs e)
        {
            string s = labelUlog.Text, s1 = labelStanje.Text;
            int ulog = Convert.ToInt32(s), stanje = Convert.ToInt32(s1);
            if (stanje < 10)
            {
                labelNedovoljnoNovca.Visible = true;
                buttonMax.Enabled = false;
                buttonPlus.Enabled = false;
                buttonMinus.Enabled = false;
                buttonMin.Enabled = false;
                pictureRucicaGore.Enabled = false;
            }
            else
            {
                labelNedovoljnoNovca.Visible = false;
                buttonMax.Enabled = true;
                buttonPlus.Enabled = true;
                buttonMinus.Enabled = true;
                buttonMin.Enabled = true;
                pictureRucicaGore.Enabled = true;
            }
            if (Convert.ToInt32(s1) < Convert.ToInt32(s))
            {
                buttonZavrti.Enabled = false;
                pictureRucicaGore.Enabled = false;
            }
            else
            {
                buttonZavrti.Enabled = true;
                pictureRucicaGore.Enabled = true;
            }
            if (stanje < ulog)
            {
                buttonZavrti.Enabled = false;
                pictureRucicaGore.Enabled = false;
                buttonPlus.Enabled = false;
                buttonMax.Enabled = false;
            }
            else if (stanje == ulog)
            {
                buttonZavrti.Enabled = true;
                pictureRucicaGore.Enabled = true;
                buttonPlus.Enabled = false;
                buttonMax.Enabled = false;
            }
            else
            {
                buttonZavrti.Enabled = true;
                pictureRucicaGore.Enabled = true;
                buttonPlus.Enabled = true;
                buttonMax.Enabled = true;
            }
            switch (ulog)
            {
                case 10:
                    if (stanje < 20)
                    {
                        buttonPlus.Enabled = false;
                        buttonMax.Enabled = false;
                    }
                    else
                    {
                        buttonPlus.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                    break;
                case 20:
                    if (stanje < 50)
                    {
                        buttonPlus.Enabled = false;
                        buttonMax.Enabled = false;
                    }
                    else
                    {
                        buttonPlus.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                    break;
                case 50:
                    if (stanje < 100)
                    {
                        buttonPlus.Enabled = false;
                        buttonMax.Enabled = false;
                    }
                    else
                    {
                        buttonPlus.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                    break;
                case 100:
                    if (stanje < 200)
                    {
                        buttonPlus.Enabled = false;
                        buttonMax.Enabled = false;
                    }
                    else
                    {
                        buttonPlus.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                    break;
                case 200:
                    if (stanje < 500)
                    {
                        buttonPlus.Enabled = false;
                        buttonMax.Enabled = false;
                    }
                    else
                    {
                        buttonPlus.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                    break;
                case 500:
                    if (stanje < 1000)
                    {
                        buttonPlus.Enabled = false;
                        buttonMax.Enabled = false;
                    }
                    else
                    {
                        buttonPlus.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                    break;
                case 1000:
                    if (stanje < 2000)
                    {
                        buttonPlus.Enabled = false;
                        buttonMax.Enabled = false;
                    }
                    else
                    {
                        buttonPlus.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                    break;
                case 2000:
                    if (stanje < 5000)
                    {
                        buttonPlus.Enabled = false;
                        buttonMax.Enabled = false;
                    }
                    else
                    {
                        buttonPlus.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                    break;
            }
            if (s == "10")
            {
                buttonMinus.Enabled = false;
                buttonMin.Enabled = false;
            }
            if (s == "5000")
            {
                buttonPlus.Enabled = false;
                buttonMax.Enabled = false;
            }
            timerUlog.Enabled = false;
        }

        private void promenaMasineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            forma1.StartPosition = FormStartPosition.CenterScreen;
            forma1.Show();
            this.Hide();
        }

        private void buttonZavrti_Click(object sender, EventArgs e)
        {
            button10RSD.Enabled = false;
            button20RSD.Enabled = false;
            button50RSD.Enabled = false;
            button100RSD.Enabled = false;
            button200RSD.Enabled = false;
            button500RSD.Enabled = false;
            button1000RSD.Enabled = false;
            button2000RSD.Enabled = false;
            button5000RSD.Enabled = false;

            buttonMin.Enabled = false;
            buttonMinus.Enabled = false;
            buttonPlus.Enabled = false;
            buttonMax.Enabled = false;

            buttonDuploNista.Enabled = false;
            buttonCrvena.Visible = false;
            buttonCrna.Visible = false;
            pictureKarta.Visible = false;
            ZvukZavrti.URL = "Materijal\\SlotMasinaZavrtiZvuk.mp3";
            ZvukZavrti.controls.play();
            ZvukDobitak.controls.stop();
            int stanje = Convert.ToInt32(labelStanje.Text), ulog = Convert.ToInt32(labelUlog.Text);
            labelStanje.Text = Convert.ToString(stanje - ulog);
            labelDobitak.Text = "0";
            timerZavrti.Enabled = true;
            buttonZavrti.Enabled = false;        
        }

       
        private void Form4_Load(object sender, EventArgs e)
        {
            labelVreme.Text = Convert.ToString(DateTime.Now);
            StreamReader sr = new StreamReader("Materijal\\Pozadina.txt");
               string s;
               while ((s = sr.ReadLine()) != null)
               {
                   if (s == "1")
                   {
                    pozadina = 1;
                    this.BackgroundImage = Image.FromFile("Materijal\\Pozadina1.jpg");
                   }
                   if (s == "2")
                   {
                    pozadina = 2;
                    this.BackgroundImage = Image.FromFile("Materijal\\Pozadina2.jpg");
                   }
                   if (s == "3")
                   {
                    pozadina = 3;
                    this.BackgroundImage = Image.FromFile("Materijal\\Pozadina3.jpg");
                   }
               }
               sr.Close();

            pictureSimboli[0] = pictureBox1;
            pictureSimboli[1] = pictureBox2;
            pictureSimboli[2] = pictureBox3;
            pictureSimboli[3] = pictureBox4;
            pictureSimboli[4] = pictureBox5;
            pictureSimboli[5] = pictureBox6;
            pictureSimboli[6] = pictureBox7;
            pictureSimboli[7] = pictureBox8;
            pictureKarte[0] = pictureCrnaKarta;
            pictureKarte[1] = pictureCrvenaKarta;
        }    
       

        private void buttonIzlaz_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.StartPosition = FormStartPosition.CenterScreen;
            forma2.ShowDialog();
        }

        private void promenaPozadineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromeniPozadinu();
        }
    }
}
