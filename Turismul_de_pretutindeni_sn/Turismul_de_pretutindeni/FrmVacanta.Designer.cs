namespace Turismul_de_pretutindeni
{
    partial class FrmVacanta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacanteleMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaAdminNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaVacanteNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconectareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_loc = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_prev = new System.Windows.Forms.PictureBox();
            this.pictureBox_next = new System.Windows.Forms.PictureBox();
            this.label_nume = new System.Windows.Forms.Label();
            this.label_pret = new System.Windows.Forms.Label();
            this.label_locuri = new System.Windows.Forms.Label();
            this.label_descriere = new System.Windows.Forms.Label();
            this.button_Poster = new System.Windows.Forms.Button();
            this.button_Rezerva = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_next)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Rezerva);
            this.panel1.Controls.Add(this.button_Poster);
            this.panel1.Controls.Add(this.label_descriere);
            this.panel1.Controls.Add(this.label_locuri);
            this.panel1.Controls.Add(this.label_pret);
            this.panel1.Controls.Add(this.label_nume);
            this.panel1.Controls.Add(this.pictureBox_next);
            this.panel1.Controls.Add(this.pictureBox_prev);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.pictureBox_loc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 628);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.vacanteleMeleToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaAdminNouToolStripMenuItem,
            this.adaugaVacanteNoiToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(66, 36);
            this.fToolStripMenuItem.Text = "File";
            // 
            // vacanteleMeleToolStripMenuItem
            // 
            this.vacanteleMeleToolStripMenuItem.Name = "vacanteleMeleToolStripMenuItem";
            this.vacanteleMeleToolStripMenuItem.Size = new System.Drawing.Size(192, 36);
            this.vacanteleMeleToolStripMenuItem.Text = "Vacantele Mele";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconectareToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // adaugaAdminNouToolStripMenuItem
            // 
            this.adaugaAdminNouToolStripMenuItem.Name = "adaugaAdminNouToolStripMenuItem";
            this.adaugaAdminNouToolStripMenuItem.Size = new System.Drawing.Size(320, 36);
            this.adaugaAdminNouToolStripMenuItem.Text = "Adauga Admin Nou";
            // 
            // adaugaVacanteNoiToolStripMenuItem
            // 
            this.adaugaVacanteNoiToolStripMenuItem.Name = "adaugaVacanteNoiToolStripMenuItem";
            this.adaugaVacanteNoiToolStripMenuItem.Size = new System.Drawing.Size(320, 36);
            this.adaugaVacanteNoiToolStripMenuItem.Text = "Adauga Vacante Noi";
            // 
            // deconectareToolStripMenuItem
            // 
            this.deconectareToolStripMenuItem.Name = "deconectareToolStripMenuItem";
            this.deconectareToolStripMenuItem.Size = new System.Drawing.Size(238, 36);
            this.deconectareToolStripMenuItem.Text = "Deconectare";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(238, 36);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // pictureBox_loc
            // 
            this.pictureBox_loc.Location = new System.Drawing.Point(153, 71);
            this.pictureBox_loc.Name = "pictureBox_loc";
            this.pictureBox_loc.Size = new System.Drawing.Size(330, 545);
            this.pictureBox_loc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_loc.TabIndex = 1;
            this.pictureBox_loc.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(505, 583);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 33);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Auto Play";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_prev
            // 
            this.pictureBox_prev.Location = new System.Drawing.Point(64, 257);
            this.pictureBox_prev.Name = "pictureBox_prev";
            this.pictureBox_prev.Size = new System.Drawing.Size(61, 59);
            this.pictureBox_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_prev.TabIndex = 3;
            this.pictureBox_prev.TabStop = false;
            this.pictureBox_prev.Click += new System.EventHandler(this.pictureBox_prev_Click);
            // 
            // pictureBox_next
            // 
            this.pictureBox_next.Location = new System.Drawing.Point(505, 257);
            this.pictureBox_next.Name = "pictureBox_next";
            this.pictureBox_next.Size = new System.Drawing.Size(61, 59);
            this.pictureBox_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_next.TabIndex = 4;
            this.pictureBox_next.TabStop = false;
            this.pictureBox_next.Click += new System.EventHandler(this.pictureBox_next_Click);
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.BackColor = System.Drawing.Color.Transparent;
            this.label_nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_nume.Location = new System.Drawing.Point(198, 91);
            this.label_nume.MaximumSize = new System.Drawing.Size(300, 0);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(60, 24);
            this.label_nume.TabIndex = 5;
            this.label_nume.Text = "label1";
            // 
            // label_pret
            // 
            this.label_pret.AutoSize = true;
            this.label_pret.BackColor = System.Drawing.Color.Transparent;
            this.label_pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pret.Location = new System.Drawing.Point(198, 153);
            this.label_pret.Name = "label_pret";
            this.label_pret.Size = new System.Drawing.Size(60, 24);
            this.label_pret.TabIndex = 6;
            this.label_pret.Text = "label2";
            // 
            // label_locuri
            // 
            this.label_locuri.AutoSize = true;
            this.label_locuri.BackColor = System.Drawing.Color.Transparent;
            this.label_locuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_locuri.Location = new System.Drawing.Point(198, 209);
            this.label_locuri.Name = "label_locuri";
            this.label_locuri.Size = new System.Drawing.Size(60, 24);
            this.label_locuri.TabIndex = 7;
            this.label_locuri.Text = "label3";
            // 
            // label_descriere
            // 
            this.label_descriere.AutoSize = true;
            this.label_descriere.BackColor = System.Drawing.Color.Transparent;
            this.label_descriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descriere.Location = new System.Drawing.Point(198, 257);
            this.label_descriere.MaximumSize = new System.Drawing.Size(250, 0);
            this.label_descriere.Name = "label_descriere";
            this.label_descriere.Size = new System.Drawing.Size(60, 24);
            this.label_descriere.TabIndex = 8;
            this.label_descriere.Text = "label4";
            // 
            // button_Poster
            // 
            this.button_Poster.Location = new System.Drawing.Point(218, 562);
            this.button_Poster.Name = "button_Poster";
            this.button_Poster.Size = new System.Drawing.Size(203, 42);
            this.button_Poster.TabIndex = 9;
            this.button_Poster.Text = "Poster";
            this.button_Poster.UseVisualStyleBackColor = true;
            // 
            // button_Rezerva
            // 
            this.button_Rezerva.Location = new System.Drawing.Point(218, 500);
            this.button_Rezerva.Name = "button_Rezerva";
            this.button_Rezerva.Size = new System.Drawing.Size(203, 42);
            this.button_Rezerva.TabIndex = 10;
            this.button_Rezerva.Text = "Rezerva acum";
            this.button_Rezerva.UseVisualStyleBackColor = true;
            this.button_Rezerva.Click += new System.EventHandler(this.button_Rezerva_Click);
            // 
            // FrmVacanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 628);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVacanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVacanta";
            this.Load += new System.EventHandler(this.FrmVacanta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_next)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_descriere;
        private System.Windows.Forms.Label label_locuri;
        private System.Windows.Forms.Label label_pret;
        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.PictureBox pictureBox_next;
        private System.Windows.Forms.PictureBox pictureBox_prev;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaAdminNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaVacanteNoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacanteleMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconectareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_loc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Rezerva;
        private System.Windows.Forms.Button button_Poster;
        public System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
    }
}