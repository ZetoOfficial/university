using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ComponentModel;
using Aspose.Cells;
using Aspose.Words;

namespace project4._2
{
    public class FileManager
    {
        public List<Patient> Patients { get; set; }
        public string LastUsePath { get; set; }
        public string NL = Environment.NewLine;

        public FileManager()
        {
            Patients = new List<Patient>();
            LastUsePath = "";
        }
        public void FromCsv(string path, char delimiter = ';')
        {
            Patients.Clear();
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(delimiter).ToArray();
                    Patients.Add(new Patient(data[0], DateTime.Parse(data[1]), DateTime.Parse(data[2]), data[3], data[4] == "М"));
                }
            }
            LastUsePath = path;
        }
        public void FromXml(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Patient>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                Patients = xmlSerializer.Deserialize(fs) as List<Patient>;
            }
            LastUsePath = path;
        }
        public void FromJson(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Patients = JsonSerializer.Deserialize<List<Patient>>(sr.ReadToEnd());
            }
            LastUsePath = path;
        }

        public void ToXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Patient>));
            var filePath = @$"{Path.GetDirectoryName(LastUsePath)}\PatientsData.xml";
            using (FileStream fs = new(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Patients);
            }
            LastUsePath = filePath;
        }
        public void ToJson()
        {
            var filePath = @$"{Path.GetDirectoryName(LastUsePath)}\PatientsData.json";
            using (StreamWriter sr = File.CreateText(filePath))
            {
                sr.WriteLine(JsonSerializer.Serialize(Patients));
            }
            LastUsePath = filePath;
        }
        public void ToPdf(Patient patient, string path)
        {
            iTextSharp.text.Document doc = new();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALI.TTF");
            BaseFont baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            doc.Add(new iTextSharp.text.Paragraph($"Ф.И.О. пациента: {patient.FIO}{NL}", font));
            doc.Add(new iTextSharp.text.Paragraph($"Дата рождения: {patient.Birthdate}{NL}", font));
            doc.Add(new iTextSharp.text.Paragraph($"Дата посещения врача: {patient.DoctorVisitDate}{NL}", font));
            doc.Add(new iTextSharp.text.Paragraph($"Диагноз: {patient.Diagnosis}{NL}", font));
            var sex = patient.Sex ? "мужчина" : "женщина";
            doc.Add(new iTextSharp.text.Paragraph($"Пол: {sex}{NL}", font));

            doc.Close();
        }
        public void ToWord(Patient patient, string path)
        {
            Aspose.Words.Document doc = new Aspose.Words.Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            
            builder.Writeln($"Ф.И.О. пациента: {patient.FIO}{NL}");
            builder.Writeln($"Дата рождения: {patient.Birthdate}{NL}");
            builder.Writeln($"Дата посещения врача: {patient.DoctorVisitDate}{NL}");
            builder.Writeln($"Диагноз: {patient.Diagnosis}{NL}");
            var sex = patient.Sex ? "мужчина" : "женщина";
            builder.Writeln($"Пол: {sex}{NL}");

            doc.Save(path);
        }

        public void ToExcel(Patient patient, string path)
        {
            var book = new Aspose.Cells.Workbook();
            var sheet = book.Worksheets[0];
            var cells = sheet.Cells;

            cells["A1"].Value = "Ф.И.О. пациента:";
            cells["A2"].Value = "Дата рождения:";
            cells["A3"].Value = "Дата посещения врача:";
            cells["A4"].Value = "Диагноз:";
            cells["A5"].Value = "Пол:";

            cells["B1"].Value = patient.FIO;
            cells["B2"].Value = patient.Birthdate;
            cells["B3"].Value = patient.DoctorVisitDate;
            cells["B4"].Value = patient.Diagnosis;
            var sex = patient.Sex ? "мужчина" : "женщина";
            cells["B5"].Value = sex;

            book.Save(path);
        }
    }
}
