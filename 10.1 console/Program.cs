using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_console
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("\n\n__________________t1__________________");
            DirectoryInfo info_t1 = new DirectoryInfo($"{pathTemp}\\t1");
            Console.WriteLine($"Путь до папки: {info_t1.FullName}");
            Console.WriteLine($"Дата создания: {info_t1.CreationTime}");
            Console.WriteLine($"Атрибуты: {info_t1.Attributes}");
            Console.WriteLine($"Путь до папки: {info_t1.Root}");
            FileInfo _t2 = new FileInfo($"{pathTemp}\\All\\t2.txt");
            Console.WriteLine("\n\n__________________t2__________________");
            DirectoryInfo info_t2 = new DirectoryInfo($"{pathTemp}\\t2");
            Console.WriteLine($"Путь до папки: {info_t2.FullName}");
            Console.WriteLine($"Дата создания: {info_t2.CreationTime}");
            Console.WriteLine($"Атрибуты: {info_t2.Attributes}");
            Console.WriteLine($"Путь до папки: {info_t2.Root}");
            FileInfo _t3 = new FileInfo($"{pathTemp}\\All\\t3.txt");
            Console.WriteLine("\n\n__________________t3__________________");
            DirectoryInfo info_t3 = new DirectoryInfo($"{pathTemp}\\t3");
            Console.WriteLine($"Путь до папки: {info_t3.FullName}");
            Console.WriteLine($"Дата создания: {info_t3.CreationTime}");
            Console.WriteLine($"Атрибуты: {info_t3.Attributes}");
            Console.WriteLine($"Путь до папки: {info_t3.Root}");
            System.IO.Directory.CreateDirectory(pathTemp);
            Console.WriteLine("Создана директория Temp");
            System.IO.Directory.CreateDirectory(K1);
            Console.WriteLine("Создана директория K1");
            System.IO.Directory.CreateDirectory(K2);
            Console.WriteLine("Создана директория K2");
            using (StreamWriter sw = new StreamWriter(t1, false))
            {
                Console.WriteLine("Создан файл t1.txt");
                sw.Write("Пахоменко Владислав Васильевич, 2004 года рождения, место жительства г. Владимир");
            }
            using (StreamWriter sw = new StreamWriter(t2, false))
            {
                Console.WriteLine("Создан файл t2.txt");
                sw.Write("Пахоменко Василий Васильевич, 1976 года рождения, место жительства г.Владимир");
            }
            using (StreamWriter sw = new StreamWriter(t3, false))
            {
                Console.WriteLine("Создан файл t3.txt");
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
            Console.WriteLine("Папка ALL содержит следующие файлы:");
            foreach (var item in allfiles)
            {
                Console.WriteLine(item);
            }
            DirectoryInfo info_all = new DirectoryInfo($"{pathTemp}\\All");
            Console.WriteLine("\n\n__________________All__________________");
            Console.WriteLine($"Путь до папки: {info_all.FullName}");
            Console.WriteLine($"Дата создания: {info_all.CreationTime}");
            Console.WriteLine($"Атрибуты: {info_all.Attributes}");
            Console.WriteLine($"Корень: {info_all.Root}");
        }
    }
}
