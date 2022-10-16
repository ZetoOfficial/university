namespace lab4_task1
{
    public partial class FirstForm : Form
    {
        public Size FormDefaultSize { get; set; }

        public FirstForm()
        {
            InitializeComponent();
            this.FormDefaultSize = this.Size;
        }

        private void FirstForm_MouseMove(object sender, MouseEventArgs e)
        {
            var shadesNum = 256;

            ActiveForm.BackColor = Color.FromArgb(
                Math.Abs(e.Location.X % shadesNum),
                Math.Abs(e.Location.Y % shadesNum),
                Math.Abs((e.Location.X + e.Location.Y) / 2 % shadesNum)
            );
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            if (ResizeButton.Visible)
            {
                this.Size = this.FormDefaultSize;
                ResizeButton.Visible = false;
            }
        }

        private void FirstForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Location.X <= 20 && e.Location.Y <= 20 && !ResizeButton.Visible)
            {
                ResizeButton.Visible = true;
            }
        }

        private void CustomCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}