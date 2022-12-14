using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_dop_sdi
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_ResizeEnd(object sender, EventArgs e)
        {
            var forms = Program.MainForm.ChildrenForms;
            foreach (var form in forms)
            {
                form.Child.UpdateText();
            }
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainForm.Enabled = true;
            Program.AboutForm = new About();
        }
    }
}
