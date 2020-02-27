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
    public partial class FrmAdminNou : Form
    {
        public FrmAdminNou()
        {
            InitializeComponent();
        }

        UTILIZATORI util =new UTILIZATORI();
        private void FrmAdminNou_Load(object sender, EventArgs e)
        {
            this.listBox_users.DataSource = util.getUser();
            this.listBox_users.DisplayMember = "Email";
            this.listBox_users.ValueMember = "Email";
        }

        private void button_Renunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVacanta frm = new FrmVacanta();
            frm.ShowDialog();
            this.Close();
        }

        private void button_Inregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInregistrare frm = new FrmInregistrare();
            frm.ShowDialog();
            this.Close();
        }

        private void button_Transforma_Click(object sender, EventArgs e)
        {
            string em = this.listBox_users.SelectedValue.ToString();
            MessageBox.Show(em);
            if (util.updateAdmin(em))
            {
                MessageBox.Show("Admin Adaugat");
            }
        }
    }
}
