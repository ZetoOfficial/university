using System.IO;

namespace project4._2
{
    public partial class Form1 : Form
    {
        public FileManager fileManager = new FileManager();

        public Form1()
        {
            InitializeComponent();
            this.diagnosisComboBox.Items.AddRange(new object[] {
            "диагноз",
            "питонист",
            "антогонист",
            "прочее..."});
            diagnosisComboBox.SelectedIndex = 0;
        }

        private void TxtToXmlOrJson_Click(object sender, EventArgs e)
        {
            if (openTxtDialog.ShowDialog() == DialogResult.OK)
            {
                var dialogResult = MessageBox.Show("Json (Ok) or Xml (No)?", "Выбор конвертации", MessageBoxButtons.YesNo);
                fileManager.FromCsv(openTxtDialog.FileName);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        fileManager.ToJson();
                        break;
                    case DialogResult.No:
                        fileManager.ToXml();
                        break;
                }
                ExportButton.Enabled = true;
            }
        }
        public void UpdatePreviewFormData(Patient patient)
        {
            outFioBox.Text = patient.FIO;
            outBirthdateBox.Text = patient.Birthdate.ToString();
            outDoctorVisitDateBox.Text = patient.DoctorVisitDate.ToString();
            outDiagnosisBox.Text = patient.Diagnosis;
            outSexBox.Text = patient.Sex ? "мужчина" : "не мужчина";
        }
        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (openImportFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openImportFileDialog.FileName;
                switch (Path.GetExtension(path))
                {
                    case ".json":
                        fileManager.FromJson(path);
                        break;
                    case ".xml":
                        fileManager.FromXml(path);
                        break;
                }
                fileManager.LastUsePath = path;
                patientListBox.Items.Clear();
                patientListBox.Items.AddRange(fileManager.Patients.Select(el => el.FIO).ToArray());
            }
        }

        public Patient GetCurrentPatient()
        {
            var selectedItem = patientListBox.SelectedItem;
            if (selectedItem is null) return null;
            string curItem = selectedItem.ToString();
            int index = patientListBox.FindString(curItem);

            if (index == -1 || index < 0) return null;
            if (index > fileManager.Patients.Count) return null;

            return fileManager.Patients[index];
        }

        private void patientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Patient patient = GetCurrentPatient();
            if (patient == null) return;
            UpdatePreviewFormData(patient);

            previewInfoPanel.Enabled = patientListBox.Items.Count > 0;
            DeleteButton.Enabled = patientListBox.Items.Count > 0;
            EditButton.Enabled = patientListBox.Items.Count > 0;
            ExportButton.Enabled = patientListBox.Items.Count > 0;
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            var patient = GetCurrentPatient();
            if (patient == null) return;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;

                switch (Path.GetExtension(path))
                {
                    case ".pdf":
                        fileManager.ToPdf(patient, path);
                        break;
                    case ".docx":
                        fileManager.ToWord(patient, path);
                        break;
                    case ".xlsx":
                        fileManager.ToExcel(patient, path);
                        break;
                }
            }
        }
        public void UpdateFileInfo()
        {
            switch (Path.GetExtension(fileManager.LastUsePath))
            {
                case ".json":
                    fileManager.ToJson();
                    break;
                case ".xml":
                    fileManager.ToXml();
                    break;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            EditDataForm userInputForm = new EditDataForm(ActionEnum.New);
            userInputForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditDataForm userInputForm = new EditDataForm(ActionEnum.Edit);
            userInputForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedItem = patientListBox.SelectedItem;
            if (selectedItem is null) return;

            Patient patient = GetCurrentPatient();
            if (patient == null) return;

            fileManager.Patients.Remove(patient);
            patientListBox.Items.Remove(selectedItem);

            previewInfoPanel.Enabled = false;
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            ExportButton.Enabled = false;
            UpdateFileInfo();
        }
        public void ReCalcTotalPatients()
        {
            var patientCount = fileManager.Patients.Where(el => el.Diagnosis == diagnosisComboBox.Text).Count();
            totalDiagnosisLabel.Text = $"Всего: {patientCount}";
        }
        private void diagnosisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReCalcTotalPatients();
        }
    }
}