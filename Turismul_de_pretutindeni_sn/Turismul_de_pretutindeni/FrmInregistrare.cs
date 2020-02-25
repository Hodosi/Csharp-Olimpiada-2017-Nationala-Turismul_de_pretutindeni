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
    public partial class FrmInregistrare : Form
    {
        public FrmInregistrare()
        {
            InitializeComponent();
        }
        UTILIZATORI util = new UTILIZATORI();
        string cod;
        Random rand = new Random();
        List<string> allImg = new List<string>();
        private void FrmInregistrare_Load(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + @"\Resurse\Banner.png";
            this.pictureBox_banner.Image = Image.FromFile(fn);
            readImg();
            fillCaptcha();
        }

        public void readImg()
        {
            string fn = Application.StartupPath + @"\Resurse\Logare";
            DirectoryInfo dir = new DirectoryInfo(fn);
            FileInfo[] file = dir.GetFiles();

            foreach (FileInfo img in file)
            {
                allImg.Add(img.ToString());
            }
        }

        public void fillCaptcha()
        {
            int rn = rand.Next(0, allImg.Count);
            cod = allImg[rn];
            string fn_captcha = Application.StartupPath + @"\Resurse\Logare\" + cod;
            this.pictureBox_captcha.Image = Image.FromFile(fn_captcha);
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string nume = this.textBox_nume.Text;
            string prenume = this.textBox_prenume.Text;
            string email = this.textBox_email.Text;
            string parola = this.textBox_pass.Text;
            string parola2 = this.textBox_pass2.Text;
            string capctcha = this.textBox_cod.Text;

            if (util.emailExists(email) || email.Length==0)
            {
                this.textBox_email.ResetText();
                MessageBox.Show("Email inlavid!");
            }
            else if (parola.Length < 3)
            {
                this.textBox_pass.ResetText();
                this.textBox_pass2.ResetText();
                MessageBox.Show("Parola prea scurta!");
            }
            else if (parola != parola2)
            {
                this.textBox_pass.ResetText();
                this.textBox_pass2.ResetText();
                MessageBox.Show("Parolele difera");
            }
            else if(cod != (capctcha + ".png"))
            {
                MessageBox.Show(cod);
                MessageBox.Show("Cod captcha diferit!");
                this.textBox_cod.ResetText();
                fillCaptcha();
            }
            else if (util.addUser(nume, prenume, email, parola, 1))
            {
                MessageBox.Show("Intregistrare cu succes");
                this.Hide();
                FrmAutentificare frm = new FrmAutentificare();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Eroare");
            }

        }

        private void button_renunt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAutentificare frm = new FrmAutentificare();
            frm.ShowDialog();
            this.Close();
        }
    }
}

