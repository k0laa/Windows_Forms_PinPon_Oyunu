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

            table.Top = game_panel.Bottom - game_panel.Bottom/10;
            table.Left = game_panel.Left + game_panel.Width / 2 - table.Width / 2;

            gameOver_panel.Top = game_panel.Bottom / 2 - gameOver_panel.Height / 2;
            gameOver_panel.Left = game_panel.Right / 2 - gameOver_panel.Width / 2;
            gameOver_panel.Visible = false;
            gameOver_panel.Enabled = false;
        }

        private void game_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
