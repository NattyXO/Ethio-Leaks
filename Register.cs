using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_Template
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtPasswordConfirm.UseSystemPasswordChar = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void lblLogin_Click(object sender, EventArgs e)
        {
            Form1 ss = new Form1();
            ss.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtPasswordConfirm.UseSystemPasswordChar = false;
            picShowPassword.Visible = false;
            picHiddenPassword.Visible = true;
        }

        private void picHiddenPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPasswordConfirm.UseSystemPasswordChar = true;
            picHiddenPassword.Visible = false;
            picShowPassword.Visible = true;
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
