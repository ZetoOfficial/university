class Student
{
    public int StudNumber { get; set; }
    public string StudFIO { get; set; }
    public int[] Score { get; set; }

    public Student(int studNumber, string studFIO, int[] score)
    {
        StudNumber = studNumber;
        StudFIO = studFIO;
        Score = score;
    }
}

class StudentResult : Student
{
    public double Result { get; set; }

    public StudentResult(int studNumber, string studFIO, int[] score, double result) : base(studNumber, studFIO, score)
    {
        Result = result;
    }
}
namespace project3 {

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
        private List<Student> students = new List<Student>();
        private List<StudentResult> studentsWithResult = new List<StudentResult>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                UserFileName = openFileDialog1.FileName;

            using (StreamReader sr = new StreamReader(UserFileName))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(";").ToArray();
                    students.Add(new Student(int.Parse(data[0]), data[1], data.Skip(2).Select(x => int.Parse(x == "" ? "0" : x)).ToArray()));
                }
            }

            using (StreamWriter sw = new StreamWriter("Result_МиСППИ.csv"))
            {
                sw.WriteLine("№;ФИО студента;1 работа;2 работа;3 работа;4 работа;5 работа;6 работа;7 работа;8 работа;9 работа;10 работа;11 работа;12 работа;13 работа;14 работа;Бонус;Итого");
                for (int i = 0; i < students.Count; i++)
                {
                    double score = 0.0;
                    for (int j = 0; j < students[i].Score.Length; j++)
                    {
                        score += students[i].Score[j];

                        if (students[i].Score[j] >= 1 && students[i].Score[j] <= 5)
                            score += 0.5 - students[i].Score[j] / 10 + 0.1;
                    }
                    string scores = String.Join(";", students[i].Score);
                    sw.WriteLine($"{students[i].StudNumber};{students[i].StudFIO};{scores};{Math.Round(score, 2)}");
                    studentsWithResult.Add(new StudentResult(students[i].StudNumber, students[i].StudFIO, students[i].Score, Math.Round(score, 2)));
                }
            }
        }
    }
}