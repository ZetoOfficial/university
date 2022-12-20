using System;

namespace lab_dop_sdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            childListBox.SelectedIndex = 0;
        }
        
        public List<ChildForAFee> ChildrenForms = new List<ChildForAFee>();

        public bool CanClose(Form f)
        {
            var closeForm = new CloseQuestionForm(f.Text);
            var result = closeForm.ShowDialog();
            return result == DialogResult.OK;
        }

        private ChildForAFee? SelectedChild()
        {
            if (childListBox.SelectedIndex != 0)
            {

                var formName = childListBox.SelectedItem.ToString();
                return ChildrenForms.Find(el => el.Name == formName);
            }
            return null;
        }

        private void CreateChildBttnOnClick(object sender, EventArgs e)
        {
            var lastForm = ChildrenForms.LastOrDefault();
            
            var newForm = new ChildForAFee(lastForm != null ? lastForm.ID + 1 : 1);
            ChildrenForms.Add(newForm);
            childListBox.Items.Add(newForm.Name);
            childListBox.SelectedIndex = childListBox.Items.Count - 1;

            newForm.Show();
        }

        private void deleteChildBttnOnClick(object sender, EventArgs e)
        {
            var children = SelectedChild();

            if (children == null) 
            { 
                foreach (var child in ChildrenForms.ToList())
                {
                    if (!CanClose(child.Child)) break;
                    child.Close();
                    childListBox.Items.Remove(child.Name);
                    ChildrenForms.Remove(child);
                }
                return;
            }
            if (!CanClose(children.Child)) return;
            var saveIndex = childListBox.SelectedIndex;
            children.Close();
            childListBox.Items.Remove(children.Name);
            ChildrenForms.Remove(children);
            childListBox.SelectedIndex = saveIndex - 1;

        }

        private void childListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null)
            {
                childCoordLabel.Text = "Select form please ^_^";
                childPanel.Enabled = false;
                return;
            }
            childPanel.Enabled = true;
            UpdateChildCoord(child.Name);
            UpdateFormSizeInfo(child.Name);
        }

        public void UpdateChildCoord(string name)
        {
            var child = SelectedChild();
            if (child == null) return;
            if (child.Name != name) return;
            var location = child.GetLocation();
            childCoordLabel.Text = $"{location.X}; {location.Y}";
        }

        public void UpdateFormSizeInfo(string name)
        {
            var child = SelectedChild();
            if (child == null) return;
            if (child.Name != name) return;

            var size = child.Child.Size;
            childWidthResizeNumeric.Value = size.Width;
            childHeightResizeNumeric.Value = size.Height;
        }

        private void childChangeNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var child = SelectedChild();
                if (child == null) return;
                var newName = childChangeNameTextBox.Text;
                if (ChildrenForms.Find(el => el.Name == newName) != null) return;
                child.Name = newName;

                var selIndex = childListBox.SelectedIndex;

                childListBox.Items.Clear();

                var items = new List<string>() { "ко всем деткам" };
                items.AddRange(ChildrenForms.Select(f => f.Name));
                childListBox.Items.AddRange(items.ToArray());

                childListBox.SelectedIndex = selIndex;
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            foreach (var child in ChildrenForms)
            {
                child.Child.UpdateText();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null) return;
            child.Child.Visible = !child.Child.Visible;
        }

        private void svernutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null) return;
            child.Child.WindowState = FormWindowState.Minimized;
        }

        private void razvernutaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null) return;
            child.Child.WindowState = FormWindowState.Maximized;
        }

        private void defaultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null) return;
            child.Child.WindowState = FormWindowState.Normal;
        }

        private void childHeightResizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null) return;
            child.ReSize(child.Child.Size.Width, (int)childHeightResizeNumeric.Value);
        }

        private void childWidthResizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null) return;
            child.ReSize((int)childWidthResizeNumeric.Value, child.Child.Size.Height);
        }

        private void createAboutBttn_Click(object sender, EventArgs e)
        {
            Program.AboutForm.Show();
            aboutPanel.Enabled = true;
        }

        private void deleteAboutBttn_Click(object sender, EventArgs e)
        {
            Program.AboutForm.Close();
            Program.AboutForm = new About();
            aboutPanel.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Program.AboutForm.Visible = !Program.AboutForm.Visible;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Program.AboutForm.WindowState = FormWindowState.Minimized;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Program.AboutForm.WindowState = FormWindowState.Maximized;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Program.AboutForm.WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CanClose(this))
            {
                e.Cancel = true;
            }
        }

        private void selColorForm_Click(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null) return;

            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            child.Child.BackColor = colorDialog1.Color;
        }
    }
}