using System.Media;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public QuadraticEquation quadraticEquation = new QuadraticEquation();
        public BiquadraticEquation biquadraticEquation = new BiquadraticEquation();

        public string DefaultFormText { get; set; }
        public bool IsChangeColorActive { get; set; }

        public Form1()
        {
            InitializeComponent();
            DefaultFormText = Text;
            IsChangeColorActive = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsChangeColorActive) return;
            double x = Math.Abs((double)e.X / this.Size.Width * 255);
            double y = Math.Abs((double)e.Y / this.Size.Height * 255);
            this.BackColor = Color.FromArgb((int)x, (int)y + 5, (int)y + 5);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var exitAnswer = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo);
            e.Cancel = exitAnswer == DialogResult.No;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode.ToString() == "X" || e.KeyCode.ToString() == "F10")
                Application.Exit();
            if (e.Control && e.Alt && e.KeyCode.ToString() == "C")
            {
                this.BackColor = Color.White;
                IsChangeColorActive = !IsChangeColorActive;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    if (this.Top > 0)
                        Top -= 10;
                    return;
                case "Down":
                    if ((this.Top + this.Height) < Screen.PrimaryScreen.Bounds.Bottom)
                        Top += 10; return;
                case "Left":
                    if (this.Left > 0)
                        Left -= 10; return;
                case "Right":
                    if ((this.Left + this.Width) < Screen.PrimaryScreen.Bounds.Right)
                        Left += 10; return;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Shift && e.Button == MouseButtons.Right)
            {
                this.Width += 5 * 2;
                this.Height += 5 * 2;
                this.Text = $"{DefaultFormText} | {Width} x {Height}";
                Location = new Point(Location.X - 5, Location.Y);
                SystemSounds.Exclamation.Play();
            }
            else if (e.Button == MouseButtons.Right && ModifierKeys != Keys.Shift)
            {
                this.Width -= 5 * 2;
                this.Height -= 5 * 2;
                this.Text = $"{DefaultFormText} | {Width} x {Height}";
                Location = new Point(Location.X + 5, Location.Y);
                SystemSounds.Exclamation.Play();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                Location = new Point(Cursor.Position.X - Width / 2, Cursor.Position.Y - Height / 2);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                Location = new Point(Cursor.Position.X - Width / 2, Cursor.Position.Y - Height / 2);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left | MouseButtons == MouseButtons.Right)
            {
                Location = new Point(Cursor.Position.X - Width / 2, Cursor.Position.Y - Height / 2);
            }
        }
        private bool validateInput(string text, char newChar)
        {
            var allowSigns = new List<Char>() { '.' };
            int charCount = text.Where(e1 => allowSigns.Contains(e1)).ToArray().Length;

            var backSpace = (char)8;
            var maxAllowSignsCountInText = 1;
            if (newChar == backSpace || Char.IsDigit(newChar) || !Char.IsDigit(newChar) && text.Length == 0 && newChar == '-' || !Char.IsDigit(newChar) && allowSigns.Contains(newChar) && charCount < maxAllowSignsCountInText) return true;
            return false;
        }
        
        private void AInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char newChar = e.KeyChar;
            e.Handled = !validateInput(AInput.Text, newChar);
        }

        private void BInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char newChar = e.KeyChar;
            e.Handled = !validateInput(BInput.Text, newChar);
        }

        private void CInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char newChar = e.KeyChar;
            e.Handled = !validateInput(CInput.Text, newChar);
        }
        private bool ValidateBoxes()
        {
            if (AInput.Text == "" || BInput.Text == "" || CInput.Text == "")
            {
                MessageBox.Show("Введите a/b/c", "Ошибка");
                return false;
            }
            return true;
        }
        private void CalcQuadraticEquation_Click(object sender, EventArgs e)
        {
            if (!ValidateBoxes()) return;
            quadraticEquation.A = Convert.ToDouble(AInput.Text);
            quadraticEquation.B = Convert.ToDouble(BInput.Text);
            quadraticEquation.C = Convert.ToDouble(CInput.Text);
            AnswerLabel.Text = quadraticEquation.Solve();
        }

        private void CalcBiquadraticEquation_Click(object sender, EventArgs e)
        {
            if (!ValidateBoxes()) return;
            biquadraticEquation.A = Convert.ToDouble(AInput.Text);
            biquadraticEquation.B = Convert.ToDouble(BInput.Text);
            biquadraticEquation.C = Convert.ToDouble(CInput.Text);
            AnswerLabel.Text = biquadraticEquation.Solve();
        }
    }
}