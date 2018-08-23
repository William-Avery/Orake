using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Vanilla.CheatEngine;

namespace OrakeBot
{
    public partial class Form1 : Form
    {
        #region Globals
        public const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
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
        [DllImport("kernel32.dll")]
        public static extern IntPtr ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
        [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern int OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        public int GetObjectSize(object TestObject)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            byte[] Array;
            bf.Serialize(ms, TestObject);
            Array = ms.ToArray();
            return Array.Length;
        }

        private int convertPlayerX(int playerx)
        {
            return ((playerx / 4) * 32) + 16;
        }

        private int convertPlayerY(int playery)
        {
            return ((playery / 4) * 32) + 16;
        }
        #region Read/Write
        /*
        private void ReadMemory()
        {
            Process[] p = Process.GetProcessesByName("Aok HD");
            uint DELETE = 0x00010000;
            uint READ_CONTROL = 0x00020000;
            uint WRITE_DAC = 0x00040000;
            uint WRITE_OWNER = 0x00080000;
            uint SYNCHRONIZE = 0x00100000;
            uint END = 0xFFF; //if you have Windows XP or Windows Server 2003 you must change this to 0xFFFF
            uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);

            int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);
            int processSize = GetObjectSize("12");

            if (p.Length > 0)
            {
                using (Memory memory = new Memory(p[0]))
                {
                    //Pull Character & Screen
                    //Character X
                    IntPtr address = memory.GetAddress("\"Aok HD.exe\"+006DC9A0+4+3C+134");
                    int wood = Convert.ToInt32(memory.ReadInt32(address));

                    //Character Y
                    //address = memory.GetAddress("\"Aok HD.exe\"+008C9D4C");
                    //int get_char_y = Convert.ToInt32(memory.ReadInt32(address));

                    //Camera X
                    //address = memory.GetAddress("\"Aok HD.exe\"+0013CF9C");
                    //int camera_x = Convert.ToInt32(memory.ReadInt32(address));

                    //Camera Y
                    //address = memory.GetAddress("\"Aok HD.exe\"+0013CF90");
                    //int camera_y = Convert.ToInt32(memory.ReadInt32(address));

                    ////Write to Game
                    ////Mouse X
                    //IntPtr a1 = memory.GetAddress("\"Wow.exe\"+0013D22C");
                    //memory.WriteInt32(a1, mouse_x);

                    ////Mouse Y
                    //IntPtr a2 = memory.GetAddress("\"Wow.exe\"+0013D230");
                    //memory.WriteInt32(a2, mouse_y);
                }
            }
        }
        private void WriteMemory()
        {
            Process[] p = Process.GetProcessesByName("WoW");
                    Console.WriteLine(p[0]);
                    uint DELETE = 0x00010000;
                    uint READ_CONTROL = 0x00020000;
                    uint WRITE_DAC = 0x00040000;
                    uint WRITE_OWNER = 0x00080000;
                    uint SYNCHRONIZE = 0x00100000;
                    uint END = 0xFFF; //if you have Windows XP or Windows Server 2003 you must change this to 0xFFFF
                    uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);

                    int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);
                    int processSize = GetObjectSize("12");
                    Process[] processes = Process.GetProcessesByName("WoW");
                    using (Memory memory = new Memory(processes[0]))
                    {
                        IntPtr addressy = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+6B4+3C+2C8");
                        IntPtr addressx = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+708+C+2A8");
                        IntPtr addressz = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+7C8+1A4+54");

                        memory.WriteFloat(addressx, x);
                        memory.WriteFloat(addressy, y);
                        memory.WriteFloat(addressz, z);
                    }
        }
        */
        #endregion
        #region DesignImplimentation

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
        #endregion

        private void p_menubar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void t_updatePlayer_Tick(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("rebirth_fantasy");
            uint DELETE = 0x00010000;
            uint READ_CONTROL = 0x00020000;
            uint WRITE_DAC = 0x00040000;
            uint WRITE_OWNER = 0x00080000;
            uint SYNCHRONIZE = 0x00100000;
            uint END = 0xFFF; //if you have Windows XP or Windows Server 2003 you must change this to 0xFFFF
            uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);

            int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);
            int processSize = GetObjectSize("12");

            if (p.Length > 0)
            {
                using (Memory memory = new Memory(p[0]))
                {
                    //Pull Character information
                    //Character Y
                    IntPtr address = memory.GetAddress("\"rebirth_fantasy.exe\"+AAFFC");
                    int playery = Convert.ToInt32(memory.ReadInt32(address));
                    l_playery.Text = Convert.ToString(playery);

                    //Character X
                    address = memory.GetAddress("\"rebirth_fantasy.exe\"+AAFF8");
                    int playerx = Convert.ToInt32(memory.ReadInt32(address));
                    l_playerx.Text = Convert.ToString(playerx);

                    //Health
                    address = memory.GetAddress("\"rebirth_fantasy.exe\"+000B9710+5D0");
                    int hp = Convert.ToInt32(memory.ReadInt32(address));
                    byte[] bytes = ConvertInt32ToByteArray(hp);                         
                    l_hp.Text = Convert.ToString(bytes[0]);

                    //Stamina
                    address = memory.GetAddress("\"rebirth_fantasy.exe\"+000B9710+5D0");
                    hp = Convert.ToInt32(memory.ReadInt32(address));
                    bytes = ConvertInt32ToByteArray(hp);
                    l_hp.Text = Convert.ToString(bytes[0]);

                    //Address Stamina


                    //Camera Y
                    //address = memory.GetAddress("\"Aok HD.exe\"+0013CF90");
                    //int camera_y = Convert.ToInt32(memory.ReadInt32(address));

                    ////Write to Game
                    ////Mouse X
                    //IntPtr a1 = memory.GetAddress("\"Wow.exe\"+0013D22C");
                    //memory.WriteInt32(a1, mouse_x);

                    ////Mouse Y
                    //IntPtr a2 = memory.GetAddress("\"Wow.exe\"+0013D230");
                    //memory.WriteInt32(a2, mouse_y);
                }
            }
        }

        public static byte[] ConvertInt32ToByteArray(Int32 I32)
        {
            return BitConverter.GetBytes(I32);
        }
    }
}
