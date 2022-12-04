namespace project2
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.readFromFile = new System.Windows.Forms.Button();
            this.saveToFile = new System.Windows.Forms.Button();
            this.gradientPanel = new System.Windows.Forms.Panel();
            this.newWord = new System.Windows.Forms.Label();
            this.newWordBox = new System.Windows.Forms.TextBox();
            this.RedLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.list2Label = new System.Windows.Forms.Label();
            this.list1Label = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "информатика",
            "программирование",
            "геометрия",
            "матанализ",
            "статистика",
            "функанализ",
            "ТФКП"});
            this.listBox1.Location = new System.Drawing.Point(13, 95);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 289);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(203, 95);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 289);
            this.listBox2.TabIndex = 1;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox2_MouseDown);
            // 
            // readFromFile
            // 
            this.readFromFile.AllowDrop = true;
            this.readFromFile.Location = new System.Drawing.Point(13, 391);
            this.readFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(182, 35);
            this.readFromFile.TabIndex = 2;
            this.readFromFile.Text = "Считать из файла";
            this.readFromFile.UseVisualStyleBackColor = true;
            this.readFromFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.ReadFromFile_DragDrop);
            this.readFromFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.readFromFile_DragEnter);
            // 
            // saveToFile
            // 
            this.saveToFile.AllowDrop = true;
            this.saveToFile.Location = new System.Drawing.Point(203, 391);
            this.saveToFile.Margin = new System.Windows.Forms.Padding(4);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(182, 35);
            this.saveToFile.TabIndex = 3;
            this.saveToFile.Text = "Сохранить в файле";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.SaveToFile_DragDrop);
            this.saveToFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.saveToFile_DragEnter);
            // 
            // gradientPanel
            // 
            this.gradientPanel.AllowDrop = true;
            this.gradientPanel.BackColor = System.Drawing.SystemColors.Control;
            this.gradientPanel.Location = new System.Drawing.Point(48, 22);
            this.gradientPanel.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Size = new System.Drawing.Size(286, 34);
            this.gradientPanel.TabIndex = 4;
            this.gradientPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.GradientPanel_DragDrop);
            this.gradientPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.gradientPanel_DragEnter);
            this.gradientPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GradientPanel_MouseDown);
            this.gradientPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GradientPanel_MouseMove);
            // 
            // newWord
            // 
            this.newWord.AutoSize = true;
            this.newWord.Location = new System.Drawing.Point(160, 433);
            this.newWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newWord.Name = "newWord";
            this.newWord.Size = new System.Drawing.Size(78, 15);
            this.newWord.TabIndex = 5;
            this.newWord.Text = "Новое слово";
            // 
            // newWordBox
            // 
            this.newWordBox.AllowDrop = true;
            this.newWordBox.Location = new System.Drawing.Point(125, 452);
            this.newWordBox.Margin = new System.Windows.Forms.Padding(4);
            this.newWordBox.Name = "newWordBox";
            this.newWordBox.Size = new System.Drawing.Size(145, 23);
            this.newWordBox.TabIndex = 6;
            this.newWordBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.NewWordBox_DragDrop);
            this.newWordBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.newWordBox_DragEnter);
            this.newWordBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewWordBox_MouseDown);
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(13, 32);
            this.RedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(27, 15);
            this.RedLabel.TabIndex = 7;
            this.RedLabel.Text = "Red";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(342, 32);
            this.BlueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(30, 15);
            this.BlueLabel.TabIndex = 8;
            this.BlueLabel.Text = "Blue";
            // 
            // list2Label
            // 
            this.list2Label.AutoSize = true;
            this.list2Label.Location = new System.Drawing.Point(264, 76);
            this.list2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.list2Label.Name = "list2Label";
            this.list2Label.Size = new System.Drawing.Size(57, 15);
            this.list2Label.TabIndex = 9;
            this.list2Label.Text = "Список 2";
            // 
            // list1Label
            // 
            this.list1Label.AutoSize = true;
            this.list1Label.Location = new System.Drawing.Point(74, 76);
            this.list1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.list1Label.Name = "list1Label";
            this.list1Label.Size = new System.Drawing.Size(57, 15);
            this.list1Label.TabIndex = 10;
            this.list1Label.Text = "Список 1";
            // 
            // logBox
            // 
            this.logBox.AllowDrop = true;
            this.logBox.Location = new System.Drawing.Point(13, 483);
            this.logBox.Margin = new System.Windows.Forms.Padding(4);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(372, 71);
            this.logBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 564);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.list1Label);
            this.Controls.Add(this.list2Label);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.newWordBox);
            this.Controls.Add(this.newWord);
            this.Controls.Add(this.gradientPanel);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаб13.2.Титов_Павел";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button readFromFile;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.Panel gradientPanel;
        private System.Windows.Forms.Label newWord;
        private System.Windows.Forms.TextBox newWordBox;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label list2Label;
        private System.Windows.Forms.Label list1Label;
        private System.Windows.Forms.TextBox logBox;
    }
}