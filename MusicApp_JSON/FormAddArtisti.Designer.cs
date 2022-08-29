
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
            this.txtColaborare = new System.Windows.Forms.TextBox();
            this.txtGenMuzical = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlbume = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtColaborare
            // 
            this.txtColaborare.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtColaborare.Location = new System.Drawing.Point(175, 180);
            this.txtColaborare.Name = "txtColaborare";
            this.txtColaborare.Size = new System.Drawing.Size(200, 23);
            this.txtColaborare.TabIndex = 27;
            // 
            // txtGenMuzical
            // 
            this.txtGenMuzical.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtGenMuzical.Location = new System.Drawing.Point(175, 101);
            this.txtGenMuzical.Name = "txtGenMuzical";
            this.txtGenMuzical.Size = new System.Drawing.Size(200, 23);
            this.txtGenMuzical.TabIndex = 26;
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtNume.Location = new System.Drawing.Point(175, 63);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(200, 23);
            this.txtNume.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label7.Location = new System.Drawing.Point(39, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Anul nasterii";
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
            this.cmdAdd.Location = new System.Drawing.Point(295, 303);
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
            this.label5.Location = new System.Drawing.Point(79, 219);
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
            this.label4.Location = new System.Drawing.Point(61, 180);
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
            this.label3.Location = new System.Drawing.Point(43, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gen muzical";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.label6.Location = new System.Drawing.Point(51, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nume artist";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlbume
            // 
            this.txtAlbume.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtAlbume.Location = new System.Drawing.Point(175, 219);
            this.txtAlbume.Name = "txtAlbume";
            this.txtAlbume.Size = new System.Drawing.Size(200, 23);
            this.txtAlbume.TabIndex = 37;
            // 
            // txtAn
            // 
            this.txtAn.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.txtAn.Location = new System.Drawing.Point(175, 139);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(200, 23);
            this.txtAn.TabIndex = 38;
            // 
            // FormAddArtisti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(436, 569);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtAlbume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColaborare);
            this.Controls.Add(this.txtGenMuzical);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FormAddArtisti";
            this.Text = "Adaugă artiști";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtColaborare;
        private System.Windows.Forms.TextBox txtGenMuzical;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlbume;
        private System.Windows.Forms.TextBox txtAn;
    }
}