
namespace MusicApp
{
    partial class FormMelodii
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.An = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Durata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdAdd.Location = new System.Drawing.Point(462, 447);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(120, 30);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "Modifică";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Favorite";
            this.dataGridViewImageColumn1.Image = global::MusicApp.Properties.Resources.addfavorite;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::MusicApp.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(63, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 35);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Artist,
            this.Gen,
            this.An,
            this.Album,
            this.Durata});
            this.listView1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1000, 308);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 200;
            // 
            // Artist
            // 
            this.Artist.Text = "Artist";
            this.Artist.Width = 200;
            // 
            // Gen
            // 
            this.Gen.Text = "Gen Muzical";
            this.Gen.Width = 160;
            // 
            // An
            // 
            this.An.Text = "Anul lansarii";
            this.An.Width = 120;
            // 
            // Album
            // 
            this.Album.Text = "Album";
            this.Album.Width = 200;
            // 
            // Durata
            // 
            this.Durata.Text = "Durata";
            this.Durata.Width = 110;
            // 
            // FormMelodii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1097, 567);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmdAdd);
            this.Name = "FormMelodii";
            this.Text = "Melodii";
            this.Load += new System.EventHandler(this.FormMelodii_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.ColumnHeader An;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.ColumnHeader Durata;
    }
}