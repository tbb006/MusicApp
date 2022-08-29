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

namespace MusicApp
{
    public partial class FormConectare : Form
    {
        public FormConectare()
        {
            InitializeComponent();
        }
        private void checkBoxParola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxParola.Checked)
            {
                txtParola.PasswordChar = '\0';
            }
            else
            {
                txtParola.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Utilizatori.xml");

            var Username = "";
            var Password = "";

            foreach (XmlNode xNode in xDoc.SelectNodes("Utilizatori/Utilizator"))
            {
                Username = xNode["Nume"].InnerText;
                Password = xNode["Parola"].InnerText;

                if (Username.Equals(txtUtilizator.Text) && Password.Equals(txtParola.Text))
                {
                    Form a = new FormMain();
                    a.Show();
                    this.Hide();
                }
            }
     
        }

        private void Inregistrare_Click(object sender, EventArgs e)
        {
            new FormUtilizatori().Show();
            this.Hide();
        }


    }
}
