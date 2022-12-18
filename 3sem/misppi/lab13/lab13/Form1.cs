namespace lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _Wolf = Wolf.Location;
            _Rabbit = Rabbit.Location;
            _Fox = Fox.Location;
            _Bear = Bear.Location;
        }

        TextBox ownerTextBox;
        Label ownerLabel;

        Point _Wolf, _Rabbit, _Fox, _Bear;
        private void TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ownerTextBox = textBox;
            ownerLabel = (Label)Controls[ownerTextBox.Text];
            textBox.DoDragDrop(textBox.Text, DragDropEffects.Copy);
        }

        private void TextBox_DragOver(object sender, DragEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (ownerTextBox != null)
                ownerTextBox.BackColor = Color.White;

            if ((textBox != ownerTextBox && textBox.TextLength == 0) || (textBox.TextLength == 0 && textBox == ownerTextBox))
            {
                if (ownerLabel != null)
                    ownerLabel.Visible = false;

                textBox.Text = (string)e.Data.GetData(DataFormats.Text);

                if (textBox.Text != String.Empty)
                {
                    textBox.BackColor = Color.LightGray;
                }

                ownerLabel = (Label)Controls[textBox.Text];

                if (ownerTextBox != null && (!Controls.OfType<TextBox>().Any(x => x.Text == textBox.Text)))
                {
                    ownerTextBox.Text = String.Empty;
                    ownerTextBox = textBox;
                }
            }
        }

        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (((TextBox)sender).TextLength == 0 || ((TextBox)sender) == ownerTextBox)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                switch (ownerLabel.Text)
                {
                    case "Волк":
                        Controls[ownerLabel.Text].Location = _Wolf; break;
                    case "Заяц":
                        Controls[ownerLabel.Text].Location = _Rabbit; break;
                    case "Лиса":
                        Controls[ownerLabel.Text].Location = _Fox; break;
                    case "Медведь":
                        Controls[ownerLabel.Text].Location = _Bear; break;
                }
            }
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            ownerLabel = label;
            label.DoDragDrop(label.Text, DragDropEffects.Copy);
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            if (ownerLabel != null)
            {
                ownerLabel.Visible = true;
                Point point = PointToClient(Cursor.Position);
                ownerLabel.Location = new Point(point.X + 3, point.Y + 3);

                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    if (textBox.Text == ownerLabel.Text)
                    {
                        textBox.Text = String.Empty;
                        textBox.BackColor = Color.White;
                    }

                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}