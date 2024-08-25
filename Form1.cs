using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace BitLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Panel aPanel = new Panel();
        Form2 Form2 = new Form2();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool is_virus_load = true;
        int clicked_times = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (is_virus_load)
            {
                KeyCheckScene check_key = new KeyCheckScene();
                check_key.Show();
            }
            else
            {
                MessageBox.Show("You Just Run This with Clear Version. Forcasts will be paid by this function. If you want to buy forcasts: +7 928-439-27-44 Sber. To run it free disable Clear Version by just program reload.");
            }
        }

        public void OpenNewPage()
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenNewPage();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://web.telegram.org/k/#@DiamondTapMasterBot",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии ссылки: " + ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            is_virus_load = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {  
            MessageBox.Show("Nope, enjoy english because school is coming soon :))))");
        }
    }
}
