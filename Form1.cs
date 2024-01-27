using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picShowPassword.Visible = false;
            picHiddenPassword.Visible = true;
        }

        private void picHiddenPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            picHiddenPassword.Visible = false;
            picShowPassword.Visible = true;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Register ss = new Register();
            ss.Show();
            this.Hide();
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword ss = new ForgetPassword();
            this.Hide();
            ss.ShowDialog();
        }
    }
}
