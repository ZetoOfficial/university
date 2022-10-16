namespace lab4_task1
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.CustomCloseButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomCloseButton
            // 
            this.CustomCloseButton.BackgroundImage = global::lab4_task1.Properties.Resources.stone;
            this.CustomCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustomCloseButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomCloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomCloseButton.Location = new System.Drawing.Point(595, 396);
            this.CustomCloseButton.Name = "CustomCloseButton";
            this.CustomCloseButton.Size = new System.Drawing.Size(191, 46);
            this.CustomCloseButton.TabIndex = 0;
            this.CustomCloseButton.Text = "Закрыть";
            this.CustomCloseButton.UseVisualStyleBackColor = true;
            this.CustomCloseButton.Click += new System.EventHandler(this.CustomCloseButton_Click);
            // 
            // ResizeButton
            // 
            this.ResizeButton.Location = new System.Drawing.Point(0, 0);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(20, 20);
            this.ResizeButton.TabIndex = 1;
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 454);
            this.Controls.Add(this.ResizeButton);
            this.Controls.Add(this.CustomCloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstForm";
            this.Text = "Пр. занятие №4_1. Титов Павел";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FirstForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FirstForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CustomCloseButton;
        private Button ResizeButton;
    }
}