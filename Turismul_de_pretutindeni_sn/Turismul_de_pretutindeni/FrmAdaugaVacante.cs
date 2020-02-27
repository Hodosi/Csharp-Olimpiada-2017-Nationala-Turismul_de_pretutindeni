using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Turismul_de_pretutindeni
{
    public partial class FrmAdaugaVacante : Form
    {
        public FrmAdaugaVacante()
        {
            InitializeComponent();
        }

        QUERYS que = new QUERYS();
        CONNECTION conn = new CONNECTION();
        private void FrmAdaugaVacante_Load(object sender, EventArgs e)
        {
            readText();
        }

        public void readText()
        {
            string fn = Application.StartupPath + @"\Resurse\Vacante.txt";
            StreamReader reader = new StreamReader(fn);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                this.richTextBox1.AppendText(line + "\n");
            }
            reader.Close();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + @"\Resurse\Vacante.txt";
            StreamWriter writer = new StreamWriter(fn);
            string text = this.richTextBox1.Text;
            writer.Write(text);
            writer.Close();
            if (que.dbccVacante())
            {
                MessageBox.Show("Hei");
            }
            stergere_Vacante();
            initializare_Vacante();
            this.Close();
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
                if (nume == "")
                {
                    return;
                }
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

            readerText.Close();
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
    }
}
