using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace kp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл");
            }
        }
        string[] path;
        string name;
        string path_new;
        StreamWriter sw;
        private void Create_Click(object sender, EventArgs e)
        {
            path_new = "";
            path = Path.Text.Split(' ', '/', '\\');
            name = Text_name.Text;
            foreach (string s in path)
            {
                path_new += s + "\\";
            }
            path_new += $"{name}.txt";
            try
            {
                sw = new StreamWriter($"{path_new}");
                sw.Close();
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Вы указали неверный путь файл ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                sw = new StreamWriter($"{path_new}");
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
            catch { }
        }
        private void open_file_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        string fileText;



        private void open_file_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            path_new = openFileDialog1.FileName;
            fileText = File.ReadAllText(path_new);
            textBox1.Text = fileText;
            timer1.Start();
        }
        string str;
        StreamReader sr;
        private void rep_Click(object sender, EventArgs e)
        {
            try
            {
                sr = new StreamReader($"{path_new}");
                str = sr.ReadToEnd();
                str = str.Replace(textBox2.Text, replace.Text);
                sr.Close();
                textBox1.Text = str;
            }
            catch { }
        }

        int index;
        private void registr_click_Click(object sender, EventArgs e)
        {
            try
            {
                sr = new StreamReader($"{path_new}");
                str = sr.ReadToEnd();
                if (radioButton1.Checked)
                {
                    if (Registr.Text.Length > 0)
                    {
                        str = str.Replace(Registr.Text, Registr.Text.ToUpper());
                    }
                    if (checkBox1.Checked)
                    {
                        str = str.Replace(str, str.ToUpper());
                    }
                }
                else
                {
                    if (Registr.Text.Length > 0)
                        str = str.Replace(Registr.Text, Registr.Text.ToLower());
                    if (checkBox1.Checked)
                    {
                        str = str.Replace(str, str.ToLower());
                    }
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл");
            }
            textBox1.Text = str;
        }
        string[] numeric;
        int count;
        private void number_of_words_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                count = 0;
                sr = new StreamReader($"{path_new}");
                str = sr.ReadToEnd();
                numeric = str.Split();
                count = numeric.Where(w => w.Contains(textBox3.Text)).Count();
                MessageBox.Show($"{count}");
                sr.Close();
                timer1.Stop();
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл");
            }
        }
        private void Count_line_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                count = 0;
                StreamReader sr = new StreamReader($"{path_new}");
                string[] lines = File.ReadAllLines($"{path_new}");
                while (sr.ReadLine() != null)
                {
                    count++;
                }
                MessageBox.Show($"{count}");
                sr.Close();
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл");
            }
        }

        private void Write_start_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new StreamWriter($"{path_new}");
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл");
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Укажите слово или символ котрое заменяете";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Укажите слово или символ котрое заменяете")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void replace_Enter(object sender, EventArgs e)
        {
            if (replace.Text == "Укажите слово или символ на котрое заменяете")
            {
                replace.Clear();
                replace.ForeColor = Color.Black;
            }
        }

        private void replace_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(replace.Text))
            {
                replace.Text = "Укажите слово или символ на котрое заменяете";
                replace.ForeColor = Color.Black;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите текст")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Введите текст";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void Path_Enter(object sender, EventArgs e)
        {
            if (Path.Text == "Укажите полный путь для блокнота")
            {
                Path.Clear();
                Path.ForeColor = Color.Black;
            }
        }

        private void Text_name_Enter(object sender, EventArgs e)
        {
            if (Text_name.Text == "Укажите имя файла")
            {
                Text_name.Clear();
                Text_name.ForeColor = Color.Black;
            }
        }

        private void Text_name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Text_name.Text))
            {
                Text_name.Text = "Укажите имя файла";
                Text_name.ForeColor = Color.Black;
            }
        }

        private void Path_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Path.Text))
            {
                Path.Text = "Укажите полный путь для блокнота";
                Path.ForeColor = Color.Black;
            }
        }

        private void Registr_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Registr.Text))
            {
                Registr.Text = "Укажите слово которое вы хотите заменить";
                Registr.ForeColor = Color.Black;
            }
        }

        private void Registr_Enter(object sender, EventArgs e)
        {
            if (Registr.Text == "Укажите слово которое вы хотите заменить")
            {
                Registr.Clear();
                Registr.ForeColor = Color.Black;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Укажите слово, чтобы узнать кол-во повторений")
            {
                textBox3.Clear();
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Укажите слово, чтобы узнать кол-во повторений";
                textBox3.ForeColor = Color.Black;
            }
        }
    }
}
