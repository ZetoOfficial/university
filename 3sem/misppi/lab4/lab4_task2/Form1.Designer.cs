namespace lab4_task2
{
    partial class SecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForm));
            this.Red = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(600, 97);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(150, 50);
            this.Red.TabIndex = 0;
            this.Red.Text = "Красный";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(600, 153);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(150, 50);
            this.Yellow.TabIndex = 1;
            this.Yellow.Text = "Жёлтый";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(600, 209);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(150, 50);
            this.Green.TabIndex = 2;
            this.Green.Text = "Зелёный";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 393);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecondForm";
            this.Text = "Пр. занятие №4_2. Титов Павел";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SecondForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Red;
        private Button Yellow;
        private Button Green;
    }
}