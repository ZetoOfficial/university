namespace lab7
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
            this.Step1Button = new System.Windows.Forms.Button();
            this.Step2Button = new System.Windows.Forms.Button();
            this.Step3Button = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Step1Button
            // 
            this.Step1Button.Location = new System.Drawing.Point(12, 12);
            this.Step1Button.Name = "Step1Button";
            this.Step1Button.Size = new System.Drawing.Size(75, 23);
            this.Step1Button.TabIndex = 0;
            this.Step1Button.Text = "Шаг 1";
            this.Step1Button.UseVisualStyleBackColor = true;
            this.Step1Button.Click += new System.EventHandler(this.Step1Button_Click);
            // 
            // Step2Button
            // 
            this.Step2Button.Location = new System.Drawing.Point(12, 41);
            this.Step2Button.Name = "Step2Button";
            this.Step2Button.Size = new System.Drawing.Size(75, 23);
            this.Step2Button.TabIndex = 1;
            this.Step2Button.Text = "Шаг 2";
            this.Step2Button.UseVisualStyleBackColor = true;
            this.Step2Button.Visible = false;
            this.Step2Button.Click += new System.EventHandler(this.Step2Button_Click);
            // 
            // Step3Button
            // 
            this.Step3Button.Location = new System.Drawing.Point(12, 70);
            this.Step3Button.Name = "Step3Button";
            this.Step3Button.Size = new System.Drawing.Size(75, 23);
            this.Step3Button.TabIndex = 2;
            this.Step3Button.Text = "Шаг 3";
            this.Step3Button.UseVisualStyleBackColor = true;
            this.Step3Button.Visible = false;
            this.Step3Button.Click += new System.EventHandler(this.Step3Button_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(93, 15);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(269, 241);
            this.LogBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 270);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.Step3Button);
            this.Controls.Add(this.Step2Button);
            this.Controls.Add(this.Step1Button);
            this.Name = "Form1";
            this.Text = "Пр.занятие. 7_1. Титов Павел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Step1Button;
        private System.Windows.Forms.Button Step2Button;
        private System.Windows.Forms.Button Step3Button;
        private System.Windows.Forms.TextBox LogBox;
    }
}

