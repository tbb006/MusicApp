
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
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRemove
            // 
            this.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRemove.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdRemove.Location = new System.Drawing.Point(290, 293);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(95, 35);
            this.cmdRemove.TabIndex = 29;
            this.cmdRemove.Text = "Șterge";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdModify
            // 
            this.cmdModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModify.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdModify.Location = new System.Drawing.Point(178, 293);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(95, 35);
            this.cmdModify.TabIndex = 28;
            this.cmdModify.Text = "Modifică";
            this.cmdModify.UseVisualStyleBackColor = true;
            this.cmdModify.Click += new System.EventHandler(this.cmdModify_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdAdd.Location = new System.Drawing.Point(71, 293);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(95, 35);
            this.cmdAdd.TabIndex = 27;
            this.cmdAdd.Text = "Adaugă";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.dtpRegistrationDate.Location = new System.Drawing.Point(200, 152);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(173, 23);
            this.dtpRegistrationDate.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label6.Location = new System.Drawing.Point(68, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtUserId.Location = new System.Drawing.Point(200, 217);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(63, 23);
            this.txtUserId.TabIndex = 24;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtCountryCode.Location = new System.Drawing.Point(200, 186);
            this.txtCountryCode.MaxLength = 2;
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(63, 23);
            this.txtCountryCode.TabIndex = 23;
            this.txtCountryCode.TextChanged += new System.EventHandler(this.txtCountryCode_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtPassword.Location = new System.Drawing.Point(200, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 23);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtUsername.Location = new System.Drawing.Point(200, 89);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 23);
            this.txtUsername.TabIndex = 21;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // cmbUser
            // 
            this.cmbUser.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(200, 54);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(173, 26);
            this.cmbUser.TabIndex = 20;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label5.Location = new System.Drawing.Point(67, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Țară";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label4.Location = new System.Drawing.Point(67, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dată înregistrare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label3.Location = new System.Drawing.Point(68, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parolă";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label2.Location = new System.Drawing.Point(67, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nume utilizator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label1.Location = new System.Drawing.Point(67, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Utilizator";
            // 
            // btnInapoi
            // 
            this.btnInapoi.FlatAppearance.BorderSize = 0;
            this.btnInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInapoi.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.btnInapoi.Image = global::MusicApp.Properties.Resources.back;
            this.btnInapoi.Location = new System.Drawing.Point(23, 386);
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
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormUtilizatori";
            this.Text = "Inregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInapoi;
    }
}

