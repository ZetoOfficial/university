namespace project4._2
{
    partial class EditDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDataForm));
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.DiagnosisBox = new System.Windows.Forms.ComboBox();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.DoctorVisitDate = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.DiagnosisBox);
            this.InfoPanel.Controls.Add(this.SexBox);
            this.InfoPanel.Controls.Add(this.DoctorVisitDate);
            this.InfoPanel.Controls.Add(this.birthdate);
            this.InfoPanel.Controls.Add(this.dateTimePicker2);
            this.InfoPanel.Controls.Add(this.birth);
            this.InfoPanel.Controls.Add(this.FIOTextBox);
            this.InfoPanel.Controls.Add(this.SaveButton);
            this.InfoPanel.Controls.Add(this.DeleteButton);
            this.InfoPanel.Enabled = false;
            this.InfoPanel.Location = new System.Drawing.Point(13, 12);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(191, 221);
            this.InfoPanel.TabIndex = 11;
            // 
            // DiagnosisBox
            // 
            this.DiagnosisBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiagnosisBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiagnosisBox.FormattingEnabled = true;
            this.DiagnosisBox.Items.AddRange(new object[] {
            "диагноз",
            "питонист",
            "антогонист",
            "прочее"});
            this.DiagnosisBox.Location = new System.Drawing.Point(5, 123);
            this.DiagnosisBox.Name = "DiagnosisBox";
            this.DiagnosisBox.Size = new System.Drawing.Size(180, 23);
            this.DiagnosisBox.TabIndex = 15;
            // 
            // SexBox
            // 
            this.SexBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Items.AddRange(new object[] {
            "пол",
            "мужчина",
            "не мужчина",
            "ламинат",
            "паркет"});
            this.SexBox.Location = new System.Drawing.Point(5, 156);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(181, 23);
            this.SexBox.TabIndex = 14;
            // 
            // DoctorVisitDate
            // 
            this.DoctorVisitDate.AutoSize = true;
            this.DoctorVisitDate.Location = new System.Drawing.Point(4, 76);
            this.DoctorVisitDate.Name = "DoctorVisitDate";
            this.DoctorVisitDate.Size = new System.Drawing.Size(136, 15);
            this.DoctorVisitDate.TabIndex = 13;
            this.DoctorVisitDate.Text = "Дата посещения врача:";
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Location = new System.Drawing.Point(4, 31);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(93, 15);
            this.birthdate.TabIndex = 12;
            this.birthdate.Text = "Дата рождения:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(4, 94);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(183, 23);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Value = new System.DateTime(2022, 11, 8, 9, 15, 32, 0);
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(4, 49);
            this.birth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.birth.MaxDate = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            this.birth.MinDate = new System.DateTime(1822, 1, 1, 0, 0, 0, 0);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(183, 23);
            this.birth.TabIndex = 10;
            this.birth.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(4, 5);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FIOTextBox.Multiline = true;
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.PlaceholderText = "Фамилия Имя Отчество";
            this.FIOTextBox.Size = new System.Drawing.Size(182, 22);
            this.FIOTextBox.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(4, 185);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 27);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(97, 184);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 27);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 242);
            this.Controls.Add(this.InfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDataForm";
            this.Text = "EditDataForm";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel InfoPanel;
        private ComboBox DiagnosisBox;
        private ComboBox SexBox;
        private Label DoctorVisitDate;
        private Label birthdate;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker birth;
        private TextBox FIOTextBox;
        private Button SaveButton;
        private Button DeleteButton;
    }
}