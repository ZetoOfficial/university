using System.Text.Json;
using System.Xml.Serialization;

namespace project4._2
{
    public class FileManager
    {
        public List<Patient> Patients { get; set; }
        public string LastUsePath { get; set; }
        //public Watcher Watcher { get; set; }

        public FileManager()
        {
            Patients = new List<Patient>();
            LastUsePath = "";
            //Watcher = new Watcher("");
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

        public void ToXml(List<Patient> patients)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Patient>));
            var filePath = @$"{Path.GetDirectoryName(LastUsePath)}\PatientsData.xml";
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, patients);
            }
            LastUsePath = filePath;
            //Watcher.FilePath = LastUsePath;
        }
        public void ToJson(List<Patient> patients)
        {
            var filePath = @$"{Path.GetDirectoryName(LastUsePath)}\PatientsData.json";
            using (StreamWriter sr = File.CreateText(filePath))
            {
                sr.WriteLine(JsonSerializer.Serialize(patients));
            }
            LastUsePath = filePath;
            //Watcher.FilePath = LastUsePath;
        }
    }
}
