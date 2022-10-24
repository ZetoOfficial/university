namespace lab4_task3
{
    public partial class SniperGameForm : Form
    {
        private Sniper Game { get; set; }
        private string defaultFormMessage;

        public SniperGameForm()
        {
            InitializeComponent();
            defaultFormMessage = this.Text;
            Game = new Sniper(this.Size.Width, this.Size.Height);
            StatsUpdate();
        }
        private void StatsUpdate()
        {
            this.Text = $"{defaultFormMessage} | Shots: {Game.ShotsCount} Points: {Game.ShotsPoints}";
        }
        private void ShowTarget()
        {
            ResultPoints results = Game.GetResults();
            foreach (var playerShot in results.Trying)
            {
                this.Controls.Add(new Label { Text = "X", Location = playerShot, AutoSize = true });
            }
            
            this.Controls.Add(new Label { Text = "O", Location = results.Center, AutoSize = true });
        }
        private void SniperGameForm_MouseClick(object sender, MouseEventArgs e)
        {
            int points = Game.Shot(e.Location);
            ShowTarget();
            StatsUpdate();
            if (Game.ShotsCount == 10)
            {
                // ShowTarget();
                MessageBox.Show($"Вы набрали {Game.ShotsPoints} очков за {Game.ShotsCount} выстрелов!", "Игра закончена!");
                Game.RestartGame();
                StatsUpdate();
                this.Controls.Clear();
            }
            if (points == 10)
            {
                // ShowTarget();
                MessageBox.Show($"Вы набрали попали в десятку с {Game.ShotsCount} выстрела!", "Победа!");
                Game.RestartGame();
                StatsUpdate();
                this.Controls.Clear();
            }
        }
    }
}