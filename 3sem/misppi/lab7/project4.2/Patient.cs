namespace project4._2
{
    public class Patient
    {
        private string fio;
        public string FIO { get => fio; set { if (value.Length >= 3) { fio = value; } else { throw new ArgumentException("Фио минимум из 3 букв."); } } }
        public DateTime Birthdate { get; set; }
        public DateTime DoctorVisitDate { get; set; }
        private string diagnosis;
        public string Diagnosis { get => diagnosis; set { if (value != "диагноз") { diagnosis = value; } else { throw new ArgumentException("А диагноз?"); } } }
        public bool Sex { get; set ; }
        public Patient() { }
        public Patient(string fio, DateTime birthdate, DateTime doctorVisitDate, string diagnosis, bool sex)
        {
            FIO = fio;
            Birthdate = birthdate;
            DoctorVisitDate = doctorVisitDate;
            Diagnosis = diagnosis;
            Sex = sex;
        }
    }
}
