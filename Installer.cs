using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace BitLauncher
{
    public partial class Installer : Form
    {
        public Installer()
        {
            InitializeComponent();
        }

        private void Installer_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string userName = Environment.UserName;
            //string targetPath = $@"C:\Users\{userName}\Chyppitau\BitLauncher";
            //string sourcePath = AppDomain.CurrentDomain.BaseDirectory;

            //if (!Directory.Exists(targetPath))
            //{
            //    Directory.CreateDirectory(targetPath);
            //}

            //try
            //{
            //    // Копируем все директории и файлы по "лесенке"
            //    CopyAllLevels(sourcePath, targetPath);

            //    // Проверяем, какие файлы находятся в целевой директории
            //    string[] files = Directory.GetFiles(targetPath);
            //    foreach (string file in files)
            //    {
            //        Console.WriteLine($"File in target path: {file}");
            //    }

            //    // Запуск .exe файла из целевой директории
            //    string exeFileName = "BitLauncher.exe";
            //    string exeFilePath = Path.Combine(targetPath, exeFileName);
            //    if (File.Exists(exeFilePath))
            //    {
            //        Console.WriteLine($"Found executable: {exeFilePath}");
            //        Process.Start(exeFilePath);
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Executable file not found: {exeFilePath}");
            //    }
            //}
            //catch (UnauthorizedAccessException ex)
            //{
            //    MessageBox.Show($"Access denied: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //}

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        //static void CopyAllLevels(string sourceDir, string targetDir)
        //{
        //    while (sourceDir != null && !Directory.Exists(Path.Combine(sourceDir, ".vs")))
        //    {
        //        try
        //        {
        //            CopyDirectory(sourceDir, targetDir);
        //        }
        //        catch (UnauthorizedAccessException)
        //        {
        //            // Пропустить директорию, если доступ запрещен
        //            Console.WriteLine($"Skipping directory due to access restrictions: {sourceDir}");
        //        }

        //        // Поднимаемся на уровень выше
        //        sourceDir = Directory.GetParent(sourceDir)?.FullName;

        //        if (sourceDir == null)
        //        {
        //            // Если достигли корневой директории, прекращаем цикл
        //            break;
        //        }

        //        // Меняем целевой путь на уровень выше
        //        targetDir = Directory.GetParent(targetDir)?.FullName;

        //        if (targetDir == null)
        //        {
        //            // Если достигли корневой директории, прекращаем цикл
        //            break;
        //        }

        //        if (!Directory.Exists(targetDir))
        //        {
        //            Directory.CreateDirectory(targetDir);
        //        }
        //    }
        //}

        //static void CopyDirectory(string sourceDir, string targetDir)
        //{
        //    // Создаем целевую директорию, если она не существует
        //    if (!Directory.Exists(targetDir))
        //    {
        //        Directory.CreateDirectory(targetDir);
        //    }

        //    // Копируем все файлы из исходной директории в целевую директорию
        //    foreach (string file in Directory.GetFiles(sourceDir))
        //    {
        //        string fileName = Path.GetFileName(file);
        //        string destFile = Path.Combine(targetDir, fileName);
        //        try
        //        {
        //            File.Copy(file, destFile, true);
        //            Console.WriteLine($"Copied file: {destFile}");
        //        }
        //        catch (UnauthorizedAccessException)
        //        {
        //            // Пропустить файл, если доступ запрещен
        //            Console.WriteLine($"Skipping file due to access restrictions: {file}");
        //        }
        //    }

        //    // Рекурсивно копируем все поддиректории
        //    foreach (string directory in Directory.GetDirectories(sourceDir))
        //    {
        //        string dirName = Path.GetFileName(directory);
        //        string targetSubDir = Path.Combine(targetDir, dirName);
        //        CopyDirectory(directory, targetSubDir);
        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
