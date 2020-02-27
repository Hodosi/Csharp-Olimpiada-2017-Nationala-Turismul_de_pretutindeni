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
    public partial class FrmVacanteleMele : Form
    {
        public FrmVacanteleMele()
        {
            InitializeComponent();
        }

        REZERVARI rezerv = new REZERVARI();
        private void FrmVacanteleMele_Load(object sender, EventArgs e)
        {
            DataTable table = rezerv.getRezervariByEmail(GLOBAL.emailGlobal); 
            this.dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                int pret = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                if (rezerv.deleteRezervare(pret))
                {
                    DataTable table = rezerv.getRezervariByEmail(GLOBAL.emailGlobal);
                    this.dataGridView1.DataSource = table;
                }
            }
        }
    }
}
