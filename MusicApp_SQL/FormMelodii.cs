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


        private void cmbMelodii_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sortare(cmbMelodii.SelectedItem.ToString());
        }

        private void FormMelodii_Load(object sender, EventArgs e)
        {
            Sortare("ID");
        }

        private void Sortare(string value)
        {
            SqlConnection conn = Utilities.OpenDbConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd;
            DataView dv;
            String query = "SELECT * FROM melodii";
            cmd = new SqlCommand(query, conn);
            adapter.SelectCommand = cmd;
            ds.Clear();
            adapter.Fill(ds);
            dv = new DataView(ds.Tables[0]);
            dv.Sort = value;
            dvgMelodii.DataSource = dv;

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddMelodii form = new FormAddMelodii();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Utilities.OpenDbConnection();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM melodii order by ID", conn);
            conn.Close();

            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dvgMelodii.DataSource = dt;
        }

    }
}