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

        public ChildForAFee? SelectedChild()
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

            checkBox1.Checked = true;
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
                childPanel.Enabled = ChildrenForms.Count != 0;
                return;
            }
            if (!CanClose(children.Child)) return;
            var saveIndex = childListBox.SelectedIndex;
            children.Close();
            childListBox.Items.Remove(children.Name);
            ChildrenForms.Remove(children);
            childListBox.SelectedIndex = saveIndex - 1;
            childPanel.Enabled = ChildrenForms.Count != 0;
        }

        private void childListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            childPanel.Enabled = ChildrenForms.Count != 0;
            if (child == null)
            {
                childCoordLabel.Text = "Select form please ^_^";
                checkBox1.Enabled = ChildrenForms.All(el => el.Child.Visible);
                return;
            }
            checkBox1.Enabled = true;
            checkBox1.Checked = child.Child.Visible;
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
                var newName = childChangeNameTextBox.Text;
                if (ChildrenForms.Find(el => el.Name == newName) != null) return;

                var child = SelectedChild();
                if (child == null)
                {
                    foreach (var children in ChildrenForms.ToList())
                        children.Name = newName;
                }
                else { child.Name = newName; }

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
            if (child == null)
            {
                foreach (var children in ChildrenForms.ToList())
                    children.Child.Visible = !children.Child.Visible;
            }
            else
            {
                child.Child.Visible = !child.Child.Visible;
            }
        }

        private void svernutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null)
            {
                foreach (var children in ChildrenForms.ToList())
                    children.Child.WindowState = FormWindowState.Minimized;
            }
            else 
            {
                child.Child.WindowState = FormWindowState.Minimized;
            }
        }

        private void razvernutaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null)
            {
                foreach (var children in ChildrenForms.ToList())
                    children.Child.WindowState = FormWindowState.Maximized;
            }
            else
            {
                child.Child.WindowState = FormWindowState.Maximized;
            }
        }

        private void defaultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null)
            {
                foreach (var children in ChildrenForms.ToList())
                    children.Child.WindowState = FormWindowState.Normal;
            }
            else
            {
                child.Child.WindowState = FormWindowState.Normal;
            }
        }

        private void childHeightResizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null)
            {
                foreach (var children in ChildrenForms.ToList())
                    children.ReSize(children.Child.Size.Width, (int)childHeightResizeNumeric.Value);
                return;
            }
            child.ReSize(child.Child.Size.Width, (int)childHeightResizeNumeric.Value);
        }

        private void childWidthResizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            var child = SelectedChild();
            if (child == null)
            {
                foreach (var children in ChildrenForms.ToList())
                    children.ReSize((int)childWidthResizeNumeric.Value, children.Child.Size.Height);
                return;
            }
            child.ReSize((int)childWidthResizeNumeric.Value, child.Child.Size.Height);
        }

        private void createAboutBttn_Click(object sender, EventArgs e)
        {
            Program.AboutForm.Show();
            this.Enabled = false;
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
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var child = SelectedChild();
            if (child == null)
            {
                foreach (var children in ChildrenForms.ToList())
                    children.Child.BackColor = colorDialog1.Color;
            }
            else
            {
                child.Child.BackColor = colorDialog1.Color;
            }
        }
    }
}