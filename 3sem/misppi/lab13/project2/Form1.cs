using System.Drawing.Drawing2D;
using System.Text;
using System.Reflection;
using System.IO;

namespace project2
{
    public partial class Form1 : Form
    {
        string NL = Environment.NewLine;
        bool CTRL = false;
        List<string> fileLines = new();
        
        MouseButtons mouseButtons;
        LinearGradientBrush linGrBrush;

        public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
            KeyPreview = true;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, gradientPanel, new object[] { true });
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            ListBoxDragDrop(listBox1, e);
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
                if (i == 0) logBox.Text = $"Перемещены выделенные строки из второго листбокса в первый{NL}{logBox.Text}";;
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SetSelected(i, false);
            }
        }

        private void ReadFromFile_DragDrop(object sender, DragEventArgs e)
        {
            using FileStream stream = new("Lab12.txt", FileMode.Open);
            using StreamReader reader = new(stream, Encoding.Default);

            string allText = reader.ReadToEnd();
            string[] masLines = allText.Split('\n');

            if (e.Data.GetData(typeof(ListBox)) == listBox1)
            {
                listBox1.Items.Clear();
                logBox.Text = $"Добавлен текст в 1 листбокс{NL}{logBox.Text}";
            }
            else if (e.Data.GetData(typeof(ListBox)) == listBox2)
            {
                listBox2.Items.Clear();
                logBox.Text = $"Добавлен текст вo 2 листбокс{NL}{logBox.Text}";
            }

            for (int i = 0; i < masLines.Length; i++)
            {
                fileLines.Add(masLines[i]);
                if (e.Data.GetData(typeof(ListBox)) == listBox1)
                    listBox1.Items.Add(fileLines[i]);
                else if (e.Data.GetData(typeof(ListBox)) == listBox2)
                    listBox2.Items.Add(fileLines[i]);
            }
        }

        private void SaveToFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(ListBox)) == listBox1)
                logBox.Text = $"Сохранен текст из 1 листбокса{NL}{logBox.Text}";
            else if (e.Data.GetData(typeof(ListBox)) == listBox2)
                logBox.Text = $"Сохранен текст из 2 листбокса{NL}{logBox.Text}";

            File.Delete("Lab12.txt");
            using FileStream stream = new("Lab12.txt", FileMode.OpenOrCreate);  
            using StreamWriter writer = new(stream, Encoding.Default);
            if (e.Data.GetData(typeof(ListBox)) == listBox1)
                for (int i = 0; i < listBox1.Items.Count; i++)
                    writer.WriteLine(listBox1.Items[i].ToString());
            else if (e.Data.GetData(typeof(ListBox)) == listBox2)
                for (int i = 0; i < listBox2.Items.Count; i++)
                    writer.WriteLine(listBox2.Items[i].ToString());
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)) || e.Data.GetDataPresent(typeof(TextBox)) || e.Data.GetDataPresent(typeof(Panel)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(sender, DragDropEffects.Link);
        }

        private void saveToFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Link;
        }
        
        private void readFromFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Link;
        }
        
        private void newWordBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Link;
        }
        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)) || e.Data.GetDataPresent(typeof(TextBox)) || e.Data.GetDataPresent(typeof(Panel)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Link;
        }
        private void gradientPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Link;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(ListBox)) == listBox1)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                    listBox1.Items.Add(listBox1.SelectedItems[i]);
                logBox.Text = $"Выделенные строки из первого листбокса дублируются в конец списка{NL}{logBox.Text}";;
            }
            else if (e.Data.GetData(typeof(ListBox)) == listBox2)
            {
                for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
                    listBox2.Items.Remove(listBox2.SelectedItems[i]);
                logBox.Text = $"Выделенные строки из второго листбокса удаляются{NL}{logBox.Text}";;
            }
        }
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            ListBoxDragDrop(listBox2, e);
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
                if (i == 0)
                    logBox.Text = $"Перемещены выделенные строки из первого листбокса во второй{NL}{logBox.Text}";;
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, false);
            }
        }

        private void ListBoxDragDrop(ListBox listBox, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(TextBox)) == newWordBox)
            {
                if ((mouseButtons == MouseButtons.Left || mouseButtons == MouseButtons.Right) && CTRL)
                {
                    CTRL = false;
                    listBox.Items.Add(newWordBox.Text);
                    logBox.Text = $"Текст из текстбокса копирован{NL}{logBox.Text}";;
                }
                else if (mouseButtons == MouseButtons.Left)
                {
                    string temp = newWordBox.Text;
                    List<string> strings = new List<string>();

                    for (int i = listBox.Items.Count - 1; i >= 0; i--)
                    {
                        strings.Add(listBox.Items[i].ToString());
                    }
                    strings.Add(temp);
                    listBox.Items.Clear();
                    for (int i = strings.Count - 1; i >= 0; i--)
                        listBox.Items.Add(strings[i].ToString());
                    newWordBox.Text = "";
                    logBox.Text = $"Текст из текстбокса переноситься в начало листбокса{NL}{logBox.Text}";;
                }
                else if (mouseButtons == MouseButtons.Right)
                {
                    listBox.Items.Add(newWordBox.Text);
                    newWordBox.Text = "";
                    logBox.Text = $"Текст из текстбокса переноситься в конец листбокса{NL}{logBox.Text}";;
                }
            }
            else if (e.Data.GetData(typeof(Panel)) == gradientPanel)
            {
                listBox.BackColor = linGrBrush.LinearColors[1];
                logBox.Text = $"Цвет листбокса изменен{NL}{logBox.Text}";;
            }

        }

        private void NewWordBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(ListBox)) == listBox1)
                TextBoxDragDrop(listBox1);
            else if (e.Data.GetData(typeof(ListBox)) == listBox2)
                TextBoxDragDrop(listBox2);
        }

        private void TextBoxDragDrop(ListBox listBox)
        {
            string temp = newWordBox.Text;
            List<string> strings = new();

            newWordBox.Text = listBox.Items[0].ToString();
            for (int i = listBox.Items.Count - 1; i > 0; i--)
            {
                strings.Add(listBox.Items[i].ToString());
            }
            strings.Add(temp);
            listBox.Items.Clear();
            for (int i = strings.Count - 1; i >= 0; i--)
                listBox.Items.Add(strings[i].ToString());
            logBox.Text = $"Обмен первой строки и строки в текстбокс{NL}{logBox.Text}";;
        }
        private void GradientPanel_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetData(typeof(ListBox)) == listBox1)
                    listBox1.ForeColor = linGrBrush.LinearColors[1];
                else if (e.Data.GetData(typeof(ListBox)) == listBox2)
                    listBox2.ForeColor = linGrBrush.LinearColors[1];
                logBox.Text = $"Изменен цвет текста листбокса{NL}{logBox.Text}";
            }
            catch {}
        }

        private void ListBox2_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(sender, DragDropEffects.Link);
        }
        private void NewWordBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseButtons = e.Button;
            DoDragDrop(sender, DragDropEffects.Link);
        }
        private void GradientPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(sender, DragDropEffects.Link);
        }

        private void GradientPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 0) return;
            try
            {
                linGrBrush = new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(e.X, 0),
                    Color.FromArgb(255, 0, 0),
                    Color.FromArgb(255 * (gradientPanel.Width - e.X) / gradientPanel.Width, 0, 255 * e.X / gradientPanel.Width)
                );
                gradientPanel.BackgroundImage = new Bitmap(gradientPanel.Width, gradientPanel.Height);
                using (Graphics g = Graphics.FromImage(gradientPanel.BackgroundImage))
                {
                    g.FillRectangle(linGrBrush, 0, 0, e.X, gradientPanel.Height);
                    g.FillRectangle(new SolidBrush(BackColor), e.X, 0, gradientPanel.Width - e.X, gradientPanel.Height);
                }
                gradientPanel.Invalidate();
            }
            catch { }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control) CTRL = true;
        }
    }
}