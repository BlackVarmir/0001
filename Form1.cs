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
                // �������� ��������� "�������"
                notepadProcess = Process.Start("notepad.exe");

                if (notepadProcess != null)
                {
                    MessageBox.Show("�������� '�������' ��������.");
                }
                else
                {
                    MessageBox.Show("������� ��� ������� '�������'.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� �������: " + ex.Message);
            }
        }

        private void CloseNotepad_Click(object sender, EventArgs e)
        {
            if (notepadProcess != null && !notepadProcess.HasExited)
            {
                notepadProcess.CloseMainWindow(); // ��������� ������� ����
                notepadProcess.WaitForExit();
                notepadProcess.Close();
                notepadProcess.Dispose();
                MessageBox.Show("�������� '�������' �������.");
            }
            else
            {
                MessageBox.Show("�������� '�������' �� ��������.");
            }
        }
    }
}