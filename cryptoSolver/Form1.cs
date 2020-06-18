using System;
using System.Collections;
using System.Windows.Forms;

namespace cryptoSolver
{
    public partial class MyFrom : Form
    {
        public MyFrom()
        {
            InitializeComponent();
            openFileDialog_load.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog_save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            obj_aes = new My_crypto();
            now = DateTime.Now;
        }
        My_crypto obj_aes;
        DateTime now;

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog_load.ShowDialog() == DialogResult.OK)
            {
                
                string filename = openFileDialog_load.FileName;
                ArrayList lines = new ArrayList();
                lines.AddRange(System.IO.File.ReadAllLines(filename));
                richTextBox_resource.Text = "";
                foreach (string line in lines)
                {
                    richTextBox_resource.AppendText(line + '\n');
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_save.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog_save.FileName;
                System.IO.File.AppendAllText(filename, richTextBox_result.Text);
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (radioButtonShifr.Checked)
            {
                richTextBox_result.Text = "";
                richTextBox_result.Text = obj_aes.encrypt(richTextBox_resource.Text);
                richTextBoxMessage.AppendText(now.ToShortTimeString() + " Зашифровано\n");
            }
            else if (radioButtonDeshifr.Checked)
            {
                richTextBox_result.Text = "";
                richTextBox_result.Text = obj_aes.decrypt(richTextBox_resource.Text);
                if (richTextBox_result.Text == "") richTextBoxMessage.AppendText(now.ToShortTimeString() + " Нельзя расшифровать незашифрованный текст\n");
                else richTextBoxMessage.AppendText(now.ToShortTimeString() + " Расшифровано\n");
            }
            else if (radioButtonCreateECP.Checked)
            {
                obj_aes.gen_sign(richTextBox_resource.Text);
                richTextBoxMessage.AppendText(now.ToShortTimeString() + " Подписано\n");
            }
            else if (radioButtonCheckECP.Checked)
            {
                bool a = obj_aes.ver_sign(richTextBox_resource.Text);
                if (a) richTextBoxMessage.AppendText(now.ToShortTimeString() + " Подпись верна\n");
                else richTextBoxMessage.AppendText(now.ToShortTimeString() + " Подпись неверна\n");
            }
            richTextBoxMessage.SelectionStart = richTextBoxMessage.Text.Length;
            richTextBoxMessage.ScrollToCaret();
            
        }
    }
}
