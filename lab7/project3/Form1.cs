using Microsoft.VisualBasic.FileIO;
using System.Text;
using LINQtoCSV;

class Student
{
    [CsvColumn(Name = "�")]
    public int StudNumber { get; set; }
    [CsvColumn(Name = "��� ��������")]
    public string StudFIO { get; set; }
    [CsvColumn(Name = "1 ������")]
    public int Work1 { get; set; }
    [CsvColumn(Name = "2 ������")]
    public int Work2 { get; set; }
    [CsvColumn(Name = "3 ������")]
    public int Work3 { get; set; }
    [CsvColumn(Name = "4 ������")]
    public int Work4 { get; set; }
    [CsvColumn(Name = "5 ������")]
    public int Work5 { get; set; }
    [CsvColumn(Name = "6 ������")]
    public int Work6 { get; set; }
    [CsvColumn(Name = "7 ������")]
    public int Work7 { get; set; }
    [CsvColumn(Name = "8 ������")]
    public int Work8 { get; set; }
    [CsvColumn(Name = "9 ������")]
    public int Work9 { get; set; }
    [CsvColumn(Name = "10 ������")]
    public int Work10 { get; set; }
    [CsvColumn(Name = "11 ������")]
    public int Work11 { get; set; }
    [CsvColumn(Name = "12 ������")]
    public int Work12 { get; set; }
    [CsvColumn(Name = "13 ������")]
    public int Work13 { get; set; }
    [CsvColumn(Name = "14 ������")]
    public int Work14 { get; set; }
    [CsvColumn(Name = "�����")]
    public int Bonus { get; set; }
}

class StudentResult : Student
{
    [CsvColumn(Name = "���������")]
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