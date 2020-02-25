namespace Turismul_de_pretutindeni
{
    partial class FrmAutentificare
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
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.button_register);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.textBox_parola);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 400);
            this.panel1.TabIndex = 0;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(300, 301);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(236, 51);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Autentificare";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(25, 301);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(236, 51);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Inregistrare";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(233, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 33);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Retine email";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(158, 146);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(325, 34);
            this.textBox_parola.TabIndex = 3;
            this.textBox_parola.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(158, 75);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(325, 34);
            this.textBox_email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // FrmAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 400);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAutentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAutentificare";
            this.Load += new System.EventHandler(this.FrmAutentificare_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label1;
    }
}