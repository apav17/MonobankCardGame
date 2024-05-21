namespace MonobankCardGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            labelBanker = new Label();
            labelRound = new Label();
            buttonNoBet1 = new Button();
            buttonNextRound = new Button();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            labelGateCard = new Label();
            pictureGateCard = new PictureBox();
            groupCardLayout1 = new GroupBox();
            groupCardLayout2 = new GroupBox();
            trackBar1 = new TrackBar();
            label15 = new Label();
            buttonBet1 = new Button();
            panelBet1 = new Panel();
            panelEndGame = new Panel();
            labelResultGame = new Label();
            label1 = new Label();
            buttonMenu = new Button();
            buttonRestart = new Button();
            panelBet2 = new Panel();
            label16 = new Label();
            buttonNoBet2 = new Button();
            trackBar2 = new TrackBar();
            buttonBet2 = new Button();
            labelBankerMessage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            moveLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureGateCard).BeginInit();
            groupCardLayout1.SuspendLayout();
            groupCardLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panelBet1.SuspendLayout();
            panelEndGame.SuspendLayout();
            panelBet2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelBanker
            // 
            labelBanker.AutoSize = true;
            labelBanker.Font = new Font("Segoe UI", 20F);
            labelBanker.Location = new Point(443, 33);
            labelBanker.Name = "labelBanker";
            labelBanker.Size = new Size(105, 37);
            labelBanker.TabIndex = 2;
            labelBanker.Text = "Банкер";
            // 
            // labelRound
            // 
            labelRound.AutoSize = true;
            labelRound.Font = new Font("Segoe UI", 15F);
            labelRound.Location = new Point(12, 9);
            labelRound.Name = "labelRound";
            labelRound.Size = new Size(86, 28);
            labelRound.TabIndex = 3;
            labelRound.Text = "Раунд: 0";
            // 
            // buttonNoBet1
            // 
            buttonNoBet1.Location = new Point(78, 124);
            buttonNoBet1.Name = "buttonNoBet1";
            buttonNoBet1.Size = new Size(75, 23);
            buttonNoBet1.TabIndex = 5;
            buttonNoBet1.TabStop = false;
            buttonNoBet1.Text = "не ставить";
            buttonNoBet1.UseVisualStyleBackColor = true;
            buttonNoBet1.Click += buttonNoBet1_Click;
            // 
            // buttonNextRound
            // 
            buttonNextRound.Font = new Font("Segoe UI", 12F);
            buttonNextRound.Location = new Point(711, 229);
            buttonNextRound.Name = "buttonNextRound";
            buttonNextRound.Size = new Size(140, 63);
            buttonNextRound.TabIndex = 17;
            buttonNextRound.Text = "Следующий раунд";
            buttonNextRound.UseVisualStyleBackColor = true;
            buttonNextRound.Visible = false;
            buttonNextRound.Click += buttonNextRound_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(11, 18);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(84, 120);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 18;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(106, 18);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(84, 120);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 19;
            pictureBox12.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.Location = new Point(11, 19);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(84, 120);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 20;
            pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            pictureBox22.Location = new Point(106, 19);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(84, 120);
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.TabIndex = 21;
            pictureBox22.TabStop = false;
            // 
            // labelGateCard
            // 
            labelGateCard.AutoSize = true;
            labelGateCard.Font = new Font("Segoe UI", 15F);
            labelGateCard.Location = new Point(95, 151);
            labelGateCard.Name = "labelGateCard";
            labelGateCard.Size = new Size(124, 28);
            labelGateCard.TabIndex = 22;
            labelGateCard.Text = "Карта ворот";
            // 
            // pictureGateCard
            // 
            pictureGateCard.BorderStyle = BorderStyle.Fixed3D;
            pictureGateCard.Location = new Point(110, 194);
            pictureGateCard.Name = "pictureGateCard";
            pictureGateCard.Size = new Size(84, 120);
            pictureGateCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGateCard.TabIndex = 23;
            pictureGateCard.TabStop = false;
            // 
            // groupCardLayout1
            // 
            groupCardLayout1.Controls.Add(pictureBox11);
            groupCardLayout1.Controls.Add(pictureBox12);
            groupCardLayout1.Location = new Point(392, 105);
            groupCardLayout1.Name = "groupCardLayout1";
            groupCardLayout1.Size = new Size(202, 152);
            groupCardLayout1.TabIndex = 24;
            groupCardLayout1.TabStop = false;
            // 
            // groupCardLayout2
            // 
            groupCardLayout2.Controls.Add(pictureBox21);
            groupCardLayout2.Controls.Add(pictureBox22);
            groupCardLayout2.Location = new Point(392, 259);
            groupCardLayout2.Name = "groupCardLayout2";
            groupCardLayout2.Size = new Size(202, 152);
            groupCardLayout2.TabIndex = 25;
            groupCardLayout2.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 50;
            trackBar1.Location = new Point(8, 3);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 50;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 115);
            trackBar1.SmallChange = 50;
            trackBar1.TabIndex = 37;
            trackBar1.TickFrequency = 5;
            trackBar1.Value = 50;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(36, 48);
            label15.Name = "label15";
            label15.Size = new Size(28, 21);
            label15.TabIndex = 38;
            label15.Text = "50";
            // 
            // buttonBet1
            // 
            buttonBet1.Location = new Point(8, 124);
            buttonBet1.Name = "buttonBet1";
            buttonBet1.Size = new Size(65, 23);
            buttonBet1.TabIndex = 7;
            buttonBet1.TabStop = false;
            buttonBet1.Text = "ставка";
            buttonBet1.UseVisualStyleBackColor = true;
            buttonBet1.Click += buttonBet1_Click;
            // 
            // panelBet1
            // 
            panelBet1.Controls.Add(label15);
            panelBet1.Controls.Add(buttonNoBet1);
            panelBet1.Controls.Add(trackBar1);
            panelBet1.Controls.Add(buttonBet1);
            panelBet1.Location = new Point(621, 110);
            panelBet1.Name = "panelBet1";
            panelBet1.Size = new Size(156, 147);
            panelBet1.TabIndex = 39;
            panelBet1.Visible = false;
            // 
            // panelEndGame
            // 
            panelEndGame.AutoSize = true;
            panelEndGame.Controls.Add(labelResultGame);
            panelEndGame.Controls.Add(label1);
            panelEndGame.Location = new Point(621, 194);
            panelEndGame.Name = "panelEndGame";
            panelEndGame.Size = new Size(326, 164);
            panelEndGame.TabIndex = 54;
            panelEndGame.Visible = false;
            // 
            // labelResultGame
            // 
            labelResultGame.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResultGame.Location = new Point(2, 52);
            labelResultGame.Name = "labelResultGame";
            labelResultGame.Size = new Size(321, 28);
            labelResultGame.TabIndex = 1;
            labelResultGame.Text = "Победил Игрок 1";
            labelResultGame.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(102, 21);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 0;
            label1.Text = "Конец игры";
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.WhiteSmoke;
            buttonMenu.Location = new Point(857, 68);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(109, 25);
            buttonMenu.TabIndex = 3;
            buttonMenu.TabStop = false;
            buttonMenu.Text = "Выйти в меню";
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.WhiteSmoke;
            buttonRestart.Location = new Point(857, 95);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(109, 25);
            buttonRestart.TabIndex = 2;
            buttonRestart.TabStop = false;
            buttonRestart.Text = "Начать сначала";
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // panelBet2
            // 
            panelBet2.Controls.Add(label16);
            panelBet2.Controls.Add(buttonNoBet2);
            panelBet2.Controls.Add(trackBar2);
            panelBet2.Controls.Add(buttonBet2);
            panelBet2.Location = new Point(621, 261);
            panelBet2.Name = "panelBet2";
            panelBet2.Size = new Size(156, 150);
            panelBet2.TabIndex = 40;
            panelBet2.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(36, 51);
            label16.Name = "label16";
            label16.Size = new Size(28, 21);
            label16.TabIndex = 38;
            label16.Text = "50";
            // 
            // buttonNoBet2
            // 
            buttonNoBet2.Location = new Point(78, 127);
            buttonNoBet2.Name = "buttonNoBet2";
            buttonNoBet2.Size = new Size(75, 23);
            buttonNoBet2.TabIndex = 5;
            buttonNoBet2.TabStop = false;
            buttonNoBet2.Text = "не ставить";
            buttonNoBet2.UseVisualStyleBackColor = true;
            buttonNoBet2.Click += buttonNoBet2_Click;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 50;
            trackBar2.Location = new Point(8, 6);
            trackBar2.Maximum = 1000;
            trackBar2.Minimum = 50;
            trackBar2.Name = "trackBar2";
            trackBar2.Orientation = Orientation.Vertical;
            trackBar2.Size = new Size(45, 115);
            trackBar2.SmallChange = 50;
            trackBar2.TabIndex = 37;
            trackBar2.TickFrequency = 5;
            trackBar2.Value = 50;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // buttonBet2
            // 
            buttonBet2.Location = new Point(8, 127);
            buttonBet2.Name = "buttonBet2";
            buttonBet2.Size = new Size(65, 23);
            buttonBet2.TabIndex = 7;
            buttonBet2.TabStop = false;
            buttonBet2.Text = "ставка";
            buttonBet2.UseVisualStyleBackColor = true;
            buttonBet2.Click += buttonBet2_Click;
            // 
            // labelBankerMessage
            // 
            labelBankerMessage.AutoSize = true;
            labelBankerMessage.Font = new Font("Segoe UI", 12F);
            labelBankerMessage.ForeColor = Color.White;
            labelBankerMessage.Location = new Point(541, 23);
            labelBankerMessage.Name = "labelBankerMessage";
            labelBankerMessage.Size = new Size(133, 21);
            labelBankerMessage.TabIndex = 41;
            labelBankerMessage.Text = "Игрок 1, Ваш ход";
            labelBankerMessage.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Location = new Point(297, 123);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(89, 25);
            tableLayoutPanel1.TabIndex = 43;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Location = new Point(297, 278);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(89, 25);
            tableLayoutPanel2.TabIndex = 44;
            // 
            // moveLabel
            // 
            moveLabel.AutoSize = true;
            moveLabel.Font = new Font("Segoe UI", 20F);
            moveLabel.ForeColor = Color.Yellow;
            moveLabel.Location = new Point(134, 454);
            moveLabel.Name = "moveLabel";
            moveLabel.Size = new Size(28, 37);
            moveLabel.TabIndex = 48;
            moveLabel.Text = "*";
            moveLabel.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Location = new Point(3, 496);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(963, 45);
            flowLayoutPanel1.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelEndGame);
            panel1.Controls.Add(buttonNextRound);
            panel1.Controls.Add(panelBet2);
            panel1.Controls.Add(moveLabel);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(labelRound);
            panel1.Controls.Add(labelGateCard);
            panel1.Controls.Add(buttonMenu);
            panel1.Controls.Add(pictureGateCard);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(buttonRestart);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(labelBankerMessage);
            panel1.Controls.Add(groupCardLayout2);
            panel1.Controls.Add(labelBanker);
            panel1.Controls.Add(groupCardLayout1);
            panel1.Controls.Add(panelBet1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 599);
            panel1.TabIndex = 55;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 170, 85);
            ClientSize = new Size(970, 601);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Монтебанк для частного круга";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            Resize += Form2_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureGateCard).EndInit();
            groupCardLayout1.ResumeLayout(false);
            groupCardLayout2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panelBet1.ResumeLayout(false);
            panelBet1.PerformLayout();
            panelEndGame.ResumeLayout(false);
            panelEndGame.PerformLayout();
            panelBet2.ResumeLayout(false);
            panelBet2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelBanker;
        private Label labelRound;
        private Button buttonNextRound;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private Label labelGateCard;
        private PictureBox pictureGateCard;
        private GroupBox groupCardLayout1;
        private GroupBox groupCardLayout2;
        private Button buttonNoBet1;
        private TrackBar trackBar1;
        private Label label15;
        private Button buttonBet1;
        private Panel panelBet1;
        private Panel panelBet2;
        private Label label16;
        private Button buttonNoBet2;
        private TrackBar trackBar2;
        private Button buttonBet2;
        private Label labelBankerMessage;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label moveLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelEndGame;
        private Button buttonRestart;
        private Label labelResultGame;
        private Label label1;
        private Button buttonMenu;
        private Panel panel1;
    }
}