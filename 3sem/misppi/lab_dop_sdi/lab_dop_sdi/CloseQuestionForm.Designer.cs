namespace lab_dop_sdi
{
    partial class CloseQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseQuestionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBttn = new System.Windows.Forms.Button();
            this.CancelBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseBttn
            // 
            this.CloseBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBttn.Location = new System.Drawing.Point(12, 90);
            this.CloseBttn.Name = "CloseBttn";
            this.CloseBttn.Size = new System.Drawing.Size(127, 39);
            this.CloseBttn.TabIndex = 1;
            this.CloseBttn.Text = "Уверен!";
            this.CloseBttn.UseVisualStyleBackColor = false;
            this.CloseBttn.Click += new System.EventHandler(this.CloseBttn_Click);
            // 
            // CancelBttn
            // 
            this.CancelBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBttn.Location = new System.Drawing.Point(145, 90);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(127, 39);
            this.CancelBttn.TabIndex = 2;
            this.CancelBttn.Text = "Еще подумаю.";
            this.CancelBttn.UseVisualStyleBackColor = false;
            this.CancelBttn.Click += new System.EventHandler(this.CancelBttn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 25);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // CloseQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelBttn);
            this.Controls.Add(this.CloseBttn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CloseQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloseQuestionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button CloseBttn;
        private Button CancelBttn;
        private Panel panel1;
    }
}