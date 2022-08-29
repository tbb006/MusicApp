
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmbMelodii = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dvgMelodii = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMelodii)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdAdd.Location = new System.Drawing.Point(90, 474);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(120, 30);
            this.cmdAdd.TabIndex = 15;
            this.cmdAdd.Text = "Modifică";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmbMelodii
            // 
            this.cmbMelodii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbMelodii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMelodii.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMelodii.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMelodii.FormattingEnabled = true;
            this.cmbMelodii.ItemHeight = 19;
            this.cmbMelodii.Items.AddRange(new object[] {
            "ID",
            "Denumire",
            "Artist",
            "Gen",
            "Lansare",
            "Album",
            "Lungime"});
            this.cmbMelodii.Location = new System.Drawing.Point(400, 27);
            this.cmbMelodii.Name = "cmbMelodii";
            this.cmbMelodii.Size = new System.Drawing.Size(219, 27);
            this.cmbMelodii.TabIndex = 18;
            this.cmbMelodii.SelectedIndexChanged += new System.EventHandler(this.cmbMelodii_SelectedIndexChanged);
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
            this.btnRefresh.Location = new System.Drawing.Point(90, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 35);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dvgMelodii
            // 
            this.dvgMelodii.AllowUserToOrderColumns = true;
            this.dvgMelodii.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgMelodii.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvgMelodii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgMelodii.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvgMelodii.Location = new System.Drawing.Point(90, 111);
            this.dvgMelodii.Name = "dvgMelodii";
            this.dvgMelodii.RowHeadersVisible = false;
            this.dvgMelodii.RowHeadersWidth = 50;
            this.dvgMelodii.Size = new System.Drawing.Size(865, 310);
            this.dvgMelodii.TabIndex = 21;
            // 
            // FormMelodii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1097, 567);
            this.Controls.Add(this.dvgMelodii);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbMelodii);
            this.Controls.Add(this.cmdAdd);
            this.Name = "FormMelodii";
            this.Text = "Melodii";
            this.Load += new System.EventHandler(this.FormMelodii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMelodii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ComboBox cmbMelodii;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dvgMelodii;
    }
}