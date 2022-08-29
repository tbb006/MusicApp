
namespace MusicApp
{
    partial class FormAddAlbume
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
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDurata = new System.Windows.Forms.TextBox();
            this.txtGenMuzical = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdRemove
            // 
            this.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRemove.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdRemove.Location = new System.Drawing.Point(293, 321);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(80, 35);
            this.cmdRemove.TabIndex = 54;
            this.cmdRemove.Text = "Șterge";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAlbum.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(173, 69);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(200, 26);
            this.cmbAlbum.TabIndex = 52;
            this.cmbAlbum.SelectedIndexChanged += new System.EventHandler(this.cmbAlbum_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label6.Location = new System.Drawing.Point(39, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nume album";
            // 
            // txtDurata
            // 
            this.txtDurata.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtDurata.Location = new System.Drawing.Point(173, 250);
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.Size = new System.Drawing.Size(200, 23);
            this.txtDurata.TabIndex = 48;
            // 
            // txtGenMuzical
            // 
            this.txtGenMuzical.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtGenMuzical.Location = new System.Drawing.Point(173, 215);
            this.txtGenMuzical.Name = "txtGenMuzical";
            this.txtGenMuzical.Size = new System.Drawing.Size(200, 23);
            this.txtGenMuzical.TabIndex = 46;
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtNume.Location = new System.Drawing.Point(173, 105);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(200, 23);
            this.txtNume.TabIndex = 45;
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdAdd.Location = new System.Drawing.Point(43, 321);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(80, 35);
            this.cmdAdd.TabIndex = 42;
            this.cmdAdd.Text = "Adaugă";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label5.Location = new System.Drawing.Point(79, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Durată";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label4.Location = new System.Drawing.Point(89, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label3.Location = new System.Drawing.Point(39, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Gen muzical";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label2.Location = new System.Drawing.Point(51, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "An lansare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label1.Location = new System.Drawing.Point(81, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Album";
            // 
            // cmdQuit
            // 
            this.cmdQuit.BackColor = System.Drawing.Color.Transparent;
            this.cmdQuit.BackgroundImage = global::MusicApp.Properties.Resources.back;
            this.cmdQuit.FlatAppearance.BorderSize = 0;
            this.cmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdQuit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdQuit.Location = new System.Drawing.Point(43, 484);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(49, 51);
            this.cmdQuit.TabIndex = 43;
            this.cmdQuit.UseVisualStyleBackColor = false;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cmbArtist
            // 
            this.cmbArtist.BackColor = System.Drawing.SystemColors.Window;
            this.cmbArtist.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmbArtist.FormattingEnabled = true;
            this.cmbArtist.Location = new System.Drawing.Point(173, 140);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(200, 26);
            this.cmbArtist.TabIndex = 55;
            // 
            // txtAn
            // 
            this.txtAn.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtAn.Location = new System.Drawing.Point(173, 180);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(93, 23);
            this.txtAn.TabIndex = 56;
            // 
            // FormAddAlbume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(450, 616);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.cmbArtist);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmbAlbum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDurata);
            this.Controls.Add(this.txtGenMuzical);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormAddAlbume";
            this.Text = "Adaugă albume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDurata;
        private System.Windows.Forms.TextBox txtGenMuzical;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.TextBox txtAn;
    }
}