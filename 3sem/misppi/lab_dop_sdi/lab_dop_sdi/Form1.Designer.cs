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
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.aboutCoordLabel = new System.Windows.Forms.Label();
            this.deleteAboutBttn = new System.Windows.Forms.Button();
            this.createAboutBttn = new System.Windows.Forms.Button();
            this.selColorForm = new System.Windows.Forms.Button();
            this.DetkaGroupBox.SuspendLayout();
            this.childPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childWidthResizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childHeightResizeNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetkaGroupBox
            // 
            this.DetkaGroupBox.Controls.Add(this.childPanel);
            this.DetkaGroupBox.Controls.Add(this.childListBox);
            this.DetkaGroupBox.Controls.Add(this.deleteChildBttn);
            this.DetkaGroupBox.Controls.Add(this.createChildBttn);
            this.DetkaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DetkaGroupBox.Name = "DetkaGroupBox";
            this.DetkaGroupBox.Size = new System.Drawing.Size(397, 177);
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
            this.childPanel.Enabled = false;
            this.childPanel.Location = new System.Drawing.Point(15, 50);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(382, 121);
            this.childPanel.TabIndex = 12;
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
            500,
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
            this.childCoordLabel.Location = new System.Drawing.Point(251, 33);
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
            500,
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
            this.childListBox.Location = new System.Drawing.Point(136, 22);
            this.childListBox.Name = "childListBox";
            this.childListBox.Size = new System.Drawing.Size(118, 23);
            this.childListBox.TabIndex = 11;
            this.childListBox.SelectedIndexChanged += new System.EventHandler(this.childListBox_SelectedIndexChanged);
            // 
            // deleteChildBttn
            // 
            this.deleteChildBttn.Location = new System.Drawing.Point(260, 21);
            this.deleteChildBttn.Name = "deleteChildBttn";
            this.deleteChildBttn.Size = new System.Drawing.Size(118, 23);
            this.deleteChildBttn.TabIndex = 5;
            this.deleteChildBttn.Text = "Уничтожить";
            this.deleteChildBttn.UseVisualStyleBackColor = true;
            this.deleteChildBttn.Click += new System.EventHandler(this.deleteChildBttnOnClick);
            // 
            // createChildBttn
            // 
            this.createChildBttn.Location = new System.Drawing.Point(12, 22);
            this.createChildBttn.Name = "createChildBttn";
            this.createChildBttn.Size = new System.Drawing.Size(118, 23);
            this.createChildBttn.TabIndex = 0;
            this.createChildBttn.Text = "🥰Создай меня~🥰";
            this.createChildBttn.UseVisualStyleBackColor = true;
            this.createChildBttn.Click += new System.EventHandler(this.CreateChildBttnOnClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aboutPanel);
            this.groupBox2.Controls.Add(this.deleteAboutBttn);
            this.groupBox2.Controls.Add(this.createAboutBttn);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 177);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.checkBox2);
            this.aboutPanel.Controls.Add(this.groupBox3);
            this.aboutPanel.Controls.Add(this.aboutCoordLabel);
            this.aboutPanel.Enabled = false;
            this.aboutPanel.Location = new System.Drawing.Point(15, 51);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(245, 120);
            this.aboutPanel.TabIndex = 6;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Видимиость";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(3, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Состояние";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 69);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 19);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Дефолт";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 44);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(87, 19);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Распахнута";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(76, 19);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "Свернута";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // aboutCoordLabel
            // 
            this.aboutCoordLabel.AutoSize = true;
            this.aboutCoordLabel.Location = new System.Drawing.Point(127, 46);
            this.aboutCoordLabel.Name = "aboutCoordLabel";
            this.aboutCoordLabel.Size = new System.Drawing.Size(101, 15);
            this.aboutCoordLabel.TabIndex = 4;
            this.aboutCoordLabel.Text = "Open form please";
            // 
            // deleteAboutBttn
            // 
            this.deleteAboutBttn.Location = new System.Drawing.Point(136, 22);
            this.deleteAboutBttn.Name = "deleteAboutBttn";
            this.deleteAboutBttn.Size = new System.Drawing.Size(124, 23);
            this.deleteAboutBttn.TabIndex = 5;
            this.deleteAboutBttn.Text = "Уничтожить";
            this.deleteAboutBttn.UseVisualStyleBackColor = true;
            this.deleteAboutBttn.Click += new System.EventHandler(this.deleteAboutBttn_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DetkaGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(435, 420);
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
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox DetkaGroupBox;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private Button createChildBttn;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        public Label childCoordLabel;
        private TextBox childChangeNameTextBox;
        private ColorDialog colorDialog1;
        private Button deleteChildBttn;
        private NumericUpDown childHeightResizeNumeric;
        private Label label3;
        private Label label2;
        private NumericUpDown childWidthResizeNumeric;
        private GroupBox groupBox2;
        private Button deleteAboutBttn;
        public Label aboutCoordLabel;
        private GroupBox groupBox3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private CheckBox checkBox2;
        private Button createAboutBttn;
        private ComboBox childListBox;
        private Panel childPanel;
        public Panel aboutPanel;
        private Button selColorForm;
    }
}