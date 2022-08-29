using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MusicApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            random = new Random();
            btnLogo.Visible = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private static Button currButton;
        private static Random random;
        private static int tempIndex;
        private static Form activeForm;

        private static Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void DisableButton()
        {

            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(23, 23, 23);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Bookman Old Style", 10, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currButton = (Button)btnSender;
                    currButton.BackColor = color;
                    currButton.ForeColor = Color.White;
                    currButton.Font = new Font("Bookman Old Style", 12, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    btnDeconectare.BackColor = Color.FromArgb(15, 15, 15);
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnLogo.Visible = true;
                }
            }
        }

        private void OpenForms(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }
        
        private void Reset()
        {
            DisableButton();
            lbTitle.Text = "Acasă";
            btnDeconectare.BackColor = Color.FromArgb(15, 15, 15);
            panelTitle.BackColor = Color.FromArgb(23, 23, 23);
            panelLogo.BackColor = Color.FromArgb(23, 23, 23);
            currButton = null;
            btnLogo.Visible = true;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMelodii_Click(object sender, EventArgs e)
        {
            OpenForms(new FormMelodii(), sender);
        }

        private void btnArtisti_Click(object sender, EventArgs e)
        {
            OpenForms(new FormArtisti(), sender);
        }

        private void btnAlbume_Click(object sender, EventArgs e)
        {
            OpenForms(new FormAlbume(), sender);
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            OpenForms(new FormFavorite(), sender);
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }        


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormConectare();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
