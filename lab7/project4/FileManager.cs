using System;
using System.IO;
using System.Xml.Serialization;


namespace project4
{
    public class FileManager
    {
        public void Serizlization(Patient patient)
        {
            // передаем в конструктор тип класса Person
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Patient));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("patient.xml", FileMode.OpenOrCreate))
            {
                Console.WriteLine("Object has been serialized");
            }
        }
    }
}
