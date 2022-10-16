namespace lab4_task2
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }
        private bool isEven = false;

        private void Red_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(255, 255, 0);
        }

        private void Green_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(0, 0, 255);
        }

        private void SecondForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isEven)
            {
                Random random = new Random();
                ActiveForm.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            }
            else
            {
                ActiveForm.BackColor = Color.FromArgb(255, 255, 255);
            }
            isEven = !isEven;
        }
    }
}