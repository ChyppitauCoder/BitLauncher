using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BitLauncher
{
    public partial class Screem : Form
    {
        public Screem()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            hWnd = FindWindow("Screem", null);

            if (hWnd == IntPtr.Zero)
            {
                Console.WriteLine("Undefined");
                return;
            }

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10; 
            timer.Tick += new EventHandler(MoveWindow);
            timer.Start();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private int stepX = 5;
        private int stepY = 5; 
        private IntPtr hWnd;  
        private System.Windows.Forms.Timer timer;  

        private void MoveWindow(object sender, EventArgs e)
        {
            if (hWnd == IntPtr.Zero) return;

            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            GetWindowRect(hWnd, out RECT rect);

            int newX = rect.Left + stepX;
            int newY = rect.Top + stepY;

            if (newX < 0 || newX + (rect.Right - rect.Left) > screenBounds.Width)
            {
                stepX = -stepX; // Отражаем по оси X
                newX = rect.Left + stepX;
            }

            if (newY < 0 || newY + (rect.Bottom - rect.Top) > screenBounds.Height)
            {
                stepY = -stepY;
                newY = rect.Top + stepY;
            }

            MoveWindow(hWnd, newX, newY, rect.Right - rect.Left, rect.Bottom - rect.Top, true);
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
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

        private void Screem_Load(object sender, EventArgs e)
        {

        }
    }
}
