namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disableComboBox.Checked) return;
            try
            {
                var data = comboBox1.Text.Split("*").Select(x => Convert.ToInt32(x)).ToArray();
                this.Height = data[1];
                this.Width = data[0];
            } catch {}
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                switch (((RadioButton)sender).Name)
                {
                    case "redBttn": { this.BackColor = Color.Red; break; }
                    case "blueBttn": { this.BackColor = Color.Blue; break; }
                    case "greenBttn": { this.BackColor = Color.Green; break; }
                    case "grayBttn": { this.BackColor = Color.Gray; break; }
                    case "whiteBttn": { this.BackColor = Color.White; break; }
                    case "yellowBttn": { this.BackColor = Color.Yellow; break; }
                }
            }
        }

        private void disableRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            redBttn.AutoCheck = !disableRadioBox.Checked;
            blueBttn.AutoCheck = !disableRadioBox.Checked;
            greenBttn.AutoCheck = !disableRadioBox.Checked;
            grayBttn.AutoCheck = !disableRadioBox.Checked;
            whiteBttn.AutoCheck = !disableRadioBox.Checked;
            yellowBttn.AutoCheck = !disableRadioBox.Checked;
        }
        
        private bool validateInput(string text, char newChar)
        {
            var allowSigns = new List<Char>() { ',' };
            int charCount = text.Where(e1 => allowSigns.Contains(e1)).ToArray().Length;

            var backSpace = (char)8;
            var maxAllowSignsCountInText = 1;
            if (newChar == backSpace || Char.IsDigit(newChar) || !Char.IsDigit(newChar) && text.Length == 0 && newChar == '-' || !Char.IsDigit(newChar) && allowSigns.Contains(newChar) && charCount < maxAllowSignsCountInText) return true;
            return false;
        }

        private void добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0) throw new Exception("need content in textBox1");
                listBox1.Items.Add(double.Parse(textBox1.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char newChar = e.KeyChar;
            e.Handled = !validateInput(textBox1.Text, newChar);
        }

        private void fromListBox1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else {
                MessageBox.Show("Элемент не выбран");
            }
        }

        private void изListBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Элемент не выбран");
            }
        }

        private void произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var first4ByCondition = listBox1.Items.OfType<double>().Where(x => (x > 0) && ((int)x != x) && (int.Parse(x.ToString()[^1].ToString()) % 2 != 0)).Select(Convert.ToDouble);

            if (first4ByCondition.Count() == 4)
            {
                listBox2.Items.Clear(); 
                listBox2.ClearSelected();
                listBox2.Items.AddRange(first4ByCondition.Select(x => x.ToString()).ToArray());

                MessageBox.Show("Произведение таких чисел = " + first4ByCondition.Aggregate(1.0, (x, y) => x * y).ToString("0.#######"));
            }
            else
            {
                MessageBox.Show("Таких чисел в количестве 4 не нашлось");
            }
        }

        private void среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double agr = 1.0;
            var numbers = listBox1.Items.OfType<double>().Where(x => x > 0);
            foreach (var i in numbers)
                agr *= i - (int)i;
            var ans = Math.Pow(agr, 1.0 / numbers.Count());
            listBox2.Items.Add(ans);
        }

        private void добавитьСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Length == 0) throw new Exception("need content in textBox2");
                listBox3.Items.AddRange(textBox2.Lines);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!");
            }
        }

        private void удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
            else
            {
                MessageBox.Show("Элемент не выбран");
            }
        }

        private void найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.Items.Count == 0) throw new Exception("need content in ListBox3");
                var dataByConditionSortedLen = listBox3.Items.OfType<string>().OrderBy(x => x.Length);
                MessageBox.Show($"{dataByConditionSortedLen.Last()}\n{dataByConditionSortedLen.First()}", "Текст, составленный из строк максимальной и минимальной длины");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!");
            }
        }

        static bool IsPalindrom(string str)
        {
            if (str == null) throw new ArgumentNullException("str");
            str = str.ToLower().Replace(" ", string.Empty);
            return IsPalindromInternal(str);
        }
        static bool IsPalindromInternal(string str)
        {
            if (str.Length == 1 || string.IsNullOrEmpty(str)) return true;
            if (!str[0].Equals(str[str.Length - 1])) return false;
            return IsPalindromInternal(str.Substring(1, str.Length - 2));
        }
        private void найтиПалиндромыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.Items.Count == 0) throw new Exception("need content in ListBox3");
                var data = listBox3.Items.OfType<string>().Where(x => IsPalindrom(x)).First();
                MessageBox.Show(data.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Alt) && (e.KeyCode == Keys.I))
            {
                this.Controls.Clear();
                InitializeComponent();
            }
            else if ((e.Modifiers == Keys.Alt) && (e.KeyCode == Keys.X))
            {
                this.Close();
            }
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "ComboBox, позволяющий выбрать размер формы";
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Переключатель цвета формы";
        }

        private void disableComboBox_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Выключатель заперещения изменений в ComboBox";
        }

        private void disableRadioBox_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Выключатель заперещения изменений переключателя в RadioButton";
        }

        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Меню формы MenuStrip";
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "ListBox1 для MenuStrip";
        }

        private void listBox2_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "ListBox2 для MenuStrip";
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "TextBox1 для MenuStrip";
        }

        private void listBox3_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "ListBox3 для ContextMenuStrip";
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "TextBox2 для ContextMenuStrip";
        }
    }
}