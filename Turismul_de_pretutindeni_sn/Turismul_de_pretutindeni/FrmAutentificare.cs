using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Turismul_de_pretutindeni
{
    public partial class FrmAutentificare : Form
    {
        public FrmAutentificare()
        {
            InitializeComponent();
        }
        CONNECTION conn = new CONNECTION();
        UTILIZATORI util = new UTILIZATORI();
        private void FrmAutentificare_Load(object sender, EventArgs e)
        {
            this.textBox_email.Text = Turismul_de_pretutindeni.Properties.Settings.Default.email;
            stergere_Vacante();
            initializare_Vacante();
        }
        void initializare_Vacante()
        {
            string sir, numeImg, nume, despre;
            float pret;
            int nrlocuri;
            string[] siruri;
            char split = '|';
            string fnText = Application.StartupPath + @"/Resurse/Vacante.txt";
            string fnImg = Application.StartupPath + @"/Resurse/Imagini/";
            StreamReader readerText = new StreamReader(fnText);
            while ((sir = readerText.ReadLine()) != null)
            {
                siruri = sir.Split(split);
                //-------------------------------
                nume = siruri[0];
                despre = siruri[1];
                pret = float.Parse(siruri[2]);
                nrlocuri = int.Parse(siruri[3]);
                if (File.Exists(fnImg + siruri[0] + ".png"))
                {
                    numeImg = siruri[0] + ".png";
                }
                else if (File.Exists(fnImg + siruri[0] + ".jpg"))
                {
                    numeImg = siruri[0] + ".jpg";
                }
                else if (File.Exists(fnImg + siruri[0] + ".jpeg"))
                {
                    numeImg = siruri[0] + ".jpeg";
                }
                else if (File.Exists(fnImg + siruri[0] + ".gif"))
                {
                    numeImg = siruri[0] + ".gif";
                }
                else if (File.Exists(fnImg + siruri[0] + ".bmp"))
                {
                    numeImg = siruri[0] + ".bmp";
                }
                else
                {
                    numeImg = "implicit.jpg";
                }

                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO Vacante(NumeVacanta,Descriere,CaleFisier,Pret,NrLocuri) VALUES(@nm,@dp,@cal,@pret,@nrl)";
                command.Connection = conn.GetConnection();

                //@nm,@dp,@cal,@pret,@nrl
                command.Parameters.Add("nm", SqlDbType.VarChar).Value = nume;
                command.Parameters.Add("dp", SqlDbType.VarChar).Value = despre;
                command.Parameters.Add("cal", SqlDbType.VarChar).Value = numeImg;
                command.Parameters.Add("pret", SqlDbType.Float).Value = pret;
                command.Parameters.Add("nrl", SqlDbType.Int).Value = nrlocuri;

                conn.openConnection();
                command.ExecuteNonQuery();
                conn.closeConnection();
            }
        }

        void stergere_Vacante()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Vacante";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string email = this.textBox_email.Text;
            string pass = this.textBox_parola.Text;

            if (util.userExists(email, pass))
            {
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    Turismul_de_pretutindeni.Properties.Settings.Default.email = email;
                    Turismul_de_pretutindeni.Properties.Settings.Default.Save();
                }
                else
                {
                    Turismul_de_pretutindeni.Properties.Settings.Default.email = "";
                    Turismul_de_pretutindeni.Properties.Settings.Default.Save();
                }

                GLOBAL.emailGlobal = email;
                this.Hide();
                FrmVacanta frm = new FrmVacanta();
                frm.emailToolStripMenuItem.Text = email;
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                this.textBox_email.ResetText();
                this.textBox_parola.ResetText();
                MessageBox.Show("Eroare Autentificare");
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInregistrare frm = new FrmInregistrare();
            frm.ShowDialog();
            this.Close();
        }
    }
}
