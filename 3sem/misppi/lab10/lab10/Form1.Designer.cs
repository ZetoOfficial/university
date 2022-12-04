namespace lab10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CntSquareLabel = new System.Windows.Forms.Label();
            this.aSquareLabel = new System.Windows.Forms.Label();
            this.kNum = new System.Windows.Forms.NumericUpDown();
            this.aNum = new System.Windows.Forms.NumericUpDown();
            this.squarePictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеВbmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MSnowValue = new System.Windows.Forms.NumericUpDown();
            this.KSnowValue = new System.Windows.Forms.NumericUpDown();
            this.DeltaSnowValue = new System.Windows.Forms.NumericUpDown();
            this.RSnowValue = new System.Windows.Forms.NumericUpDown();
            this.snowPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ynum = new System.Windows.Forms.NumericUpDown();
            this.xnum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rWatchNum = new System.Windows.Forms.NumericUpDown();
            this.watchStop = new System.Windows.Forms.Button();
            this.watchStart = new System.Windows.Forms.Button();
            this.watchPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.changePenColorBttn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squarePictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSnowValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KSnowValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaSnowValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSnowValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowPictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ynum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rWatchNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 438);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CntSquareLabel);
            this.tabPage1.Controls.Add(this.aSquareLabel);
            this.tabPage1.Controls.Add(this.kNum);
            this.tabPage1.Controls.Add(this.aNum);
            this.tabPage1.Controls.Add(this.squarePictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Квадраты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CntSquareLabel
            // 
            this.CntSquareLabel.AutoSize = true;
            this.CntSquareLabel.Location = new System.Drawing.Point(606, 201);
            this.CntSquareLabel.Name = "CntSquareLabel";
            this.CntSquareLabel.Size = new System.Drawing.Size(130, 15);
            this.CntSquareLabel.TabIndex = 4;
            this.CntSquareLabel.Text = "Количество квадратов";
            // 
            // aSquareLabel
            // 
            this.aSquareLabel.AutoSize = true;
            this.aSquareLabel.Location = new System.Drawing.Point(606, 140);
            this.aSquareLabel.Name = "aSquareLabel";
            this.aSquareLabel.Size = new System.Drawing.Size(105, 15);
            this.aSquareLabel.TabIndex = 3;
            this.aSquareLabel.Text = "Сторона квадрата";
            // 
            // kNum
            // 
            this.kNum.Location = new System.Drawing.Point(606, 219);
            this.kNum.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.kNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kNum.Name = "kNum";
            this.kNum.Size = new System.Drawing.Size(120, 23);
            this.kNum.TabIndex = 2;
            this.kNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kNum.ValueChanged += new System.EventHandler(this.kNum_ValueChanged);
            // 
            // aNum
            // 
            this.aNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.aNum.Location = new System.Drawing.Point(606, 158);
            this.aNum.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.aNum.Name = "aNum";
            this.aNum.Size = new System.Drawing.Size(120, 23);
            this.aNum.TabIndex = 1;
            this.aNum.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.aNum.ValueChanged += new System.EventHandler(this.aNum_ValueChanged);
            // 
            // squarePictureBox
            // 
            this.squarePictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.squarePictureBox.Location = new System.Drawing.Point(0, 0);
            this.squarePictureBox.Name = "squarePictureBox";
            this.squarePictureBox.Size = new System.Drawing.Size(600, 410);
            this.squarePictureBox.TabIndex = 0;
            this.squarePictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem,
            this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem,
            this.сохранитьИзображениеВbmpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(455, 70);
            // 
            // вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem
            // 
            this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem.Checked = true;
            this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem.Name = "вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem";
            this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem.Size = new System.Drawing.Size(454, 22);
            this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem.Text = "Вкл/Выкл режим автоматической перерисовки при изм параметров";
            this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem.Click += new System.EventHandler(this.вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem_Click);
            // 
            // вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem
            // 
            this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem.Checked = true;
            this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem.Name = "вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem";
            this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem.Size = new System.Drawing.Size(454, 22);
            this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem.Text = "Вкл/Выкл принудительную перерисовку при изм формы ";
            this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem.Click += new System.EventHandler(this.вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem_Click);
            // 
            // сохранитьИзображениеВbmpToolStripMenuItem
            // 
            this.сохранитьИзображениеВbmpToolStripMenuItem.Name = "сохранитьИзображениеВbmpToolStripMenuItem";
            this.сохранитьИзображениеВbmpToolStripMenuItem.Size = new System.Drawing.Size(454, 22);
            this.сохранитьИзображениеВbmpToolStripMenuItem.Text = "Сохранить изображение в *.bmp";
            this.сохранитьИзображениеВbmpToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзображениеВbmpToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.MSnowValue);
            this.tabPage2.Controls.Add(this.KSnowValue);
            this.tabPage2.Controls.Add(this.DeltaSnowValue);
            this.tabPage2.Controls.Add(this.RSnowValue);
            this.tabPage2.Controls.Add(this.snowPictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Снеговики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "число кругов на луче";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "число лучей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "коэф-т уменьшения R";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Радиус";
            // 
            // MSnowValue
            // 
            this.MSnowValue.Location = new System.Drawing.Point(606, 258);
            this.MSnowValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MSnowValue.Name = "MSnowValue";
            this.MSnowValue.Size = new System.Drawing.Size(120, 23);
            this.MSnowValue.TabIndex = 4;
            this.MSnowValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MSnowValue.ValueChanged += new System.EventHandler(this.MSnowValue_ValueChanged);
            // 
            // KSnowValue
            // 
            this.KSnowValue.Location = new System.Drawing.Point(606, 197);
            this.KSnowValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.KSnowValue.Name = "KSnowValue";
            this.KSnowValue.Size = new System.Drawing.Size(120, 23);
            this.KSnowValue.TabIndex = 3;
            this.KSnowValue.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.KSnowValue.ValueChanged += new System.EventHandler(this.KSnowValue_ValueChanged);
            // 
            // DeltaSnowValue
            // 
            this.DeltaSnowValue.DecimalPlaces = 2;
            this.DeltaSnowValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DeltaSnowValue.Location = new System.Drawing.Point(606, 139);
            this.DeltaSnowValue.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.DeltaSnowValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DeltaSnowValue.Name = "DeltaSnowValue";
            this.DeltaSnowValue.Size = new System.Drawing.Size(120, 23);
            this.DeltaSnowValue.TabIndex = 1;
            this.DeltaSnowValue.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.DeltaSnowValue.ValueChanged += new System.EventHandler(this.DeltaSnowValue_ValueChanged);
            // 
            // RSnowValue
            // 
            this.RSnowValue.Location = new System.Drawing.Point(606, 84);
            this.RSnowValue.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.RSnowValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RSnowValue.Name = "RSnowValue";
            this.RSnowValue.Size = new System.Drawing.Size(120, 23);
            this.RSnowValue.TabIndex = 2;
            this.RSnowValue.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.RSnowValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // snowPictureBox
            // 
            this.snowPictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.snowPictureBox.Location = new System.Drawing.Point(0, 0);
            this.snowPictureBox.Name = "snowPictureBox";
            this.snowPictureBox.Size = new System.Drawing.Size(600, 410);
            this.snowPictureBox.TabIndex = 1;
            this.snowPictureBox.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ynum);
            this.tabPage3.Controls.Add(this.xnum);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.rWatchNum);
            this.tabPage3.Controls.Add(this.watchStop);
            this.tabPage3.Controls.Add(this.watchStart);
            this.tabPage3.Controls.Add(this.watchPictureBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(782, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Часы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ynum
            // 
            this.ynum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ynum.Location = new System.Drawing.Point(606, 141);
            this.ynum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ynum.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.ynum.Name = "ynum";
            this.ynum.Size = new System.Drawing.Size(120, 23);
            this.ynum.TabIndex = 12;
            this.ynum.ValueChanged += new System.EventHandler(this.ynum_ValueChanged);
            // 
            // xnum
            // 
            this.xnum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xnum.Location = new System.Drawing.Point(606, 112);
            this.xnum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.xnum.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.xnum.Name = "xnum";
            this.xnum.Size = new System.Drawing.Size(120, 23);
            this.xnum.TabIndex = 11;
            this.xnum.ValueChanged += new System.EventHandler(this.xnum_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "R";
            // 
            // rWatchNum
            // 
            this.rWatchNum.Location = new System.Drawing.Point(606, 202);
            this.rWatchNum.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.rWatchNum.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.rWatchNum.Name = "rWatchNum";
            this.rWatchNum.Size = new System.Drawing.Size(120, 23);
            this.rWatchNum.TabIndex = 8;
            this.rWatchNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rWatchNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // watchStop
            // 
            this.watchStop.Location = new System.Drawing.Point(606, 69);
            this.watchStop.Name = "watchStop";
            this.watchStop.Size = new System.Drawing.Size(120, 34);
            this.watchStop.TabIndex = 7;
            this.watchStop.Text = "Stop";
            this.watchStop.UseVisualStyleBackColor = true;
            this.watchStop.Click += new System.EventHandler(this.watchStop_Click);
            // 
            // watchStart
            // 
            this.watchStart.Location = new System.Drawing.Point(606, 29);
            this.watchStart.Name = "watchStart";
            this.watchStart.Size = new System.Drawing.Size(120, 34);
            this.watchStart.TabIndex = 6;
            this.watchStart.Text = "Start";
            this.watchStart.UseVisualStyleBackColor = true;
            this.watchStart.Click += new System.EventHandler(this.watchStart_Click);
            // 
            // watchPictureBox
            // 
            this.watchPictureBox.Location = new System.Drawing.Point(0, 0);
            this.watchPictureBox.Name = "watchPictureBox";
            this.watchPictureBox.Size = new System.Drawing.Size(600, 410);
            this.watchPictureBox.TabIndex = 1;
            this.watchPictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // changePenColorBttn
            // 
            this.changePenColorBttn.Location = new System.Drawing.Point(800, 340);
            this.changePenColorBttn.Name = "changePenColorBttn";
            this.changePenColorBttn.Size = new System.Drawing.Size(120, 25);
            this.changePenColorBttn.TabIndex = 1;
            this.changePenColorBttn.Text = "применить";
            this.changePenColorBttn.UseVisualStyleBackColor = true;
            this.changePenColorBttn.Click += new System.EventHandler(this.changePenColorBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 436);
            this.Controls.Add(this.changePenColorBttn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаба 10-12, Титов Павел Сергеевич";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squarePictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSnowValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KSnowValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaSnowValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSnowValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowPictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ynum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rWatchNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox squarePictureBox;
        private PictureBox snowPictureBox;
        private PictureBox watchPictureBox;
        private NumericUpDown aNum;
        private NumericUpDown kNum;
        private Label aSquareLabel;
        private Label CntSquareLabel;
        private NumericUpDown RSnowValue;
        private NumericUpDown MSnowValue;
        private NumericUpDown KSnowValue;
        private NumericUpDown DeltaSnowValue;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private NumericUpDown rWatchNum;
        private Button watchStop;
        private Button watchStart;
        private NumericUpDown xnum;
        private NumericUpDown ynum;
        private System.Windows.Forms.Timer timer1;
        private Button changePenColorBttn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem вклВыклРежимАвтоматическойПерерисовкиПриИзмПараметровToolStripMenuItem;
        private ToolStripMenuItem вклВыклПринудительнуюПерерисовкуПриИзмФормыToolStripMenuItem;
        private ToolStripMenuItem сохранитьИзображениеВbmpToolStripMenuItem;
        private ColorDialog colorDialog1;
    }
}