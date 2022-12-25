using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab_dop_sdi
{
    public partial class Детка : Form
    {
        public Детка()
        {
            InitializeComponent();
            UpdateText();
        }

        public void UpdateText()
        {
            var text = $"Размеры текущей формы: {this.Size.Width}; {this.Size.Height}\n";
            var mainFormSize = Program.MainForm.Size;
            text += $"Размеры главной формы: {mainFormSize.Width}; {mainFormSize.Height}\n";
            var aboutFormSize = Program.AboutForm.Size;
            text += $"Размеры about формы: {aboutFormSize.Width}; {aboutFormSize.Height}";
            infoLabel.Text = text;
        }

        private void Детка_Move(object sender, EventArgs e)
        {
            Program.MainForm.UpdateChildCoord(this.Text);
        }

        private void Детка_ResizeEnd(object sender, EventArgs e)
        {
            UpdateText();
        }
    }
}
