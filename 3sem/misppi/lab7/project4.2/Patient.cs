using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4._2
{
    public class Patient
    {
        public string FIO { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime DoctorVisitDate { get; set; }
        public string Diagnosis { get; set; }
        public bool Sex { get; set; }
        public Patient() { }
        public Patient(string fIO, DateTime birthdate, DateTime doctorVisitDate, string diagnosis, bool sex)
        {
            FIO = fIO;
            Birthdate = birthdate;
            DoctorVisitDate = doctorVisitDate;
            Diagnosis = diagnosis;
            Sex = sex;
        }
    }
}
