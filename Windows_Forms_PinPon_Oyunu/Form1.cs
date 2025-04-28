namespace Windows_Forms_PinPon_Oyunu
{
    public partial class gameForm : Form
    {
        int speed_left = 4;
        int speed_top = 4;
        int score = 0;
        public gameForm()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;

            table.Top = game_panel.Bottom - game_panel.Bottom / 10;
            table.Left = game_panel.Left + game_panel.Width / 2 - table.Width / 2;

            gameOver_panel.Top = game_panel.Bottom / 2 - gameOver_panel.Height / 2;
            gameOver_panel.Left = game_panel.Right / 2 - gameOver_panel.Width / 2;
            gameOver_panel.Visible = false;
            gameOver_panel.Enabled = false;

            timer1.Enabled = true;
            Cursor.Hide();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            table.Left = Cursor.Position.X - table.Width / 2;
            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Left <= game_panel.Left)
            {
                speed_left = -speed_left;
            }
            else if (ball.Right >= game_panel.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= game_panel.Top)
            {
                speed_top = -speed_top;
            }
            else if (ball.Bottom >= game_panel.Bottom)
            {
                timer1.Enabled = false;
                gameOver_panel.Visible = true;
                gameOver_panel.Enabled = true;
            }

            if (ball.Bottom >= table.Bottom && ball.Left >= table.Left && ball.Right <= table.Right)
            {
                speed_left += 2;
                speed_top += 2;
                speed_top = -speed_top;

                score++;
                score_lbl.Text = score.ToString();
            }

        }




    }
}
