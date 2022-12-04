namespace lab13
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
            this.Wolf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Rabbit = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Fox = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Bear = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Волк
            // 
            this.Wolf.AllowDrop = true;
            this.Wolf.AutoSize = true;
            this.Wolf.Location = new System.Drawing.Point(35, 38);
            this.Wolf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Wolf.Name = "Волк";
            this.Wolf.Size = new System.Drawing.Size(34, 15);
            this.Wolf.TabIndex = 4;
            this.Wolf.Text = "Волк";
            this.Wolf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(9, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(98, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            this.textBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBox_DragOver);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // Заяц
            // 
            this.Rabbit.AllowDrop = true;
            this.Rabbit.AutoSize = true;
            this.Rabbit.Location = new System.Drawing.Point(189, 38);
            this.Rabbit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rabbit.Name = "Заяц";
            this.Rabbit.Size = new System.Drawing.Size(33, 15);
            this.Rabbit.TabIndex = 8;
            this.Rabbit.Text = "Заяц";
            this.Rabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(162, 121);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(98, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            this.textBox2.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBox_DragOver);
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // Лиса
            // 
            this.Fox.AllowDrop = true;
            this.Fox.AutoSize = true;
            this.Fox.Location = new System.Drawing.Point(334, 38);
            this.Fox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fox.Name = "Лиса";
            this.Fox.Size = new System.Drawing.Size(34, 15);
            this.Fox.TabIndex = 9;
            this.Fox.Text = "Лиса";
            this.Fox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Location = new System.Drawing.Point(309, 121);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(98, 23);
            this.textBox3.TabIndex = 6;
            this.textBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            this.textBox3.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBox_DragOver);
            this.textBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // Медведь
            // 
            this.Bear.AllowDrop = true;
            this.Bear.AutoSize = true;
            this.Bear.Location = new System.Drawing.Point(464, 38);
            this.Bear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bear.Name = "Медведь";
            this.Bear.Size = new System.Drawing.Size(54, 15);
            this.Bear.TabIndex = 10;
            this.Bear.Text = "Медведь";
            this.Bear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // textBox4
            // 
            this.textBox4.AllowDrop = true;
            this.textBox4.Location = new System.Drawing.Point(445, 121);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(98, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            this.textBox4.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBox_DragOver);
            this.textBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(551, 191);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Bear);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Fox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Rabbit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Wolf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаб13.1.Титов_Павел";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label Wolf;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Rabbit;
        private Label Fox;
        private Label Bear;
    }
}