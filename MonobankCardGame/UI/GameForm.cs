using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonobankCardGame.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;
using Label = System.Windows.Forms.Label;

namespace MonobankCardGame
{
    public partial class GameForm : Form
    {
        private int currentMovePlayer = -1;
        private Game game;
        private Image[] chipImages = { Properties.Resources.red_chip, Properties.Resources.blue_chip, Properties.Resources.orange_chip, Properties.Resources.purple_chip };

        public GameForm(List<Player> players)
        {
            InitializeComponent();
            game = new Game(players);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowPlayers();
            StartRound();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;
        }

        private Image getImageCard(string card)
        {
            Image imageCards = Properties.Resources.cards;
            double cardWidth = imageCards.Width / 13.0;
            double cardHeight = imageCards.Height / 4.0;

            Bitmap imageCard = new Bitmap((int)cardWidth, (int)cardHeight);

            var cardValues = new Dictionary<char, int>() { ['A'] = 0, ['2'] = 1, ['3'] = 2, ['4'] = 3, ['5'] = 4, ['6'] = 5, ['7'] = 6, ['J'] = 10, ['Q'] = 11, ['K'] = 12 };
            var cardSuits = new Dictionary<char, int>() { ['H'] = 0, ['D'] = 1, ['C'] = 2, ['S'] = 3 };

            int x = (int)(cardWidth * cardValues[card[0]]);
            int y = (int)(cardHeight * cardSuits[card[1]]);

            Rectangle sourceRectangle = new Rectangle(x, y, (int)cardWidth, (int)cardHeight);

            using (Graphics graphics = Graphics.FromImage(imageCard))
            {
                graphics.DrawImage(imageCards, 0, 0, sourceRectangle, GraphicsUnit.Pixel);
            }

            return imageCard;
        }

        private async void ShowCardsLayouts()
        {
            string card11 = game.CurrentRound!.firstCardLayout.firstCard;
            string card12 = game.CurrentRound.firstCardLayout.secondCard;
            string card21 = game.CurrentRound.secondCardLayout.firstCard;
            string card22 = game.CurrentRound.secondCardLayout.secondCard;

            await Task.Delay(1000);
            pictureBox11.Image = getImageCard(card11);
            await Task.Delay(500);
            pictureBox12.Image = getImageCard(card12);
            await Task.Delay(500);
            pictureBox21.Image = getImageCard(card21);
            await Task.Delay(500);
            pictureBox22.Image = getImageCard(card22);
        }

        private void ShowGateCard(string gateCard)
        {
            pictureGateCard.Image = getImageCard(gateCard);
            pictureGateCard.Show();
        }

        private async void StartRound()
        {
            buttonRestart.Enabled = false;
            game.StartRound();
            currentMovePlayer = -1;

            pictureGateCard.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            trackBar1.Value = 50;
            trackBar2.Value = 50;
            label15.Text = "50";
            label16.Text = "50";
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.RowCount = 1;
            moveLabel.Hide();

            for (int i = 0; i < game.players.Count; i++)
            {
                if (game.players[i].chips == 0)
                {
                    foreach (Control control in flowLayoutPanel1.Controls[i].Controls)
                    {
                        control.Hide();
                    }
                }
            }

            labelRound.Text = $"Раунд {game.CurrentRound!.number} из 6";

            UpdateChips();
            ShowCardsLayouts();
            await Task.Delay(3000);
            MoveTransition();
            buttonRestart.Enabled = true;
        }

        private void ShowPlayers()
        {
            for (int i = 0; i < game.players.Count; i++)
            {
                Panel playerPanel = new Panel()
                {
                    Width = flowLayoutPanel1.Width / game.players.Count,
                    Height = 80,
                    Margin = new Padding(0),
                };

                Label nameLabel = new Label()
                {
                    Text = game.players[i].name,
                    AutoSize = true,
                    Font = new Font(Font.FontFamily, 20, Font.Style),
                    Margin = new Padding(0),
                };

                Panel chipsPanel = new Panel()
                {
                    AutoSize = true,
                    Width = 0,
                    Height = 0,
                    Padding = new Padding(0),
                };

                PictureBox chipsPictureBox = new PictureBox()
                {
                    Image = chipImages[i],
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 25,
                    Height = 25,
                };

                Label chipsLabel = new Label()
                {
                    Name = "chipsLabel" + i.ToString(),
                    Text = "1000",
                    Font = new Font(Font.FontFamily, 12, Font.Style),
                    AutoSize = true,
                    Margin = new Padding(0),
                    Location = new Point(25, 0),
                };

                chipsPanel.Controls.Add(chipsPictureBox);
                chipsPanel.Controls.Add(chipsLabel);

                playerPanel.Controls.Add(nameLabel);
                playerPanel.Controls.Add(chipsPanel);

                flowLayoutPanel1.Controls.Add(playerPanel);

                nameLabel.Location = new Point((playerPanel.Width - nameLabel.Width) / 2, 0);
                chipsPanel.Location = new Point((playerPanel.Width - chipsPanel.Width) / 2 - 5, nameLabel.Height + 5);
            }
        }

        private void UpdateChips()
        {
            for (int i = 0; i < game.players.Count; i++)
            {
                Label? chipsLabel = Controls.Find("chipsLabel" + i.ToString(), true).FirstOrDefault() as Label;
                chipsLabel!.Text = game.players[i].chips.ToString();
            }
        }

        private void UpdateChipsWithWin()
        {
            for (int i = 0; i < game.players.Count; i++)
            {
                if (game.players[i].currentRoundWinChips != 0)
                {
                    Label? chipsLabel = Controls.Find("chipsLabel" + i.ToString(), true).FirstOrDefault() as Label;
                    chipsLabel!.Text += $" + {game.players[i].currentRoundWinChips}";
                }
            }
        }

        private async void EndRound()
        {
            buttonRestart.Enabled = false;
            panelBet1.Hide();
            moveLabel.Hide();
            labelBankerMessage.Text = "";

            var gateCard = game.banker.OpenGateCard();
            await Task.Delay(1000);
            ShowGateCard(gateCard);
            game.CurrentRound!.CalculateBets(gateCard);
            await Task.Delay(1000);
            UpdateChipsWithWin();

            if (game.CurrentRound.firstCardLayoutWin && !game.CurrentRound.secondCardLayoutWin)
                labelBankerMessage.Text = "Верхний расклад выиграл. Ставки рассчитаны";
            else if (!game.CurrentRound.firstCardLayoutWin && game.CurrentRound.secondCardLayoutWin)
                labelBankerMessage.Text = "Нижний расклад выиграл. Ставки рассчитаны";
            else if (game.CurrentRound.firstCardLayoutWin && game.CurrentRound.secondCardLayoutWin)
                labelBankerMessage.Text = "Оба расклада выиграли. Ставки рассчитаны";
            else
                labelBankerMessage.Text = "Оба расклада проиграли. Все ставки проиграны";

            buttonRestart.Enabled = true;

            if (game.CurrentRound.number == 6 || game.PlayersWithChipsCount == 0 || game.PlayersWithChipsCount == 1)
            {
                EndGame();
                return;
            }
            buttonNextRound.Show();
            buttonNextRound.Focus();
        }

        private void EndGame()
        {
            Player? winner = game.GetWinner();
            if (winner != null)
            {
                labelResultGame.Text = $"Победил {winner.name}";
            }
            else
            {
                labelResultGame.Text = "Победитель не выявлен";
            }
            panelBet1.Hide();
            panelEndGame.Show();
            panelEndGame.BringToFront();
        }

        private void MoveTransition()
        {
            currentMovePlayer++;
            if (currentMovePlayer >= game.players.Count)
            {
                EndRound();
                return;
            }
            if (game.players[currentMovePlayer].chips == 0)
            {
                MoveTransition();
                return;
            }
            labelBankerMessage.Show();
            labelBankerMessage.Text = $"{game.players[currentMovePlayer].name}, Ваш ход";
            trackBar1.Maximum = game.players[currentMovePlayer].chips;
            trackBar1.Value = 50;
            label15.Text = "50";
            panelBet1.Show();
            moveLabel.Location = new Point(flowLayoutPanel1.Location.X + flowLayoutPanel1.Controls[currentMovePlayer].Location.X + flowLayoutPanel1.Controls[currentMovePlayer].Width / 2 - 14, flowLayoutPanel1.Location.Y - 26);
            moveLabel.Show();
        }

        private void ShowBet(int amount, TableLayoutPanel table)
        {
            PictureBox pictureBox = new PictureBox() { Image = chipImages[currentMovePlayer], SizeMode = PictureBoxSizeMode.StretchImage, Width = 25, Height = 25 };
            Label label = new Label() { Text = amount.ToString(), Font = new Font(Font.FontFamily, 12, Font.Style), AutoSize = true, Padding = new Padding(0, 3, 0, 0) };
            int rowIndex = table.RowCount == 1 ? 0 : table.RowCount - 1;
            table.RowCount++;
            table.Controls.Add(pictureBox, 0, rowIndex);
            table.Controls.Add(label, 1, rowIndex);
        }

        private void buttonNextRound_Click(object sender, EventArgs e)
        {
            StartRound();
            buttonNextRound.Hide();
            labelBankerMessage.Hide();
        }

        private void buttonBet1_Click(object sender, EventArgs e)
        {
            int amount = trackBar1.Value;
            var player = game.players[currentMovePlayer];
            player.MakeBet(amount, 1, game.CurrentRound!);
            ShowBet(amount, tableLayoutPanel1);
            UpdateChips();
            if (game.players[currentMovePlayer].chips == 0)
            {
                MoveTransition();
                return;
            }
            panelBet1.Hide();
            panelBet2.Show();
            trackBar2.Maximum = game.players[currentMovePlayer].chips;
            trackBar2.Value = 50;
            label16.Text = "50";
        }

        private void buttonNoBet1_Click(object sender, EventArgs e)
        {
            panelBet1.Hide();
            panelBet2.Show();
            trackBar2.Maximum = game.players[currentMovePlayer].chips;
            trackBar2.Value = 50;
            label16.Text = "50";
        }

        private void buttonBet2_Click(object sender, EventArgs e)
        {
            int amount = trackBar2.Value;
            var player = game.players[currentMovePlayer];
            player.MakeBet(amount, 2, game.CurrentRound!);
            ShowBet(amount, tableLayoutPanel2);
            UpdateChips();
            panelBet2.Hide();
            MoveTransition();
        }

        private void buttonNoBet2_Click(object sender, EventArgs e)
        {
            panelBet2.Hide();
            MoveTransition();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int remainder = trackBar1.Value % 50;
            if (remainder != 0)
            {
                if (remainder < 25)
                {
                    trackBar1.Value -= remainder;
                }
                else
                {
                    trackBar1.Value += 50 - remainder;
                }
            }
            label15.Text = trackBar1.Value.ToString();
            buttonBet1.Focus();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            int remainder = trackBar2.Value % 50;
            if (remainder != 0)
            {
                if (remainder < 25)
                {
                    trackBar2.Value -= remainder;
                }
                else
                {
                    trackBar2.Value += 50 - remainder;
                }
            }
            label16.Text = trackBar2.Value.ToString();
            buttonBet2.Focus();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form f1 = new StartForm();
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = Location;
            f1.Size = Size;
            f1.Show();
            Hide();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            game.Restart();
            panelEndGame.Hide();
            panelBet1.Hide();
            panelBet2.Hide();
            buttonNextRound.Hide();
            labelBankerMessage.Hide();
            for (int i = 0; i < game.players.Count; i++)
            {
                foreach (Control control in flowLayoutPanel1.Controls[i].Controls)
                {
                    control.Show();
                }
            }
            StartRound();
        }
    }
}
