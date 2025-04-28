namespace Windows_Forms_PinPon_Oyunu
{
    partial class gameForm
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
            components = new System.ComponentModel.Container();
            game_panel = new Panel();
            score_lbl = new Label();
            scoreText_lbl = new Label();
            ball = new PictureBox();
            gameOver_panel = new GroupBox();
            exit_btn = new Button();
            gameOver_lbl = new Label();
            restart_btn = new Button();
            table = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            gameOver_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // game_panel
            // 
            game_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            game_panel.Controls.Add(score_lbl);
            game_panel.Controls.Add(scoreText_lbl);
            game_panel.Controls.Add(ball);
            game_panel.Controls.Add(gameOver_panel);
            game_panel.Controls.Add(table);
            game_panel.Dock = DockStyle.Fill;
            game_panel.Location = new Point(0, 0);
            game_panel.Name = "game_panel";
            game_panel.Size = new Size(800, 450);
            game_panel.TabIndex = 0;
            // 
            // score_lbl
            // 
            score_lbl.AutoSize = true;
            score_lbl.Font = new Font("Segoe UI", 15F);
            score_lbl.Location = new Point(107, 9);
            score_lbl.Name = "score_lbl";
            score_lbl.Size = new Size(28, 35);
            score_lbl.TabIndex = 5;
            score_lbl.Text = "0";
            // 
            // scoreText_lbl
            // 
            scoreText_lbl.AutoSize = true;
            scoreText_lbl.Font = new Font("Segoe UI", 15F);
            scoreText_lbl.Location = new Point(12, 9);
            scoreText_lbl.Name = "scoreText_lbl";
            scoreText_lbl.Size = new Size(89, 35);
            scoreText_lbl.TabIndex = 4;
            scoreText_lbl.Text = "Score :";
            // 
            // ball
            // 
            ball.BackColor = Color.OrangeRed;
            ball.Location = new Point(50, 65);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.TabIndex = 3;
            ball.TabStop = false;
            // 
            // gameOver_panel
            // 
            gameOver_panel.BackColor = Color.Transparent;
            gameOver_panel.BackgroundImageLayout = ImageLayout.None;
            gameOver_panel.Controls.Add(exit_btn);
            gameOver_panel.Controls.Add(gameOver_lbl);
            gameOver_panel.Controls.Add(restart_btn);
            gameOver_panel.Location = new Point(135, 101);
            gameOver_panel.Name = "gameOver_panel";
            gameOver_panel.Size = new Size(500, 250);
            gameOver_panel.TabIndex = 2;
            gameOver_panel.TabStop = false;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.RosyBrown;
            exit_btn.Font = new Font("Segoe UI", 11F);
            exit_btn.Location = new Point(255, 180);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(245, 70);
            exit_btn.TabIndex = 4;
            exit_btn.Text = "Çıkış";
            exit_btn.UseVisualStyleBackColor = false;
            // 
            // gameOver_lbl
            // 
            gameOver_lbl.AutoSize = true;
            gameOver_lbl.Font = new Font("Segoe UI", 40F);
            gameOver_lbl.Location = new Point(98, 23);
            gameOver_lbl.Name = "gameOver_lbl";
            gameOver_lbl.Size = new Size(317, 89);
            gameOver_lbl.TabIndex = 3;
            gameOver_lbl.Text = "Kaybettin";
            // 
            // restart_btn
            // 
            restart_btn.BackColor = Color.DarkSeaGreen;
            restart_btn.Font = new Font("Segoe UI", 11F);
            restart_btn.Location = new Point(0, 180);
            restart_btn.Name = "restart_btn";
            restart_btn.Size = new Size(245, 70);
            restart_btn.TabIndex = 2;
            restart_btn.Text = "Tekrar Oyna";
            restart_btn.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            table.BackColor = Color.Black;
            table.Location = new Point(292, 381);
            table.Name = "table";
            table.Size = new Size(200, 20);
            table.TabIndex = 0;
            table.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(game_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gameForm";
            Text = "Pin Pon Oyunu";
            WindowState = FormWindowState.Maximized;
            game_panel.ResumeLayout(false);
            game_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            gameOver_panel.ResumeLayout(false);
            gameOver_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel game_panel;
        private PictureBox table;
        private GroupBox gameOver_panel;
        private Button exit_btn;
        private Button restart_btn;
        private PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private Label score_lbl;
        private Label scoreText_lbl;
        private Label gameOver_lbl;
    }
}
