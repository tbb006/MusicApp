
namespace MusicApp
{
    partial class FormAddMelodii
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
            this.txtLungime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.cmbMelodie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLungime
            // 
            this.txtLungime.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtLungime.Location = new System.Drawing.Point(209, 268);
            this.txtLungime.Name = "txtLungime";
            this.txtLungime.Size = new System.Drawing.Size(162, 23);
            this.txtLungime.TabIndex = 10;
            this.txtLungime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLungime_Keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label5.Location = new System.Drawing.Point(21, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lungime melodie sec.";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtNume.Location = new System.Drawing.Point(209, 84);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(162, 23);
            this.txtNume.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label2.Location = new System.Drawing.Point(68, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nume melodie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label1.Location = new System.Drawing.Point(131, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Artist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label4.Location = new System.Drawing.Point(93, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "An lansare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label3.Location = new System.Drawing.Point(80, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gen muzical";
            // 
            // cmdRemove
            // 
            this.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRemove.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdRemove.Location = new System.Drawing.Point(302, 336);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(80, 35);
            this.cmdRemove.TabIndex = 23;
            this.cmdRemove.Text = "Șterge";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdAdd.Location = new System.Drawing.Point(48, 336);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(80, 35);
            this.cmdAdd.TabIndex = 21;
            this.cmdAdd.Text = "Adaugă";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtGen
            // 
            this.txtGen.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtGen.Location = new System.Drawing.Point(209, 156);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(162, 23);
            this.txtGen.TabIndex = 35;
            // 
            // cmbMelodie
            // 
            this.cmbMelodie.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMelodie.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmbMelodie.FormattingEnabled = true;
            this.cmbMelodie.Location = new System.Drawing.Point(209, 42);
            this.cmbMelodie.Name = "cmbMelodie";
            this.cmbMelodie.Size = new System.Drawing.Size(162, 26);
            this.cmbMelodie.TabIndex = 38;
            this.cmbMelodie.SelectedIndexChanged += new System.EventHandler(this.cmbMelodie_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label6.Location = new System.Drawing.Point(113, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Melodie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label8.Location = new System.Drawing.Point(123, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Album";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Image = global::MusicApp.Properties.Resources.back;
            this.btnReturn.Location = new System.Drawing.Point(48, 481);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(60, 60);
            this.btnReturn.TabIndex = 41;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbArtist
            // 
            this.cmbArtist.BackColor = System.Drawing.SystemColors.Window;
            this.cmbArtist.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmbArtist.FormattingEnabled = true;
            this.cmbArtist.Location = new System.Drawing.Point(209, 120);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(162, 26);
            this.cmbArtist.TabIndex = 42;
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAlbum.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(209, 230);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(162, 26);
            this.cmbAlbum.TabIndex = 43;
            // 
            // txtAn
            // 
            this.txtAn.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtAn.Location = new System.Drawing.Point(209, 195);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(81, 23);
            this.txtAn.TabIndex = 44;
            // 
            // FormAddMelodii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(449, 589);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.cmbAlbum);
            this.Controls.Add(this.cmbArtist);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbMelodie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLungime);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormAddMelodii";
            this.Text = "Adaugă  melodii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLungime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.ComboBox cmbMelodie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.TextBox txtAn;
    }
}