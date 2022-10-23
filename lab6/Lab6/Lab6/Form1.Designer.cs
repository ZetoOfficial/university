namespace Lab6
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.CalcKva = new System.Windows.Forms.Button();
            this.AInput = new System.Windows.Forms.TextBox();
            this.BInput = new System.Windows.Forms.TextBox();
            this.CInput = new System.Windows.Forms.TextBox();
            this.CalcBiKva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Моя формочка";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerLabel.Location = new System.Drawing.Point(137, 154);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(52, 15);
            this.AnswerLabel.TabIndex = 0;
            this.AnswerLabel.Text = "Answer: ";
            // 
            // CalcKva
            // 
            this.CalcKva.Location = new System.Drawing.Point(137, 88);
            this.CalcKva.Name = "CalcKva";
            this.CalcKva.Size = new System.Drawing.Size(272, 23);
            this.CalcKva.TabIndex = 1;
            this.CalcKva.Text = "Посчитать квадратное уравнение";
            this.CalcKva.UseVisualStyleBackColor = true;
            this.CalcKva.Click += new System.EventHandler(this.CalcKva_Click);
            // 
            // AInput
            // 
            this.AInput.Location = new System.Drawing.Point(62, 88);
            this.AInput.Name = "AInput";
            this.AInput.PlaceholderText = "a";
            this.AInput.Size = new System.Drawing.Size(69, 23);
            this.AInput.TabIndex = 2;
            this.AInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AInput_KeyPress);
            // 
            // BInput
            // 
            this.BInput.Location = new System.Drawing.Point(62, 117);
            this.BInput.Name = "BInput";
            this.BInput.PlaceholderText = "b";
            this.BInput.Size = new System.Drawing.Size(69, 23);
            this.BInput.TabIndex = 3;
            // 
            // CInput
            // 
            this.CInput.Location = new System.Drawing.Point(62, 146);
            this.CInput.Name = "CInput";
            this.CInput.PlaceholderText = "c";
            this.CInput.Size = new System.Drawing.Size(69, 23);
            this.CInput.TabIndex = 4;
            // 
            // CalcBiKva
            // 
            this.CalcBiKva.Location = new System.Drawing.Point(137, 116);
            this.CalcBiKva.Name = "CalcBiKva";
            this.CalcBiKva.Size = new System.Drawing.Size(272, 23);
            this.CalcBiKva.TabIndex = 5;
            this.CalcBiKva.Text = "Посчитать биквадратное уравнение";
            this.CalcBiKva.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.CalcBiKva);
            this.Controls.Add(this.CInput);
            this.Controls.Add(this.BInput);
            this.Controls.Add(this.AInput);
            this.Controls.Add(this.CalcKva);
            this.Controls.Add(this.AnswerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическое занятие №6, Титов Павел";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolTip toolTip1;
        private Label AnswerLabel;
        private Button CalcKva;
        private TextBox AInput;
        private TextBox BInput;
        private TextBox CInput;
        private Button CalcBiKva;
    }
}