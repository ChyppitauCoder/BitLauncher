using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitLauncher
{
    public partial class KeyCheckScene : Form
    {
        public KeyCheckScene()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Play the game! Paste in the Input Box! To get code you need to read ReadMe.txt on English language without translate. Now Just Play In my Game to fun!");
            try
            {
                Process.Start(new ProcessStartInfo
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

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "BIT-69hbs9108CH097ee-NO2c4m-VirusCheck")
            {
                MessageBox.Show("True Code! Waiting for the forcasts...");
                await Task.Delay(5000);
                MessageBox.Show("Forcasts Founded!");
                await Task.Delay(1000);
                MessageBox.Show("You are an Idiot. You got scammed! Waiting for the virus! HAHAHA!");

                await Task.Delay(4000);
                Virus_scene virus = new Virus_scene();
                virus.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Code!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
