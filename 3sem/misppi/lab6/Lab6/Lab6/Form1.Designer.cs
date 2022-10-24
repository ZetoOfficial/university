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
            this.CalcQuadraticEquation = new System.Windows.Forms.Button();
            this.AInput = new System.Windows.Forms.TextBox();
            this.BInput = new System.Windows.Forms.TextBox();
            this.CInput = new System.Windows.Forms.TextBox();
            this.CalcBiquadraticEquation = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // CalcQuadraticEquation
            // 
            this.CalcQuadraticEquation.Location = new System.Drawing.Point(137, 88);
            this.CalcQuadraticEquation.Name = "CalcQuadraticEquation";
            this.CalcQuadraticEquation.Size = new System.Drawing.Size(272, 23);
            this.CalcQuadraticEquation.TabIndex = 1;
            this.CalcQuadraticEquation.Text = "Посчитать квадратное уравнение";
            this.CalcQuadraticEquation.UseVisualStyleBackColor = true;
            this.CalcQuadraticEquation.Click += new System.EventHandler(this.CalcQuadraticEquation_Click);
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
            this.BInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BInput_KeyPress);
            // 
            // CInput
            // 
            this.CInput.Location = new System.Drawing.Point(62, 146);
            this.CInput.Name = "CInput";
            this.CInput.PlaceholderText = "c";
            this.CInput.Size = new System.Drawing.Size(69, 23);
            this.CInput.TabIndex = 4;
            this.CInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CInput_KeyPress);
            // 
            // CalcBiquadraticEquation
            // 
            this.CalcBiquadraticEquation.Location = new System.Drawing.Point(137, 116);
            this.CalcBiquadraticEquation.Name = "CalcBiquadraticEquation";
            this.CalcBiquadraticEquation.Size = new System.Drawing.Size(272, 23);
            this.CalcBiquadraticEquation.TabIndex = 5;
            this.CalcBiquadraticEquation.Text = "Посчитать биквадратное уравнение";
            this.CalcBiquadraticEquation.UseVisualStyleBackColor = true;
            this.CalcBiquadraticEquation.Click += new System.EventHandler(this.CalcBiquadraticEquation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.CalcBiquadraticEquation);
            this.Controls.Add(this.CInput);
            this.Controls.Add(this.BInput);
            this.Controls.Add(this.AInput);
            this.Controls.Add(this.CalcQuadraticEquation);
            this.Controls.Add(this.AnswerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическое занятие №6, Титов Павел";
            this.toolTip1.SetToolTip(this, "Моя формочка");
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
        private Button CalcQuadraticEquation;
        private TextBox AInput;
        private TextBox BInput;
        private TextBox CInput;
        private Button CalcBiquadraticEquation;
    }
}