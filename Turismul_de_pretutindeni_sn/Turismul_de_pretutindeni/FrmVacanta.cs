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
    }
}
