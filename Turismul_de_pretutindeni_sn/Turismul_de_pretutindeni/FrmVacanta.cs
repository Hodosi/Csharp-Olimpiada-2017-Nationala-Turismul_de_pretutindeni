using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Turismul_de_pretutindeni
{
    public partial class FrmVacanta : Form
    {
        public FrmVacanta()
        {
            InitializeComponent();
        }

        Graphics graphics;
        VACANTA vacant = new VACANTA();
        List<string> allImg = new List<string>();
        int locIndex = 0;
        string nmImg;
        private void FrmVacanta_Load(object sender, EventArgs e)
        {
            readImg();
            loadLoc();
            string fnPrev = Application.StartupPath + @"\Resurse\Prev.png";
            string fnNext = Application.StartupPath + @"\Resurse\Next.png";
            this.pictureBox_prev.Image = Image.FromFile(fnPrev);
            this.pictureBox_next.Image = Image.FromFile(fnNext);
        }
        public void readImg()
        {
            string fn = Application.StartupPath + @"\Resurse\ImaginiLoc";
            DirectoryInfo dir = new DirectoryInfo(fn);
            FileInfo[] file = dir.GetFiles();

            foreach (FileInfo img in file)
            {
                allImg.Add(img.ToString());
            }
        }

        public void loadLoc()
        {
            string fnLoc = Application.StartupPath + @"\Resurse\ImaginiLoc\" + allImg[locIndex];
            this.pictureBox_loc.Image = Image.FromFile(fnLoc);

            nmImg = allImg[locIndex].Substring(0, (allImg[locIndex].Length - 4));
            this.label_nume.Text = nmImg;
            this.label_pret.Text = vacant.getPret(nmImg)+" lei";
            this.label_locuri.Text = vacant.getLocuri(nmImg) + " locuri";
            this.label_descriere.Text = vacant.getDescriere(nmImg);
        }

        private void pictureBox_next_Click(object sender, EventArgs e)
        {
            locIndex++;
            if (locIndex == 7)
            {
                locIndex = 0;
            }
            loadLoc();
        }

        private void pictureBox_prev_Click(object sender, EventArgs e)
        {
            locIndex--;
            if (locIndex == -1)
            {
                locIndex = 6;
            }
            loadLoc();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadLoc();
            locIndex++;
            if (locIndex == 7)
            {
                locIndex = 0;
            }
        }

        private void button_Rezerva_Click(object sender, EventArgs e)
        {
            FrmRezerva frm = new FrmRezerva();
            frm.label_nume.Text = nmImg;
            frm.ShowDialog();
        }

        private void button_Poster_Click(object sender, EventArgs e)
        {
            string fnLoc = Application.StartupPath + @"\Resurse\ImaginiLoc\" + allImg[locIndex];
            //----------------------------------------------
            Image image = (Image)Image.FromFile(fnLoc);
            graphics = Graphics.FromImage(image);
            //-----------------------------------------------
            Font font = new Font("Arial", 30, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            int lnLoc = nmImg.Length;
            string litera;
            for(int i = 0; i < lnLoc; i++)
            {
                litera = nmImg.Substring(i, 1);
                graphics.DrawString(litera, font, blackBrush, 20 * (i + 1), 30);
            }
            //-------------------------------------------------
            saveFileDialog1.Filter = "PNG (*.png)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                image.Save(fn);

            }
        }

        private void adaugaAdminNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminNou frm = new FrmAdminNou();
            frm.ShowDialog();
            this.Close();
        }

        private void adaugaVacanteNoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdaugaVacante frm = new FrmAdaugaVacante();
            frm.ShowDialog();
            this.Show();
        }

        private void vacanteleMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLOBAL.vacantaGlobal = nmImg;
            this.Hide();
            FrmVacanteleMele frm = new FrmVacanteleMele();
            frm.ShowDialog();
            this.Show();
        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAutentificare frm = new FrmAutentificare();
            frm.ShowDialog();
            this.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
