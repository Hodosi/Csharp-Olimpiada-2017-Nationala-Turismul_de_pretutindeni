namespace Turismul_de_pretutindeni
{
    partial class FrmAdminNou
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Transforma = new System.Windows.Forms.Button();
            this.button_Inregistrare = new System.Windows.Forms.Button();
            this.button_Renunta = new System.Windows.Forms.Button();
            this.listBox_users = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Transforma);
            this.panel1.Controls.Add(this.button_Inregistrare);
            this.panel1.Controls.Add(this.button_Renunta);
            this.panel1.Controls.Add(this.listBox_users);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 206);
            this.panel1.TabIndex = 0;
            // 
            // button_Transforma
            // 
            this.button_Transforma.Location = new System.Drawing.Point(404, 147);
            this.button_Transforma.Name = "button_Transforma";
            this.button_Transforma.Size = new System.Drawing.Size(183, 37);
            this.button_Transforma.TabIndex = 4;
            this.button_Transforma.Text = "Transforma";
            this.button_Transforma.UseVisualStyleBackColor = true;
            this.button_Transforma.Click += new System.EventHandler(this.button_Transforma_Click);
            // 
            // button_Inregistrare
            // 
            this.button_Inregistrare.Location = new System.Drawing.Point(215, 147);
            this.button_Inregistrare.Name = "button_Inregistrare";
            this.button_Inregistrare.Size = new System.Drawing.Size(183, 37);
            this.button_Inregistrare.TabIndex = 3;
            this.button_Inregistrare.Text = "Inregistrare";
            this.button_Inregistrare.UseVisualStyleBackColor = true;
            this.button_Inregistrare.Click += new System.EventHandler(this.button_Inregistrare_Click);
            // 
            // button_Renunta
            // 
            this.button_Renunta.Location = new System.Drawing.Point(26, 147);
            this.button_Renunta.Name = "button_Renunta";
            this.button_Renunta.Size = new System.Drawing.Size(183, 37);
            this.button_Renunta.TabIndex = 2;
            this.button_Renunta.Text = "Renunta";
            this.button_Renunta.UseVisualStyleBackColor = true;
            this.button_Renunta.Click += new System.EventHandler(this.button_Renunta_Click);
            // 
            // listBox_users
            // 
            this.listBox_users.FormattingEnabled = true;
            this.listBox_users.ItemHeight = 29;
            this.listBox_users.Location = new System.Drawing.Point(149, 63);
            this.listBox_users.Name = "listBox_users";
            this.listBox_users.Size = new System.Drawing.Size(387, 33);
            this.listBox_users.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // FrmAdminNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 206);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdminNou";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminNou";
            this.Load += new System.EventHandler(this.FrmAdminNou_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Transforma;
        private System.Windows.Forms.Button button_Inregistrare;
        private System.Windows.Forms.Button button_Renunta;
        private System.Windows.Forms.ListBox listBox_users;
        private System.Windows.Forms.Label label1;
    }
}