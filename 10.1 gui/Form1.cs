using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pathTemp = "C:\\Temp";
            Directory.Delete(pathTemp, true);
            string K1 = pathTemp + "\\K1";
            string K2 = pathTemp + "\\K2";
            string t1 = K1 + "\\t1.txt";
            string t2 = K1 + "\\t2.txt";
            string t3 = K2 + "\\t3.txt";
            string ALL = pathTemp + "\\ALL";
            FileInfo _t1 = new FileInfo($"{pathTemp}\\All\\t1.txt");
            FileInfo _t2 = new FileInfo($"{pathTemp}\\All\\t2.txt");
            FileInfo _t3 = new FileInfo($"{pathTemp}\\All\\t3.txt");
            System.IO.Directory.CreateDirectory(pathTemp);
            textBox1.Text += "Создана директория Temp" + Environment.NewLine;
            System.IO.Directory.CreateDirectory(K1);
            textBox1.Text += "Создана директория K1" + Environment.NewLine;
            System.IO.Directory.CreateDirectory(K2);
            textBox1.Text += "Создана директория K2" + Environment.NewLine;
            using (StreamWriter sw = new StreamWriter(t1, false))
            {
                textBox1.Text += "Создан файл t1.txt" + Environment.NewLine;
                sw.Write("Пахоменко Владислав Васильевич, 2004 года рождения, место жительства г. Владимир");
            }
            using (StreamWriter sw = new StreamWriter(t2, false))
            {
                textBox1.Text += "Создан файл t2.txt" + Environment.NewLine;
                sw.Write("Пахоменко Василий Васильевич, 1976 года рождения, место жительства г.Владимир");
            }
            using (StreamWriter sw = new StreamWriter(t3, false))
            {
                textBox1.Text += "Создан файл t3.txt" + Environment.NewLine;
                using (StreamReader sr = new StreamReader(t1))
                {
                    string line1 = sr.ReadLine();
                    sw.WriteLine(line1);
                }
                using (StreamReader sr = new StreamReader(t2))
                {
                    string line2 = sr.ReadLine();
                    sw.WriteLine(line2);
                }
            }
            File.Move(t2, K2 + "\\t2.txt");
            File.Copy(t1, K2 + "\\t1.txt");
            Directory.Move(K2, ALL);
            Directory.Delete(K1, true);
            string[] allfiles = Directory.GetFiles(ALL);
            textBox1.Text += "Папка ALL содержит следующие файлы:" + Environment.NewLine;
            foreach (var item in allfiles)
            {
                textBox1.Text += item + Environment.NewLine;
            }
            DirectoryInfo info_all = new DirectoryInfo($"{pathTemp}\\All");
            textBox1.Text += "\n\n__________________All__________________";
            textBox1.Text += $"Путь до папки: {info_all.FullName}";
            textBox1.Text += $"Дата создания: {info_all.CreationTime}";
            textBox1.Text += $"Атрибуты: {info_all.Attributes}";
            textBox1.Text += $"Корень: {info_all.Root}";
        }
    }
}
