
namespace MusicApp
{
    partial class FormUtilizatori
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
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdAdd.Location = new System.Drawing.Point(163, 234);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(95, 35);
            this.cmdAdd.TabIndex = 27;
            this.cmdAdd.Text = "Adaugă";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtCountry.Location = new System.Drawing.Point(195, 145);
            this.txtCountry.MaxLength = 2;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(63, 23);
            this.txtCountry.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtPassword.Location = new System.Drawing.Point(195, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 23);
            this.txtPassword.TabIndex = 22;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtUsername.Location = new System.Drawing.Point(195, 86);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 23);
            this.txtUsername.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label5.Location = new System.Drawing.Point(62, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Țară";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label3.Location = new System.Drawing.Point(63, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parolă";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label2.Location = new System.Drawing.Point(62, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nume utilizator";
            // 
            // btnInapoi
            // 
            this.btnInapoi.FlatAppearance.BorderSize = 0;
            this.btnInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInapoi.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.btnInapoi.Image = global::MusicApp.Properties.Resources.back;
            this.btnInapoi.Location = new System.Drawing.Point(23, 363);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(60, 60);
            this.btnInapoi.TabIndex = 30;
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // FormUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(435, 551);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormUtilizatori";
            this.Text = "Inregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInapoi;
    }
}

