using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Pong
{
    public partial class Pong : Form
    {
        byte playerOneScore = 0;
        byte playerTwoScore = 0;
        short paddlePositionY1 = 340;
        short paddlePositionY2 = 340;
        short paddlePositionX1 = 12;
        short paddlePositionX2 = 952;
        byte paddleSpeed = 12;
        int ballPositionX = 489;
        int ballPositionY = 362;
        int ballSpeedX = 12;
        int ballSpeedY = 12;
        Thread gameThread;
        bool isPlayer1MovingUp = false;
        bool isPlayer1MovingDown = false;
        bool isPlayer2MovingUp = false;
        bool isPlayer2MovingDown = false;

        public Pong()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            
                
        }

        void GameLoop()
        {
            while (gameThread != null)
            {
                Update();
                try
                {
                    Thread.Sleep(16);
                }
                catch (ThreadInterruptedException)
                {
                    Console.WriteLine("Error: Game loop has stopped working");
                }
            }
        }

        new void Update()
        {
            if (isPlayer1MovingUp)
                paddlePositionY1 -= paddleSpeed;
            if (isPlayer1MovingDown)
                paddlePositionY1 += paddleSpeed;
            if (isPlayer2MovingUp)
                paddlePositionY2 -= paddleSpeed;
            if (isPlayer2MovingDown)
                paddlePositionY2 += paddleSpeed;

            if (paddlePositionY1 < 0)
                paddlePositionY1 = 0;
            if (paddlePositionY1 + 160 > 800)
                paddlePositionY1 = 800 - 160;

            if (paddlePositionY2 < 0)
                paddlePositionY2 = 0;
            if (paddlePositionY2 + 160 > 800)
                paddlePositionY2 = 800 - 160;

            ballPositionX += ballSpeedX;
            ballPositionY += ballSpeedY;

            if (ballPositionY < 0)
            {
                ballSpeedY = -ballSpeedY;
                ballPositionY = 0;
            }
            else if (ballPositionY + 40 > 760) 
            {
                ballSpeedY = -ballSpeedY;
                ballPositionY = 760 - 40;
            }

            if (ballPositionX < paddlePositionX1 + 20 && ballPositionY >= paddlePositionY1 && ballPositionY <= paddlePositionY1 + 160)
                ballSpeedX = Math.Abs(ballSpeedX); 
            else if (ballPositionX + 40 > paddlePositionX2 && ballPositionY >= paddlePositionY2 && ballPositionY <= paddlePositionY2 + 160)
                ballSpeedX = -Math.Abs(ballSpeedX); 
            else if (ballPositionX < 0)
            {
                ballPositionX = 480;
                ballPositionY = 380;
                playerTwoScore++;
                CheckForWinAndOpenWebsite();
            }
            else if (ballPositionX > 945)
            {
                ballPositionX = 480;
                ballPositionY = 380;
                playerOneScore++;
                CheckForWinAndOpenWebsite();
            }

            UpdatePaddlePositions();
        }

        void UpdatePaddlePositions()
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)UpdatePaddlePositions);
            }
            else
            {
                player1.Location = new Point(paddlePositionX1, paddlePositionY1);
                player2.Location = new Point(paddlePositionX2, paddlePositionY2);
                pongBall.Location = new Point(ballPositionX, ballPositionY);
                score1.Text = playerOneScore.ToString();
                score2.Text = playerTwoScore.ToString();
            }
        }

        void StartGameThread()
        {
            gameThread = new Thread(GameLoop);
            gameThread.Start();
            this.Focus();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.W)
                isPlayer1MovingUp = true;
            else if (e.KeyCode == Keys.S)
                isPlayer1MovingDown = true;
            else if (e.KeyCode == Keys.Up)
                isPlayer2MovingUp = true;
            else if (e.KeyCode == Keys.Down)
                isPlayer2MovingDown = true;
        }

        private void CheckForWinAndOpenWebsite()
        {
            if (playerOneScore == 15)
            {
                MessageBox.Show("Player 1 wins!");
                Application.Exit();
                gameThread.Abort();
            }
            else if (playerTwoScore == 15)
            {
                MessageBox.Show("Player 2 wins!");
                Application.Exit();
                gameThread.Abort();
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.W)
                isPlayer1MovingUp = false;
            else if (e.KeyCode == Keys.S)
                isPlayer1MovingDown = false;
            else if (e.KeyCode == Keys.Up)
                isPlayer2MovingUp = false;
            else if (e.KeyCode == Keys.Down)
                isPlayer2MovingDown = false;
        }

        private void score1_Click(object sender, EventArgs e)
        {
        }

        private void score2_Click(object sender, EventArgs e)
        {
        }

        private void Pong_Load(object sender, EventArgs e)
        {
        }

        private void player1_Click(object sender, EventArgs e)
        {
        }

        private void pongBall_Click(object sender, EventArgs e)
        {
        }

        private void player2_Click(object sender, EventArgs e)
        {
        }

        private void play_button_Click(object sender, EventArgs e)
        {
         
            menu_pic.Hide();
            play_button.Hide();
            author_label.Hide();
            menu_title.Hide();
            first_to.Hide();
            StartGameThread();
        }

        private void author_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void start_menu_Click(object sender, EventArgs e)
        {

        }

        private void pong_title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
