namespace NineEleven
{
    public partial class Form1 : Form
    {
        private int planeSpeed = 10;
        private int obstacleSpeed = 10;
        private int score = 0;
        private bool isGameOver = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            KeyPreview = true;

            labelScore.Text = "Score: " + score;

            planePic.Visible = false;
            towerBottomPic.Visible = false;
        }

        private void Form1_Keydown(object sender, KeyEventArgs e)
        {
            if (!isGameOver)
            {
                if (e.KeyCode == Keys.Up && planePic.Top > 0)
                {
                    planePic.Top -= planeSpeed;
                }
                else if (e.KeyCode == Keys.Down && planePic.Bottom < this.ClientSize.Height)
                {
                    planePic.Top += planeSpeed;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void startGame()
        {
            buttonStart.Visible = false;
            isGameOver = false;

            planePic.Visible = true;
            planePic.Top = this.Height / 2 - planePic.Height / 2;
            towerBottomPic.Visible = true;

            towerBottomPic.Top = this.ClientSize.Height - towerBottomPic.Height;
            towerBottomPic.Left = this.ClientSize.Width - towerBottomPic.Width;

            towerBottomPic.Height = random.Next(100, 300);

            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            towerBottomPic.Left -= obstacleSpeed;

            if (planePic.Bounds.IntersectsWith(towerBottomPic.Bounds)) {
                gameOver();
            }

            if (towerBottomPic.Left < 0)
            {
                score++;
                labelScore.Text = "Score: " + score;

                towerBottomPic.Height = random.Next(130, 420);

                towerBottomPic.Top = this.ClientSize.Height - towerBottomPic.Height;
                towerBottomPic.Left = this.ClientSize.Width - towerBottomPic.Width;
            }
        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            MessageBox.Show("Mampus nabrak. Score: " + score);
            buttonStart.Visible = true;
            planePic.Visible = false;
            towerBottomPic.Visible = false;
        }
    }
}
