using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _0001
{
    public partial class Form1 : Form
    {
        private Process notepadProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenNotepad_Click(object sender, EventArgs e)
        {
            try
            {
                // Спробуємо запустити "Блокнот"
                notepadProcess = Process.Start("notepad.exe");

                if (notepadProcess != null)
                {
                    MessageBox.Show("Програма 'Блокнот' запущена.");
                }
                else
                {
                    MessageBox.Show("Помилка при запуску 'Блокнот'.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка: " + ex.Message);
            }
        }

        private void CloseNotepad_Click(object sender, EventArgs e)
        {
            if (notepadProcess != null && !notepadProcess.HasExited)
            {
                notepadProcess.CloseMainWindow(); // Закриваємо головне вікно
                notepadProcess.WaitForExit();
                notepadProcess.Close();
                notepadProcess.Dispose();
                MessageBox.Show("Програма 'Блокнот' закрита.");
            }
            else
            {
                MessageBox.Show("Програма 'Блокнот' не запущена.");
            }
        }
    }
}