using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_Template
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            btnRestoreDown.Visible = false;
            homeController1.BringToFront();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnEpandandClose_Click(object sender, EventArgs e)
        {
            if (sideBar.Width == 162)
            {
                sideBar.Width = 65;
                btnHome.Text = "";
                btnCollection.Text = "";
                btnModels.Text = "";
                btnCategories.Text = "";
                btnPhotos.Text = "";
                btnVIP.Text = "";
                btnPlaylist.Text = "";
                btnRequest.Text = "";
                btnChat.Text = "";
                btnAbout.Text = "";
            }
            else
            {
                sideBar.Width = 162;
                btnHome.Text = "Home";
                btnCollection.Text = "Collection";
                btnModels.Text = "Models";
                btnCategories.Text = "Categories";
                btnPhotos.Text = "Photos";
                btnVIP.Text = "VIP";
                btnPlaylist.Text = "Playlist";
                btnRequest.Text = "Request";
                btnChat.Text = "Chat";
                btnAbout.Text = "About";
            }

        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                lblTop.Text = "Home";
                collectionController1.SendToBack();
                homeController1.BringToFront();


            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCollection_Click(object sender, EventArgs e)
        {

            try
            {
                lblTop.Text = "Collection";

                collectionController1.BringToFront();
                homeController1.SendToBack();
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModels_Click(object sender, EventArgs e)
        {
            lblTop.Text = "Models";
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            lblTop.Text = "Categories";
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            lblTop.Text = "Photos";
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            lblTop.Text = "VIP";
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            lblTop.Text = "Playlist";
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            lblTop.Text = "Request";
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            lblTop.Text = "Chat";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            lblTop.Text = "About";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestoreDown.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            btnRestoreDown.Visible = true;
            btnMaximize.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 ssl = new Form1();
            ssl.Show();
            this.Hide();

        }
    }
}
