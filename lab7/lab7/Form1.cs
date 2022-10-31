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

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string NL = Environment.NewLine;

        private void Step1Button_Click(object sender, EventArgs e)
        {
            // Создание массива данных
            int[] a = new int[100];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                a[i] = rnd.Next(100000, 999999);
                sum += a[i];
            }
            LogBox.Text = $"Данные (100 целых чисел) созданы. {NL} Общая сумма: {sum}. {NL}";
            // Сохранение даннных в двоичном файле
            FileStream fs = new FileStream("data.dat", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < 100; i++)
                bw.Write(a[i]);
            bw.Close();
            fs.Close();
            LogBox.Text += $"Данные сохранены в \"data.dat\". {NL}";
            // Сохранение данных в текстовом файле
            StreamWriter sw = File.CreateText("data.txt");
            for (int i = 99; i >= 0; i--)
                sw.WriteLine(a[i]);
            sw.Close();
            LogBox.Text += $"Данные сохранены в \"data.txt\". {NL}";
            Step2Button.Show();
        }

        private void Step2Button_Click(object sender, EventArgs e)
        {
            // Чтение данных из бинарного файла
            FileStream fs = new FileStream("data.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] a = new int[0];
            int count = 0, sum = 0;
            try
            {
                while (true)
                {
                    int k = br.ReadInt32();
                    count++;
                    sum += k;
                    Array.Resize(ref a, count);
                    a[a.Length - 1] = k;
                }
            } 
            catch
            {
                LogBox.Text += $"Файл \"data.dat\" считан. {NL}";
            }
            finally
            {
                br.Close();
                fs.Close();
            }

            LogBox.Text += $"Всего {count} чисел, сумма равна {sum}. {NL}";
            LogBox.Text += $"a[0]={a[0]} a[{count - 1}]={a[count - 1]}. {NL}";
            Step3Button.Show();
        }

        private void Step3Button_Click(object sender, EventArgs e)
        {
            // Чтение данных из текстового файла
            StreamReader sr = File.OpenText("data.txt");
            int [] a = new int[0];
            int count = 0, sum = 0;
            while (true)
            {
                string str = sr.ReadLine();
                if (str == null) break;
                int k;
                if (int.TryParse(str, out k))
                {
                    count++;
                    sum += k;
                    Array.Resize(ref a, count);
                    a[a.Length - 1] = k;
                }
                else break;
            }
            sr.Close();
            LogBox.Text += $"Файл \"data.txt\" считан.{NL}";
            LogBox.Text += $"Всего {count} чисел, сумма равна {sum}. {NL}";
            LogBox.Text += $"a[0]={a[0]} a[{count - 1}]={a[count - 1]}. {NL}";
        }
    }
}
