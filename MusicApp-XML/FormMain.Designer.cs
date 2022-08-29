
namespace MusicApp
{
    partial class FormMain
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnAlbume = new System.Windows.Forms.Button();
            this.btnArtisti = new System.Windows.Forms.Button();
            this.btnMelodii = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(105, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1096, 594);
            this.panelDesktop.TabIndex = 10;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(105, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1096, 70);
            this.panelTitle.TabIndex = 9;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Location = new System.Drawing.Point(506, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(72, 24);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Acasă";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelMenu.Controls.Add(this.btnDeconectare);
            this.panelMenu.Controls.Add(this.btnFavorite);
            this.panelMenu.Controls.Add(this.btnAlbume);
            this.panelMenu.Controls.Add(this.btnArtisti);
            this.panelMenu.Controls.Add(this.btnMelodii);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(105, 664);
            this.panelMenu.TabIndex = 8;
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeconectare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnDeconectare.FlatAppearance.BorderSize = 0;
            this.btnDeconectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconectare.Font = new System.Drawing.Font("Bookman Old Style", 9.5F);
            this.btnDeconectare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeconectare.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeconectare.Location = new System.Drawing.Point(2, 624);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(107, 40);
            this.btnDeconectare.TabIndex = 5;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.UseVisualStyleBackColor = false;
            this.btnDeconectare.Click += new System.EventHandler(this.btnDeconectare_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(105, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MusicApp.Properties.Resources.welcome3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1096, 594);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::MusicApp.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1054, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Image = global::MusicApp.Properties.Resources.max;
            this.btnMaximize.Location = new System.Drawing.Point(1008, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Image = global::MusicApp.Properties.Resources.min;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(959, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 35);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.Image = global::MusicApp.Properties.Resources.favorite;
            this.btnFavorite.Location = new System.Drawing.Point(0, 340);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(105, 90);
            this.btnFavorite.TabIndex = 4;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnAlbume
            // 
            this.btnAlbume.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlbume.FlatAppearance.BorderSize = 0;
            this.btnAlbume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbume.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.btnAlbume.ForeColor = System.Drawing.Color.White;
            this.btnAlbume.Image = global::MusicApp.Properties.Resources.albume;
            this.btnAlbume.Location = new System.Drawing.Point(0, 250);
            this.btnAlbume.Name = "btnAlbume";
            this.btnAlbume.Size = new System.Drawing.Size(105, 90);
            this.btnAlbume.TabIndex = 3;
            this.btnAlbume.Text = "Albume";
            this.btnAlbume.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlbume.UseVisualStyleBackColor = true;
            this.btnAlbume.Click += new System.EventHandler(this.btnAlbume_Click);
            // 
            // btnArtisti
            // 
            this.btnArtisti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtisti.FlatAppearance.BorderSize = 0;
            this.btnArtisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtisti.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.btnArtisti.ForeColor = System.Drawing.Color.White;
            this.btnArtisti.Image = global::MusicApp.Properties.Resources.artisti;
            this.btnArtisti.Location = new System.Drawing.Point(0, 160);
            this.btnArtisti.Name = "btnArtisti";
            this.btnArtisti.Size = new System.Drawing.Size(105, 90);
            this.btnArtisti.TabIndex = 2;
            this.btnArtisti.Text = "Artiști";
            this.btnArtisti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArtisti.UseVisualStyleBackColor = true;
            this.btnArtisti.Click += new System.EventHandler(this.btnArtisti_Click);
            // 
            // btnMelodii
            // 
            this.btnMelodii.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMelodii.FlatAppearance.BorderSize = 0;
            this.btnMelodii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMelodii.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.btnMelodii.ForeColor = System.Drawing.Color.White;
            this.btnMelodii.Image = global::MusicApp.Properties.Resources.muzica;
            this.btnMelodii.Location = new System.Drawing.Point(0, 70);
            this.btnMelodii.Name = "btnMelodii";
            this.btnMelodii.Size = new System.Drawing.Size(105, 90);
            this.btnMelodii.TabIndex = 1;
            this.btnMelodii.Text = "Melodii";
            this.btnMelodii.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMelodii.UseVisualStyleBackColor = true;
            this.btnMelodii.Click += new System.EventHandler(this.btnMelodii_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Image = global::MusicApp.Properties.Resources.logo3;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(106, 70);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 664);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panelDesktop.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnAlbume;
        private System.Windows.Forms.Button btnArtisti;
        private System.Windows.Forms.Button btnMelodii;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}