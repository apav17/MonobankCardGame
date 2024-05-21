namespace MonobankCardGame
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            startButton = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            addPalyerButton = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            deletePlayerButton = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 12F);
            startButton.Location = new Point(400, 300);
            startButton.Name = "startButton";
            startButton.Size = new Size(188, 36);
            startButton.TabIndex = 0;
            startButton.TabStop = false;
            startButton.Text = "Начать игру";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(430, 109);
            label2.Name = "label2";
            label2.Size = new Size(129, 45);
            label2.TabIndex = 4;
            label2.Text = "Игроки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(359, 186);
            label3.Name = "label3";
            label3.Size = new Size(30, 30);
            label3.TabIndex = 5;
            label3.Text = "1.";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(400, 183);
            textBox1.MaxLength = 12;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 36);
            textBox1.TabIndex = 6;
            textBox1.TabStop = false;
            textBox1.Text = "Игрок 1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // addPalyerButton
            // 
            addPalyerButton.BackColor = SystemColors.ControlLightLight;
            addPalyerButton.Font = new Font("Segoe UI", 12F);
            addPalyerButton.Location = new Point(147, 186);
            addPalyerButton.Name = "addPalyerButton";
            addPalyerButton.Size = new Size(143, 36);
            addPalyerButton.TabIndex = 7;
            addPalyerButton.TabStop = false;
            addPalyerButton.Text = "Добавить игрока";
            addPalyerButton.UseVisualStyleBackColor = false;
            addPalyerButton.Click += addPalyerButton_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(400, 235);
            textBox2.MaxLength = 12;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 36);
            textBox2.TabIndex = 9;
            textBox2.TabStop = false;
            textBox2.Text = "Игрок 2";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(360, 238);
            label4.Name = "label4";
            label4.Size = new Size(30, 30);
            label4.TabIndex = 8;
            label4.Text = "2.";
            // 
            // deletePlayerButton
            // 
            deletePlayerButton.BackColor = SystemColors.ControlLightLight;
            deletePlayerButton.Font = new Font("Segoe UI", 12F);
            deletePlayerButton.Location = new Point(147, 232);
            deletePlayerButton.Name = "deletePlayerButton";
            deletePlayerButton.Size = new Size(143, 36);
            deletePlayerButton.TabIndex = 10;
            deletePlayerButton.TabStop = false;
            deletePlayerButton.Text = "Удалить игрока";
            deletePlayerButton.UseVisualStyleBackColor = false;
            deletePlayerButton.Visible = false;
            deletePlayerButton.Click += deletePlayerButton_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(400, 287);
            textBox3.MaxLength = 12;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 36);
            textBox3.TabIndex = 14;
            textBox3.TabStop = false;
            textBox3.Text = "Игрок 3";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(361, 343);
            label5.Name = "label5";
            label5.Size = new Size(30, 30);
            label5.TabIndex = 13;
            label5.Text = "4.";
            label5.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F);
            textBox4.Location = new Point(400, 339);
            textBox4.MaxLength = 12;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 36);
            textBox4.TabIndex = 12;
            textBox4.TabStop = false;
            textBox4.Text = "Игрок 4";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(360, 291);
            label6.Name = "label6";
            label6.Size = new Size(30, 30);
            label6.TabIndex = 11;
            label6.Text = "3.";
            label6.Visible = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(addPalyerButton);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(deletePlayerButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 600);
            panel1.TabIndex = 15;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 170, 85);
            ClientSize = new Size(970, 601);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Монтебанк для частного круга";
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button addPalyerButton;
        private TextBox textBox2;
        private Label label4;
        private Button deletePlayerButton;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Panel panel1;
    }
}
