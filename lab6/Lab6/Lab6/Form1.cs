using System.Media;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public QuadraticEquation quadraticEquation = new QuadraticEquation();
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
            /*
            можно вводить только действительные числа
            все остальные символы должны игнорироваться, т.ч. вторая и последующие запятые минус на втором и последующих местах
            123123,123123123123
            123123123/123123123
             */
            var allowSigns = new List<Char>() { '.', '/' };
            int allowCharCount = text.Where(el => el == newChar).ToArray().Length;
            
            if (!Char.IsDigit(newChar) && !allowSigns.Contains(newChar) && allowCharCount > 1) return true;
            if (!Char.IsDigit(newChar)) return true;
            return false;
        }
        
        private void AInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            e.Handled = validateInput(AInput.Text, number);
            if (!validateInput(AInput.Text, number))
            {
                AnswerLabel.Text = AInput.Text + number;
                //quadraticEquation.A = Convert.ToDouble(AInput.Text);
            }
        }

        private void CalcKva_Click(object sender, EventArgs e)
        {
            AnswerLabel.Text = quadraticEquation.Solve();
        }
    }
}