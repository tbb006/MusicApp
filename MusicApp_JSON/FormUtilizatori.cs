using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using Newtonsoft.Json;
using System.IO;


namespace MusicApp
{
    public partial class FormUtilizatori : Form
    {

        public FormUtilizatori()
        {
            InitializeComponent();
        }



        private void cmdAdd_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtCountry.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                User user = new User();
                user.username = txtUsername.Text;
                user.password = txtPassword.Text;
                user.country = txtCountry.Text;

                StreamReader reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"..\..\userData.JSON"));
                string jsonString = reader.ReadToEnd();

                Users users = JsonConvert.DeserializeObject<Users>(jsonString);
                reader.Close();

                users.Add(user);

                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\userData.JSON"), JsonConvert.SerializeObject(users, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented));

                MessageBox.Show("Utilizator creat cu succes!");
                FormConectare frm = new FormConectare();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }

        }


        private void btnInapoi_Click(object sender, EventArgs e)
        {
            new FormConectare().Show();
            this.Hide();
        }

    }
}
