using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_Template
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
            btnSendALink.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChange(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                btnSendALink.Visible = false;
                btnSendALinkMask.Visible = true;
            }
            else
            {
                btnSendALink.Visible = true;
                btnSendALinkMask.Visible = false;
            }

        }

        private void btnSendALink_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picCloseFP_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void picMinimizeFP_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblBacktoLogin_Click(object sender, EventArgs e)
        {
            Form1 ss = new Form1();
            ss.Show();
            this.Close();
        }
    }
}
