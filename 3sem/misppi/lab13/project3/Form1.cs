namespace project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    textBox1.Text = dialog.SelectedPath;

                    PathName[] files = Directory
                        .GetFiles(dialog.SelectedPath)
                        .Select(fullPath => new PathName { Name = fullPath.Split(@"\")[^1], FullPath = fullPath })
                        .ToArray();

                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(files);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = dialog.SelectedPath;
                }
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == MouseButtons && listBox1.SelectedIndex != -1)
            {
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy);
            }
        }

        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            PathName data = (PathName)e.Data.GetData(typeof(PathName).ToString());
            string fileFrom = data.FullPath;
            string fileTo = textBox2.Text + @"\" + data.Name;
            fileTo = textBox2.Text + @"\" + (File.Exists(fileTo) ? "Another" : String.Empty) + data.Name;
            File.Move(fileFrom, fileTo);

            if (textBox1.Text != textBox2.Text)
                listBox1.Items.Remove(data);
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}