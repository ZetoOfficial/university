namespace project4._2
{
    public partial class EditDataForm : Form
    {
        public ActionEnum CurrentAction { get; set; }

        public EditDataForm(ActionEnum action)
        {
            InitializeComponent();
            CurrentAction = action;
            this.DiagnosisBox.Items.Clear();
            this.SexBox.Items.Clear();
            this.DiagnosisBox.Items.AddRange(new object[] {
            "диагноз",
            "питонист",
            "антогонист",
            "прочее..."});
            DiagnosisBox.SelectedIndex = 0;
            this.SexBox.Items.AddRange(new object[] {
            "пол",
            "мужчина",
            "женщина"});
            SexBox.SelectedIndex = 0;
            if (CurrentAction == ActionEnum.Edit)
            {
                Patient currentPatient = Program.mainForm.GetCurrentPatient();
                if (currentPatient == null) return;
                SetPatientInfo(currentPatient);
            }
        }
        public void SetPatientInfo(Patient patient)
        {
            this.FIOTextBox.Text = patient.FIO;
            this.birthdateDatePicker.Text = patient.Birthdate.ToString();
            this.doctorVisitDatePicker.Text = patient.DoctorVisitDate.ToString();
            this.DiagnosisBox.Text = patient.Diagnosis;
            this.SexBox.Text = patient.Sex ? "мужчина" : "женщина";
        }
        private Patient CollectPatientInfo ()
        {
            return new Patient(FIOTextBox.Text, birthdateDatePicker.Value, doctorVisitDatePicker.Value, DiagnosisBox.Text, SexBox.Text == "мужчина");
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            try
            {
                patient = CollectPatientInfo();
            } catch (ArgumentException error) {
                MessageBox.Show(error.Message);
                return;
            }
            if (CurrentAction == ActionEnum.Edit)
            {
                Patient currentPatient = Program.mainForm.GetCurrentPatient();
                if (currentPatient == null) return;
                int index = Program.mainForm.fileManager.Patients.FindIndex(el => el.FIO == currentPatient.FIO);
                Program.mainForm.fileManager.Patients[index] = patient;
                int patientIndex = Program.mainForm.patientListBox.Items.IndexOf(currentPatient.FIO);
                Program.mainForm.patientListBox.Items[patientIndex] = patient.FIO;
            }
            else if (CurrentAction == ActionEnum.New)
            {
                Program.mainForm.fileManager.Patients.Add(patient);
                Program.mainForm.patientListBox.Items.Add(patient.FIO);
            }
            Program.mainForm.UpdateFileInfo();
            Program.mainForm.ReCalcTotalPatients();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.UpdateFileInfo();
            Program.mainForm.ReCalcTotalPatients();
            this.Close();
        }
    }
}