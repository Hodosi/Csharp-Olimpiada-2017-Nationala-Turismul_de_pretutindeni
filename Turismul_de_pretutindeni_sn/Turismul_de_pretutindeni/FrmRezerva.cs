using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Turismul_de_pretutindeni
{
    public partial class FrmRezerva : Form
    {
        public FrmRezerva()
        {
            InitializeComponent();
        }

        REZERVARI rezerv = new REZERVARI();
        VACANTA vacant = new VACANTA();
        string nmLoc;
        int locuriRezervate;
        private void FrmRezerva_Load(object sender, EventArgs e)
        {
            nmLoc = this.label_nume.Text;
            this.dataGridView1.DataSource = rezerv.getRezervari(nmLoc);
        }

        public void setNumericDownValue()
        {
            DateTime dateIn = this.dateTimePicker1.Value;
            DateTime dateOut = this.dateTimePicker2.Value;
            int idVacanata = rezerv.getidVacanta(nmLoc);
            locuriRezervate = rezerv.getNrLocuriRezervate(idVacanata,dateIn,dateOut);
            this.numericUpDown1.Maximum = int.Parse(vacant.getLocuri(nmLoc)) - locuriRezervate;
        }

        public void getSuma()
        {
            int pers = int.Parse(this.numericUpDown1.Value.ToString());
            float pret = float.Parse(vacant.getPret(nmLoc));
            DateTime dateIn = this.dateTimePicker1.Value;
            DateTime dateOut = this.dateTimePicker2.Value;
            TimeSpan dif = dateOut - dateIn;
            float zile = dif.Days+1;

            float suma = pers * pret * zile;
            this.textBox1.Text = suma.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            getSuma();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            setNumericDownValue();
            getSuma();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            setNumericDownValue();
            getSuma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pers = int.Parse(this.numericUpDown1.Value.ToString());
            float.TryParse(this.textBox1.Text,out float pretTotal);
            DateTime dateIn = this.dateTimePicker1.Value;
            DateTime dateOut = this.dateTimePicker2.Value;
            int idUser = rezerv.getidUser(GLOBAL.emailGlobal);
            int idVacanata = rezerv.getidVacanta(nmLoc);
            if (dateOut < dateIn)
            {
                MessageBox.Show("Date incorecte");
                return;
            }

            //inserare
            if (rezerv.addRezervari(idVacanata, idUser, dateIn, dateOut, pers, pretTotal))
            {
                MessageBox.Show("Rezervat!");
                this.dataGridView1.DataSource = rezerv.getRezervari(nmLoc);
                setNumericDownValue();
            }
            else
            {
                MessageBox.Show("Eroare Rezervare");
            }

            
        }
    }
}
