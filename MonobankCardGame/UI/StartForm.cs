using System.Windows.Forms;
using MonobankCardGame.Models;

namespace MonobankCardGame
{
    public partial class StartForm : Form
    {
        private int playersCount = 2;

        public StartForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var players = new List<Player>();
            foreach (TextBox textBox in new TextBox[] { textBox1, textBox2, textBox3, textBox4 })
            {
                if (textBox.Visible == true)
                {
                    players.Add(new Player(textBox.Text));
                }
            }
            Form f2 = new GameForm(players);
            f2.Location = Location;
            f2.Size = Size;
            f2.Show();
            Hide();
        }

        private void addPalyerButton_Click(object sender, EventArgs e)
        {
            if (playersCount == 2)
            {
                label6.Show();
                textBox3.Show();
                deletePlayerButton.Show();
            }
            else if (playersCount == 3)
            {
                label5.Show();
                textBox4.Show();
                addPalyerButton.Enabled = false;
            }

            startButton.Location = new Point(startButton.Location.X, startButton.Location.Y + 52);
            playersCount++;
        }

        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            if (playersCount == 3)
            {
                label6.Hide();
                textBox3.Hide();
                deletePlayerButton.Hide();
            }

            else if (playersCount == 4)
            {
                label5.Hide();
                textBox4.Hide();
                addPalyerButton.Enabled = true;
            }

            startButton.Location = new Point(startButton.Location.X, startButton.Location.Y - 52);
            playersCount--;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;
        }
    }
}
