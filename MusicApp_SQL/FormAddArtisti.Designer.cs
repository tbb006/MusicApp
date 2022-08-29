
namespace MusicApp
{
    partial class FormAddArtisti
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
            this.dtpDataNastere = new System.Windows.Forms.DateTimePicker();
            this.txtColaborare = new System.Windows.Forms.TextBox();
            this.txtGenMuzical = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArtistId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.txtAlbume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDataNastere
            // 
            this.dtpDataNastere.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.dtpDataNastere.Location = new System.Drawing.Point(175, 138);
            this.dtpDataNastere.Name = "dtpDataNastere";
            this.dtpDataNastere.Size = new System.Drawing.Size(200, 23);
            this.dtpDataNastere.TabIndex = 31;
            // 
            // txtColaborare
            // 
            this.txtColaborare.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtColaborare.Location = new System.Drawing.Point(175, 214);
            this.txtColaborare.Name = "txtColaborare";
            this.txtColaborare.Size = new System.Drawing.Size(200, 23);
            this.txtColaborare.TabIndex = 27;
            this.txtColaborare.TextChanged += new System.EventHandler(this.txtColaborari_TextChanged);
            // 
            // txtGenMuzical
            // 
            this.txtGenMuzical.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtGenMuzical.Location = new System.Drawing.Point(175, 176);
            this.txtGenMuzical.Name = "txtGenMuzical";
            this.txtGenMuzical.Size = new System.Drawing.Size(200, 23);
            this.txtGenMuzical.TabIndex = 26;
            this.txtGenMuzical.TextChanged += new System.EventHandler(this.txtGen_TextChanged);
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtNume.Location = new System.Drawing.Point(175, 103);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(200, 23);
            this.txtNume.TabIndex = 25;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label7.Location = new System.Drawing.Point(76, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID artist";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdQuit
            // 
            this.cmdQuit.BackColor = System.Drawing.Color.Transparent;
            this.cmdQuit.BackgroundImage = global::MusicApp.Properties.Resources.back;
            this.cmdQuit.FlatAppearance.BorderSize = 0;
            this.cmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdQuit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdQuit.Location = new System.Drawing.Point(36, 472);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(49, 51);
            this.cmdQuit.TabIndex = 23;
            this.cmdQuit.UseVisualStyleBackColor = false;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdAdd.Location = new System.Drawing.Point(47, 356);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(80, 35);
            this.cmdAdd.TabIndex = 22;
            this.cmdAdd.Text = "Adaugă";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label5.Location = new System.Drawing.Point(79, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Albume";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label4.Location = new System.Drawing.Point(61, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Colaborari";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label3.Location = new System.Drawing.Point(43, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gen muzical";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label2.Location = new System.Drawing.Point(43, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data nașterii";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label1.Location = new System.Drawing.Point(95, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Artist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArtistId
            // 
            this.txtArtistId.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtArtistId.Location = new System.Drawing.Point(175, 294);
            this.txtArtistId.Name = "txtArtistId";
            this.txtArtistId.ReadOnly = true;
            this.txtArtistId.Size = new System.Drawing.Size(63, 23);
            this.txtArtistId.TabIndex = 32;
            this.txtArtistId.TextChanged += new System.EventHandler(this.txtArtistId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label6.Location = new System.Drawing.Point(51, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nume artist";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbArtist
            // 
            this.cmbArtist.BackColor = System.Drawing.SystemColors.Window;
            this.cmbArtist.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmbArtist.FormattingEnabled = true;
            this.cmbArtist.Location = new System.Drawing.Point(175, 61);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(200, 26);
            this.cmbArtist.TabIndex = 34;
            this.cmbArtist.SelectedIndexChanged += new System.EventHandler(this.cmbArtist_SelectedIndexChanged);
            // 
            // cmdModify
            // 
            this.cmdModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModify.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdModify.Location = new System.Drawing.Point(175, 357);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(80, 35);
            this.cmdModify.TabIndex = 35;
            this.cmdModify.Text = "Modifică";
            this.cmdModify.UseVisualStyleBackColor = true;
            this.cmdModify.Click += new System.EventHandler(this.cmdModify_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRemove.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdRemove.Location = new System.Drawing.Point(288, 357);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(80, 35);
            this.cmdRemove.TabIndex = 36;
            this.cmdRemove.Text = "Șterge";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // txtAlbume
            // 
            this.txtAlbume.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtAlbume.Location = new System.Drawing.Point(175, 253);
            this.txtAlbume.Name = "txtAlbume";
            this.txtAlbume.Size = new System.Drawing.Size(200, 23);
            this.txtAlbume.TabIndex = 37;
            this.txtAlbume.TextChanged += new System.EventHandler(this.txtAlbume_TextChanged);
            // 
            // FormAddArtisti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(436, 569);
            this.Controls.Add(this.txtAlbume);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.cmbArtist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtArtistId);
            this.Controls.Add(this.dtpDataNastere);
            this.Controls.Add(this.txtColaborare);
            this.Controls.Add(this.txtGenMuzical);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FormAddArtisti";
            this.Text = "Adaugă artiști";
            this.TextChanged += new System.EventHandler(this.txtArtistId_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataNastere;
        private System.Windows.Forms.TextBox txtColaborare;
        private System.Windows.Forms.TextBox txtGenMuzical;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArtistId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.TextBox txtAlbume;
    }
}