using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;

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
            Game = new Sniper(this.Size.Width, this.Size.Height, padding: 30);
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
            Game.Shot(e.Location);
            StatsUpdate();
            if (Game.ShotsPoints >= 10)
            {
                ShowTarget();
                MessageBox.Show($"Вы набрали {Game.ShotsPoints}/10 очков за {Game.ShotsCount} выстрела(ов)!", "Победа!");
                Game.RestartGame();
                StatsUpdate();
                this.Controls.Clear();
            }
        }
    }
}