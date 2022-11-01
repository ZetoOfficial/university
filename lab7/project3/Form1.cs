using Microsoft.VisualBasic.FileIO;
using System.Text;
using LINQtoCSV;

class Student
{
    [CsvColumn(Name = "№")]
    public int StudNumber { get; set; }
    [CsvColumn(Name = "ФИО студента")]
    public string StudFIO { get; set; }
    [CsvColumn(Name = "1 работа")]
    public int Work1 { get; set; }
    [CsvColumn(Name = "2 работа")]
    public int Work2 { get; set; }
    [CsvColumn(Name = "3 работа")]
    public int Work3 { get; set; }
    [CsvColumn(Name = "4 работа")]
    public int Work4 { get; set; }
    [CsvColumn(Name = "5 работа")]
    public int Work5 { get; set; }
    [CsvColumn(Name = "6 работа")]
    public int Work6 { get; set; }
    [CsvColumn(Name = "7 работа")]
    public int Work7 { get; set; }
    [CsvColumn(Name = "8 работа")]
    public int Work8 { get; set; }
    [CsvColumn(Name = "9 работа")]
    public int Work9 { get; set; }
    [CsvColumn(Name = "10 работа")]
    public int Work10 { get; set; }
    [CsvColumn(Name = "11 работа")]
    public int Work11 { get; set; }
    [CsvColumn(Name = "12 работа")]
    public int Work12 { get; set; }
    [CsvColumn(Name = "13 работа")]
    public int Work13 { get; set; }
    [CsvColumn(Name = "14 работа")]
    public int Work14 { get; set; }
    [CsvColumn(Name = "Бонус")]
    public int Bonus { get; set; }
}

class StudentResult : Student
{
    [CsvColumn(Name = "Результат")]
    public double Result { get; set; }

    public StudentResult(int StudNumber, string StudFIO, int Work1, double result) : base()
    {
        this.Result = result;
    }
}

namespace project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = false;
        }

        string NL = Environment.NewLine;
        public string UserFileName { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UserFileName = openFileDialog1.FileName;

                CsvFileDescription inputFileDescription = new CsvFileDescription {SeparatorChar = ';', FirstLineHasColumnNames = true};
                CsvContext cc = new CsvContext();
                IEnumerable<Student> students = cc.Read<Student>(UserFileName, inputFileDescription);
                List<StudentResult> studentResults = new List<StudentResult>();

                foreach (var student in students)
                {
                    textBox1.Text += $"{student.StudNumber} {student.StudFIO} {NL}";
                    //studentResults.Add(new StudentResult(student));
                }
            }
        }
    }
}