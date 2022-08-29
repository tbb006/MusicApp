using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MusicApp
{
    public partial class FormMelodii : Form
    {
        public FormMelodii()
        {
            InitializeComponent();
            dvgMelodii.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dvgMelodii.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dvgMelodii.DefaultCellStyle.Font = new Font("Bookman Old Style", 10);
            dvgMelodii.AutoResizeColumns();
            dvgMelodii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgMelodii.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
        }


        private void FormMelodii_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"..\..\Melodii.xml");
            dvgMelodii.DataSource = ds.Tables[0];

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddMelodii form = new FormAddMelodii();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

    }
}