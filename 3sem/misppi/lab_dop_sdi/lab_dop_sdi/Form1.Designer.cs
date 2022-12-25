namespace lab_dop_sdi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DetkaGroupBox = new System.Windows.Forms.GroupBox();
            this.childPanel = new System.Windows.Forms.Panel();
            this.selColorForm = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.childWidthResizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.childChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.childCoordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.childHeightResizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.childListBox = new System.Windows.Forms.ComboBox();
            this.deleteChildBttn = new System.Windows.Forms.Button();
            this.createChildBttn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createAboutBttn = new System.Windows.Forms.Button();
            this.DetkaGroupBox.SuspendLayout();
            this.childPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childWidthResizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childHeightResizeNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetkaGroupBox
            // 
            this.DetkaGroupBox.Controls.Add(this.childPanel);
            this.DetkaGroupBox.Controls.Add(this.childListBox);
            this.DetkaGroupBox.Controls.Add(this.deleteChildBttn);
            this.DetkaGroupBox.Controls.Add(this.createChildBttn);
            this.DetkaGroupBox.Location = new System.Drawing.Point(12, 82);
            this.DetkaGroupBox.Name = "DetkaGroupBox";
            this.DetkaGroupBox.Size = new System.Drawing.Size(409, 177);
            this.DetkaGroupBox.TabIndex = 2;
            this.DetkaGroupBox.TabStop = false;
            this.DetkaGroupBox.Text = "Детка";
            // 
            // childPanel
            // 
            this.childPanel.Controls.Add(this.selColorForm);
            this.childPanel.Controls.Add(this.checkBox1);
            this.childPanel.Controls.Add(this.groupBox1);
            this.childPanel.Controls.Add(this.childWidthResizeNumeric);
            this.childPanel.Controls.Add(this.childChangeNameTextBox);
            this.childPanel.Controls.Add(this.label3);
            this.childPanel.Controls.Add(this.childCoordLabel);
            this.childPanel.Controls.Add(this.label2);
            this.childPanel.Controls.Add(this.childHeightResizeNumeric);
            this.childPanel.Location = new System.Drawing.Point(15, 50);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(387, 121);
            this.childPanel.TabIndex = 12;
            // 
            // selColorForm
            // 
            this.selColorForm.Location = new System.Drawing.Point(251, 95);
            this.selColorForm.Name = "selColorForm";
            this.selColorForm.Size = new System.Drawing.Size(125, 23);
            this.selColorForm.TabIndex = 11;
            this.selColorForm.Text = "Выбор цвета";
            this.selColorForm.UseVisualStyleBackColor = true;
            this.selColorForm.Click += new System.EventHandler(this.selColorForm_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Видимиость";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(3, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Состояние";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Дефолт";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.defaultRadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Распахнута";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.razvernutaRadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Свернута";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.svernutRadioButton_CheckedChanged);
            // 
            // childWidthResizeNumeric
            // 
            this.childWidthResizeNumeric.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.childWidthResizeNumeric.Location = new System.Drawing.Point(127, 95);
            this.childWidthResizeNumeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.childWidthResizeNumeric.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.childWidthResizeNumeric.Name = "childWidthResizeNumeric";
            this.childWidthResizeNumeric.Size = new System.Drawing.Size(118, 23);
            this.childWidthResizeNumeric.TabIndex = 10;
            this.childWidthResizeNumeric.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.childWidthResizeNumeric.ValueChanged += new System.EventHandler(this.childWidthResizeNumeric_ValueChanged);
            // 
            // childChangeNameTextBox
            // 
            this.childChangeNameTextBox.Location = new System.Drawing.Point(127, 3);
            this.childChangeNameTextBox.Name = "childChangeNameTextBox";
            this.childChangeNameTextBox.PlaceholderText = "Form Title";
            this.childChangeNameTextBox.Size = new System.Drawing.Size(118, 23);
            this.childChangeNameTextBox.TabIndex = 3;
            this.childChangeNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.childChangeNameTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ширина";
            // 
            // childCoordLabel
            // 
            this.childCoordLabel.AutoSize = true;
            this.childCoordLabel.Location = new System.Drawing.Point(251, 42);
            this.childCoordLabel.Name = "childCoordLabel";
            this.childCoordLabel.Size = new System.Drawing.Size(127, 15);
            this.childCoordLabel.TabIndex = 4;
            this.childCoordLabel.Text = "Select form please ^_^";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Высота";
            // 
            // childHeightResizeNumeric
            // 
            this.childHeightResizeNumeric.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.childHeightResizeNumeric.Location = new System.Drawing.Point(127, 51);
            this.childHeightResizeNumeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.childHeightResizeNumeric.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.childHeightResizeNumeric.Name = "childHeightResizeNumeric";
            this.childHeightResizeNumeric.Size = new System.Drawing.Size(118, 23);
            this.childHeightResizeNumeric.TabIndex = 6;
            this.childHeightResizeNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.childHeightResizeNumeric.ValueChanged += new System.EventHandler(this.childHeightResizeNumeric_ValueChanged);
            // 
            // childListBox
            // 
            this.childListBox.DisplayMember = "2";
            this.childListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.childListBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.childListBox.FormattingEnabled = true;
            this.childListBox.Items.AddRange(new object[] {
            "ко всем деткам"});
            this.childListBox.Location = new System.Drawing.Point(142, 23);
            this.childListBox.Name = "childListBox";
            this.childListBox.Size = new System.Drawing.Size(118, 23);
            this.childListBox.TabIndex = 11;
            this.childListBox.SelectedIndexChanged += new System.EventHandler(this.childListBox_SelectedIndexChanged);
            // 
            // deleteChildBttn
            // 
            this.deleteChildBttn.Location = new System.Drawing.Point(266, 23);
            this.deleteChildBttn.Name = "deleteChildBttn";
            this.deleteChildBttn.Size = new System.Drawing.Size(136, 23);
            this.deleteChildBttn.TabIndex = 5;
            this.deleteChildBttn.Text = "Уничтожить";
            this.deleteChildBttn.UseVisualStyleBackColor = true;
            this.deleteChildBttn.Click += new System.EventHandler(this.deleteChildBttnOnClick);
            // 
            // createChildBttn
            // 
            this.createChildBttn.Location = new System.Drawing.Point(12, 22);
            this.createChildBttn.Name = "createChildBttn";
            this.createChildBttn.Size = new System.Drawing.Size(124, 23);
            this.createChildBttn.TabIndex = 0;
            this.createChildBttn.Text = "🥰Создай меня~🥰";
            this.createChildBttn.UseVisualStyleBackColor = true;
            this.createChildBttn.Click += new System.EventHandler(this.CreateChildBttnOnClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createAboutBttn);
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 59);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // createAboutBttn
            // 
            this.createAboutBttn.Location = new System.Drawing.Point(12, 22);
            this.createAboutBttn.Name = "createAboutBttn";
            this.createAboutBttn.Size = new System.Drawing.Size(124, 23);
            this.createAboutBttn.TabIndex = 0;
            this.createAboutBttn.Text = "Открой меня";
            this.createAboutBttn.UseVisualStyleBackColor = true;
            this.createAboutBttn.Click += new System.EventHandler(this.createAboutBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 269);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DetkaGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(446, 308);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаб SDI: Титов Павел";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.DetkaGroupBox.ResumeLayout(false);
            this.childPanel.ResumeLayout(false);
            this.childPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childWidthResizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childHeightResizeNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox DetkaGroupBox;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private Button createChildBttn;
        public RadioButton radioButton1;
        public RadioButton radioButton3;
        public RadioButton radioButton2;
        public Label childCoordLabel;
        private TextBox childChangeNameTextBox;
        private ColorDialog colorDialog1;
        private Button deleteChildBttn;
        private NumericUpDown childHeightResizeNumeric;
        private Label label3;
        private Label label2;
        private NumericUpDown childWidthResizeNumeric;
        private GroupBox groupBox2;
        private Button createAboutBttn;
        private ComboBox childListBox;
        private Panel childPanel;
        private Button selColorForm;
    }
}