namespace project4._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtToXmlOrJson = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.patientListBox = new System.Windows.Forms.ListBox();
            this.outFioBox = new System.Windows.Forms.TextBox();
            this.previewInfoPanel = new System.Windows.Forms.Panel();
            this.outDoctorVisitDateBox = new System.Windows.Forms.TextBox();
            this.doctorVisitDateLabel = new System.Windows.Forms.Label();
            this.outSexBox = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.fioLabel = new System.Windows.Forms.Label();
            this.outDiagnosisBox = new System.Windows.Forms.TextBox();
            this.outBirthdateBox = new System.Windows.Forms.TextBox();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.openImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openTxtDialog = new System.Windows.Forms.OpenFileDialog();
            this.diagnosisComboBox = new System.Windows.Forms.ComboBox();
            this.selectDiagnosisLabel = new System.Windows.Forms.Label();
            this.totalDiagnosisLabel = new System.Windows.Forms.Label();
            this.previewInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtToXmlOrJson
            // 
            this.TxtToXmlOrJson.Location = new System.Drawing.Point(14, 47);
            this.TxtToXmlOrJson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtToXmlOrJson.Name = "TxtToXmlOrJson";
            this.TxtToXmlOrJson.Size = new System.Drawing.Size(182, 27);
            this.TxtToXmlOrJson.TabIndex = 2;
            this.TxtToXmlOrJson.Text = "csv to xml/json";
            this.TxtToXmlOrJson.UseVisualStyleBackColor = true;
            this.TxtToXmlOrJson.Click += new System.EventHandler(this.TxtToXmlOrJson_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(14, 14);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(88, 27);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "Импорт";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(207, 244);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(181, 27);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(206, 270);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 27);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(297, 270);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 27);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Enabled = false;
            this.ExportButton.Location = new System.Drawing.Point(108, 14);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(88, 27);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "Экспорт";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // patientListBox
            // 
            this.patientListBox.FormattingEnabled = true;
            this.patientListBox.ItemHeight = 15;
            this.patientListBox.Location = new System.Drawing.Point(14, 81);
            this.patientListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.patientListBox.Name = "patientListBox";
            this.patientListBox.Size = new System.Drawing.Size(181, 139);
            this.patientListBox.TabIndex = 8;
            this.patientListBox.SelectedIndexChanged += new System.EventHandler(this.patientListBox_SelectedIndexChanged);
            // 
            // outFioBox
            // 
            this.outFioBox.Location = new System.Drawing.Point(3, 24);
            this.outFioBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outFioBox.Multiline = true;
            this.outFioBox.Name = "outFioBox";
            this.outFioBox.PlaceholderText = "Фамилия Имя Отчество";
            this.outFioBox.ReadOnly = true;
            this.outFioBox.Size = new System.Drawing.Size(182, 22);
            this.outFioBox.TabIndex = 9;
            // 
            // previewInfoPanel
            // 
            this.previewInfoPanel.Controls.Add(this.outDoctorVisitDateBox);
            this.previewInfoPanel.Controls.Add(this.doctorVisitDateLabel);
            this.previewInfoPanel.Controls.Add(this.outSexBox);
            this.previewInfoPanel.Controls.Add(this.sexLabel);
            this.previewInfoPanel.Controls.Add(this.fioLabel);
            this.previewInfoPanel.Controls.Add(this.outDiagnosisBox);
            this.previewInfoPanel.Controls.Add(this.outBirthdateBox);
            this.previewInfoPanel.Controls.Add(this.diagnosisLabel);
            this.previewInfoPanel.Controls.Add(this.birthdateLabel);
            this.previewInfoPanel.Controls.Add(this.outFioBox);
            this.previewInfoPanel.Enabled = false;
            this.previewInfoPanel.Location = new System.Drawing.Point(203, 14);
            this.previewInfoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previewInfoPanel.Name = "previewInfoPanel";
            this.previewInfoPanel.Size = new System.Drawing.Size(191, 228);
            this.previewInfoPanel.TabIndex = 10;
            // 
            // outDoctorVisitDateBox
            // 
            this.outDoctorVisitDateBox.Location = new System.Drawing.Point(4, 115);
            this.outDoctorVisitDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outDoctorVisitDateBox.Multiline = true;
            this.outDoctorVisitDateBox.Name = "outDoctorVisitDateBox";
            this.outDoctorVisitDateBox.PlaceholderText = "Дата посещения врача";
            this.outDoctorVisitDateBox.ReadOnly = true;
            this.outDoctorVisitDateBox.Size = new System.Drawing.Size(182, 22);
            this.outDoctorVisitDateBox.TabIndex = 21;
            // 
            // doctorVisitDateLabel
            // 
            this.doctorVisitDateLabel.AutoSize = true;
            this.doctorVisitDateLabel.Location = new System.Drawing.Point(4, 95);
            this.doctorVisitDateLabel.Name = "doctorVisitDateLabel";
            this.doctorVisitDateLabel.Size = new System.Drawing.Size(136, 15);
            this.doctorVisitDateLabel.TabIndex = 20;
            this.doctorVisitDateLabel.Text = "Дата посещения врача:";
            // 
            // outSexBox
            // 
            this.outSexBox.Location = new System.Drawing.Point(4, 202);
            this.outSexBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outSexBox.Multiline = true;
            this.outSexBox.Name = "outSexBox";
            this.outSexBox.PlaceholderText = "Пол";
            this.outSexBox.ReadOnly = true;
            this.outSexBox.Size = new System.Drawing.Size(182, 22);
            this.outSexBox.TabIndex = 19;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(4, 184);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(30, 15);
            this.sexLabel.TabIndex = 18;
            this.sexLabel.Text = "Пол";
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Location = new System.Drawing.Point(3, 6);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(139, 15);
            this.fioLabel.TabIndex = 17;
            this.fioLabel.Text = "Фамилия Имя Отчество";
            // 
            // outDiagnosisBox
            // 
            this.outDiagnosisBox.Location = new System.Drawing.Point(3, 158);
            this.outDiagnosisBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outDiagnosisBox.Multiline = true;
            this.outDiagnosisBox.Name = "outDiagnosisBox";
            this.outDiagnosisBox.PlaceholderText = "Диагноз";
            this.outDiagnosisBox.ReadOnly = true;
            this.outDiagnosisBox.Size = new System.Drawing.Size(182, 22);
            this.outDiagnosisBox.TabIndex = 15;
            // 
            // outBirthdateBox
            // 
            this.outBirthdateBox.Location = new System.Drawing.Point(3, 70);
            this.outBirthdateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outBirthdateBox.Multiline = true;
            this.outBirthdateBox.Name = "outBirthdateBox";
            this.outBirthdateBox.PlaceholderText = "Дата рождения";
            this.outBirthdateBox.ReadOnly = true;
            this.outBirthdateBox.Size = new System.Drawing.Size(182, 22);
            this.outBirthdateBox.TabIndex = 14;
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Location = new System.Drawing.Point(3, 140);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(52, 15);
            this.diagnosisLabel.TabIndex = 13;
            this.diagnosisLabel.Text = "Диагноз";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(3, 50);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(93, 15);
            this.birthdateLabel.TabIndex = 12;
            this.birthdateLabel.Text = "Дата рождения:";
            // 
            // openImportFileDialog
            // 
            this.openImportFileDialog.FileName = "txt or json bro";
            this.openImportFileDialog.Filter = "json and xml files| *.json;*.xml";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Word|*.docx|Excel|*.xlsx|Pdf|*.pdf";
            // 
            // openTxtDialog
            // 
            this.openTxtDialog.FileName = "го в хинкальную";
            this.openTxtDialog.Filter = "Csv| *.csv";
            // 
            // diagnosisComboBox
            // 
            this.diagnosisComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diagnosisComboBox.FormattingEnabled = true;
            this.diagnosisComboBox.Location = new System.Drawing.Point(14, 248);
            this.diagnosisComboBox.Name = "diagnosisComboBox";
            this.diagnosisComboBox.Size = new System.Drawing.Size(181, 23);
            this.diagnosisComboBox.TabIndex = 11;
            this.diagnosisComboBox.SelectedIndexChanged += new System.EventHandler(this.diagnosisComboBox_SelectedIndexChanged);
            // 
            // selectDiagnosisLabel
            // 
            this.selectDiagnosisLabel.AutoSize = true;
            this.selectDiagnosisLabel.Location = new System.Drawing.Point(12, 227);
            this.selectDiagnosisLabel.Name = "selectDiagnosisLabel";
            this.selectDiagnosisLabel.Size = new System.Drawing.Size(107, 15);
            this.selectDiagnosisLabel.TabIndex = 12;
            this.selectDiagnosisLabel.Text = "Выберите диагноз";
            // 
            // totalDiagnosisLabel
            // 
            this.totalDiagnosisLabel.AutoSize = true;
            this.totalDiagnosisLabel.Location = new System.Drawing.Point(12, 280);
            this.totalDiagnosisLabel.Name = "totalDiagnosisLabel";
            this.totalDiagnosisLabel.Size = new System.Drawing.Size(44, 15);
            this.totalDiagnosisLabel.TabIndex = 13;
            this.totalDiagnosisLabel.Text = "Всего: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(402, 307);
            this.Controls.Add(this.totalDiagnosisLabel);
            this.Controls.Add(this.selectDiagnosisLabel);
            this.Controls.Add(this.diagnosisComboBox);
            this.Controls.Add(this.previewInfoPanel);
            this.Controls.Add(this.patientListBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.TxtToXmlOrJson);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пр.занятие. 7_4. Титов Павел";
            this.previewInfoPanel.ResumeLayout(false);
            this.previewInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TxtToXmlOrJson;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExportButton;
        public System.Windows.Forms.ListBox patientListBox;
        private System.Windows.Forms.TextBox outFioBox;
        private System.Windows.Forms.Panel previewInfoPanel;
        private Label birthdateLabel;
        private Label diagnosisLabel;
        private OpenFileDialog openImportFileDialog;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openTxtDialog;
        private TextBox outDiagnosisBox;
        private TextBox outBirthdateBox;
        private Label fioLabel;
        private TextBox outDoctorVisitDateBox;
        private Label doctorVisitDateLabel;
        private TextBox outSexBox;
        private Label sexLabel;
        private ComboBox diagnosisComboBox;
        private Label selectDiagnosisLabel;
        private Label totalDiagnosisLabel;
    }
}