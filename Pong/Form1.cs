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
        byte paddleSpeed = 10;
        Thread gameThread;

        bool isPlayer1MovingUp = false;
        bool isPlayer1MovingDown = false;
        bool isPlayer2MovingUp = false;
        bool isPlayer2MovingDown = false;

        public Pong()
        {
            InitializeComponent();
            StartGameThread();
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
            {
                paddlePositionY1 -= paddleSpeed;
            }
            if (isPlayer1MovingDown)
            {
                paddlePositionY1 += paddleSpeed;
            }
            if (isPlayer2MovingUp)
            {
                paddlePositionY2 -= paddleSpeed;
            }
            if (isPlayer2MovingDown)
            {
                paddlePositionY2 += paddleSpeed;
            }

            if (paddlePositionY1 < 0)
            {
                paddlePositionY1 = 0;
            }
            if (paddlePositionY1 + 160 > 800)
            {
                paddlePositionY1 = 800 - 160;
            }

            if (paddlePositionY2 < 0)
            {
                paddlePositionY2 = 0;
            }
            if (paddlePositionY2 + 160 > 800)
            {
                paddlePositionY2 = 800 - 160;
            }


            // Update the paddle positions in the UI on the main UI thread
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
                // Update the paddle positions in the UI on the main UI thread
                player1.Location = new Point(paddlePositionX1, paddlePositionY1);
                player2.Location = new Point(paddlePositionX2, paddlePositionY2);
            }
        }

        void StartGameThread()
        {
            gameThread = new Thread(GameLoop);
            gameThread.Start();
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

        private void title_Click(object sender, EventArgs e)
        {
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.W)
            {
                isPlayer1MovingUp = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                isPlayer1MovingDown = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                isPlayer2MovingUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                isPlayer2MovingDown = true;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.W)
            {
                isPlayer1MovingUp = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                isPlayer1MovingDown = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                isPlayer2MovingUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                isPlayer2MovingDown = false;
            }
        }
    }
}
