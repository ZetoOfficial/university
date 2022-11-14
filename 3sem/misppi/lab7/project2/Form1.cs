namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = false;
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.WordWrap = false;
        }
        
        string NL = Environment.NewLine;
        
        public string UserFileName { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UserFileName = openFileDialog1.FileName; 
                string[] fileText = File.ReadAllLines(UserFileName);
                textBox1.Text = String.Join(NL, fileText);
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] fileText = File.ReadAllLines(UserFileName);
            textBox1.Text = String.Join(NL, fileText);
            var rowCount = fileText.Length;
            var notEmptyRowCount = fileText.Where(el => !String.IsNullOrEmpty(el)).Count();
            var minLength = fileText.Where(el => !String.IsNullOrEmpty(el)).Min(x => x.Length);
            var shortestLine = fileText.Where(x => x.Length == minLength).ToList().First();
            var maxLength = fileText.Max(x => x.Length);
            var longestLine = fileText.Where(x => x.Length == maxLength).ToList().Last();
            var medianLine = Median(fileText);
            textBox2.Text = $"Х »м€ считанного файла: {Path.GetFileName(UserFileName)}{NL}";
            textBox2.Text += $"Х  оличество строк: {rowCount}{NL}";
            textBox2.Text += $"Х  оличество непустых строк: {notEmptyRowCount}{NL}";
            textBox2.Text += $"Х —ама€ коротка€ непуста€ строка: {shortestLine}{NL}";
            textBox2.Text += $"Х —ама€ длинна€ непуста€ строка: {longestLine}{NL}";
            textBox2.Text += $"Х ћедиана - строка в середине текста.: {medianLine}{NL}";
            button3.Enabled = true;
        }

        string Median(string[] xs)
        {
            return xs[xs.Length / 2];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] fileText = File.ReadAllLines(UserFileName);
            var ignoreSigns = new[] { " ", ".", ",", "!", "?", "\"", "'", "\t", "\n" };
            var cleanFileText = fileText.Except(ignoreSigns);
            

            var wordsCount = fileText.Length;
            var maxLength = fileText.Max(x => x.Length);
            var longestWords = fileText.Where(el => el.Length == maxLength);

            List<int> wordsLenCountArray = new List<int>();
            foreach (var word in fileText)
            {
                if (!wordsLenCountArray.Contains(word.Length))
                    wordsLenCountArray.Add(word.Length);
            }
            wordsLenCountArray.Sort();

            textBox2.Text = $"Х »м€ считанного файла: {Path.GetFileName(UserFileName)}{NL}";
            textBox2.Text += $"Х  оличество слов: {wordsCount}{NL}";
            textBox2.Text += $"Х ƒлина самого длинного слова: {maxLength}{NL}";
            textBox2.Text += $"Х ѕервое и последнее слово текста имеющих самую большую длину: {longestWords.First()} и {longestWords.First()}{NL}";
            foreach (var wordLen in wordsLenCountArray)
            {
                textBox2.Text += $" {wordLen} | {fileText.Where(el => el.Length == wordLen).Count()} {NL}";
            }
        }
    }
}