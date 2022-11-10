using System.IO;
using System.Windows.Forms;

namespace project4._2
{
    public partial class Form1 : Form
    {
        FileManager fileManager = new FileManager();

        public Form1()
        {
            InitializeComponent();
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
                        fileManager.ToJson(fileManager.Patients);
                        break;
                    case DialogResult.No:
                        fileManager.ToXml(fileManager.Patients);
                        break;
                }
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
            // load from xml/json
            // show in ListBox
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

        private void patientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = patientListBox.SelectedItem.ToString();
            int index = patientListBox.FindString(curItem);
            
            if (index == -1) return;
            if (index > fileManager.Patients.Count) return;
            
            patientListBox.SetSelected(index, true);

            Patient patient = fileManager.Patients[index];
            UpdatePreviewFormData(patient);
            
            previewInfoPanel.Enabled = true;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Add new item in xml/json file
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Edit selected in ListBox item
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Delete selected in ListBox item
        }
    }
}