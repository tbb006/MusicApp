
namespace MusicApp
{
    partial class FormConectare
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Inregistrare = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.checkBoxParola = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackgroundImage = global::MusicApp.Properties.Resources.login31;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(328, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 450);
            this.panel1.TabIndex = 11;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Image = global::MusicApp.Properties.Resources.button;
            this.btnLogin.Location = new System.Drawing.Point(91, 321);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 49);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Conecteaza-te";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Conectare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Utilizator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(65, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Parola";
            // 
            // Inregistrare
            // 
            this.Inregistrare.AutoSize = true;
            this.Inregistrare.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.Inregistrare.Location = new System.Drawing.Point(88, 385);
            this.Inregistrare.Name = "Inregistrare";
            this.Inregistrare.Size = new System.Drawing.Size(119, 19);
            this.Inregistrare.TabIndex = 16;
            this.Inregistrare.Text = "Înregistrează-te";
            this.Inregistrare.Click += new System.EventHandler(this.Inregistrare_Click);
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUtilizator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUtilizator.Font = new System.Drawing.Font("Bookman Old Style", 14F);
            this.txtUtilizator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUtilizator.Location = new System.Drawing.Point(69, 106);
            this.txtUtilizator.Multiline = true;
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(168, 35);
            this.txtUtilizator.TabIndex = 17;
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParola.Font = new System.Drawing.Font("Bookman Old Style", 14F);
            this.txtParola.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtParola.Location = new System.Drawing.Point(69, 183);
            this.txtParola.Multiline = true;
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(168, 35);
            this.txtParola.TabIndex = 18;
            // 
            // checkBoxParola
            // 
            this.checkBoxParola.AutoSize = true;
            this.checkBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxParola.Location = new System.Drawing.Point(172, 235);
            this.checkBoxParola.Name = "checkBoxParola";
            this.checkBoxParola.Size = new System.Drawing.Size(128, 22);
            this.checkBoxParola.TabIndex = 19;
            this.checkBoxParola.Text = "Afișează parola";
            this.checkBoxParola.UseVisualStyleBackColor = true;
            this.checkBoxParola.CheckedChanged += new System.EventHandler(this.checkBoxParola_CheckedChanged);
            // 
            // FormConectare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.checkBoxParola);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.Inregistrare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormConectare";
            this.Text = "Conectare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Inregistrare;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.CheckBox checkBoxParola;
    }
}