
namespace MusicApp
{
    partial class FormAddFavorite
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.cmbMelodie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLungime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.btnReturn.Image = global::MusicApp.Properties.Resources.back;
            this.btnReturn.Location = new System.Drawing.Point(75, 449);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(60, 60);
            this.btnReturn.TabIndex = 61;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label8.Location = new System.Drawing.Point(115, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Album";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtAlbum.Location = new System.Drawing.Point(206, 244);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(160, 23);
            this.txtAlbum.TabIndex = 59;
          //  this.txtAlbum.TextChanged += new System.EventHandler(this.txtAlbum_TextChanged);
            // 
            // cmbMelodie
            // 
            this.cmbMelodie.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMelodie.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmbMelodie.FormattingEnabled = true;
            this.cmbMelodie.Location = new System.Drawing.Point(206, 54);
            this.cmbMelodie.Name = "cmbMelodie";
            this.cmbMelodie.Size = new System.Drawing.Size(160, 26);
            this.cmbMelodie.TabIndex = 58;
            this.cmbMelodie.SelectedIndexChanged += new System.EventHandler(this.cmbMelodie_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label6.Location = new System.Drawing.Point(104, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Melodie";
            // 
            // txtArtist
            // 
            this.txtArtist.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtArtist.Location = new System.Drawing.Point(206, 135);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.ReadOnly = true;
            this.txtArtist.Size = new System.Drawing.Size(160, 23);
            this.txtArtist.TabIndex = 56;
           // this.txtArtist.TextChanged += new System.EventHandler(this.txtArtist_TextChanged);
            // 
            // txtGen
            // 
            this.txtGen.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtGen.Location = new System.Drawing.Point(206, 171);
            this.txtGen.Name = "txtGen";
            this.txtGen.ReadOnly = true;
            this.txtGen.Size = new System.Drawing.Size(160, 23);
            this.txtGen.TabIndex = 55;
          //  this.txtGen.TextChanged += new System.EventHandler(this.txtGen_TextChanged);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.cmdAdd.Location = new System.Drawing.Point(233, 331);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(93, 33);
            this.cmdAdd.TabIndex = 50;
            this.cmdAdd.Text = "Adaugă";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label3.Location = new System.Drawing.Point(72, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Gen muzical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label4.Location = new System.Drawing.Point(72, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Dată lansare";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtNume.Location = new System.Drawing.Point(206, 99);
            this.txtNume.Name = "txtNume";
            this.txtNume.ReadOnly = true;
            this.txtNume.Size = new System.Drawing.Size(160, 23);
            this.txtNume.TabIndex = 46;
       //     this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nume melodie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label1.Location = new System.Drawing.Point(123, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Artist";
            // 
            // txtLungime
            // 
            this.txtLungime.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtLungime.Location = new System.Drawing.Point(206, 283);
            this.txtLungime.Name = "txtLungime";
            this.txtLungime.ReadOnly = true;
            this.txtLungime.Size = new System.Drawing.Size(160, 23);
            this.txtLungime.TabIndex = 43;
         //   this.txtLungime.TextChanged += new System.EventHandler(this.txtLungime_TextChanged);
          //  this.txtLungime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLungime_Keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label5.Location = new System.Drawing.Point(8, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Lungime melodie sec.";
            // 
            // txtAn
            // 
            this.txtAn.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtAn.Location = new System.Drawing.Point(206, 212);
            this.txtAn.Name = "txtAn";
            this.txtAn.ReadOnly = true;
            this.txtAn.Size = new System.Drawing.Size(160, 23);
            this.txtAn.TabIndex = 62;
            // 
            // FormAddFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(436, 554);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.cmbMelodie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLungime);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormAddFavorite";
            this.Text = "Adaugă melodii favorite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.ComboBox cmbMelodie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLungime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAn;
    }
}