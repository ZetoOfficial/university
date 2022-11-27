namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

            toolTip1.SetToolTip(button1, "переключает видимость 2-й и 3-й (видна только одна из кнопок по очереди)");
            toolTip1.SetToolTip(button2, "раздвигает форму на 5 пикселей во все стороны.");
            toolTip1.SetToolTip(button3, "вкл/выкл 1-полужирн., 2-накл., 3-подчерк. стили шрифтов на форме");
            toolTip1.SetToolTip(button4, "перебирает тип рамки (по кругу из 5-ти).");
        }

        bool swipe = false;
        FormBorderStyle[] borderStyles = new FormBorderStyle[] { FormBorderStyle.Fixed3D, FormBorderStyle.None, FormBorderStyle.Sizable, FormBorderStyle.FixedSingle, FormBorderStyle.FixedDialog };
        int borderStyle = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = swipe;
            button3.Visible = !swipe;
            swipe = !swipe;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width += 5 * 2;
            this.Height += 5 * 2;
            Location = new Point(Location.X - 5, Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Shift) this.Font = new Font(this.Font, this.Font.Italic == true ? this.Font.Style & ~FontStyle.Italic : this.Font.Style | FontStyle.Italic);
            else if (ModifierKeys == Keys.Control) this.Font = new Font(this.Font, this.Font.Underline == true ? this.Font.Style & ~FontStyle.Underline : this.Font.Style | FontStyle.Underline);
            else this.Font = new Font(this.Font, this.Font.Bold == true ? this.Font.Style & ~FontStyle.Bold : this.Font.Style | FontStyle.Bold);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Size.Width + 10 > 600 && Size.Height + 10 > 400) return;
            this.FormBorderStyle = borderStyles[borderStyle];
            this.Text = FormBorderStyle.ToString();
            borderStyle = (borderStyle + 1) % 5;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Alt) && (e.KeyCode == Keys.I))
            {
                this.Controls.Clear();
                InitializeComponent();
            }
            else if ((e.Modifiers == Keys.Alt) && (e.KeyCode == Keys.X))
            {
                this.Close();
            }
        }
    }
}