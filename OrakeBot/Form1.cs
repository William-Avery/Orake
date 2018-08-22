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

namespace OrakeBot
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    return;
            }

            base.WndProc(ref m);
        }

        private void p_menubar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void p_exitbutton_MouseDown(object sender, MouseEventArgs e)
        {
            this.p_exitbutton.BackgroundImage = OrakeBot.Properties.Resources.ExitButton_Pressed;
        }

        private void p_exitbutton_MouseUp(object sender, MouseEventArgs e)
        {
            this.p_exitbutton.BackgroundImage = OrakeBot.Properties.Resources.ExitButton;
        }

        private void p_exitbutton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void p_exitbutton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void p_exitbutton_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
