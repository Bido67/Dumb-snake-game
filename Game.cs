using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owo
{
    public class Game
    {
        public const int GridSize = 25;
        public int BlockPixelSize {
            get
            {
                return m_gamePanel.Size.Width / GridSize;
            }
        }
        public const int SquareSize = 1;
        public static Brush GameBackground = Brushes.Black;
        private Panel m_gamePanel;
        public Snake snake; 
        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer Ticker;
        private int m_movedelay;
        private Graphics m_graphics;
        private Apple Apple;
        public int MoveDelay
        {
            get
            {
                return m_movedelay;
            }
            set
            {
                if (value < 100)
                {
                    m_movedelay = 100;
                }
                else
                {
                    m_movedelay = value;
                }

            }
        }
        public Game(Panel gamePanel)
        {
            m_gamePanel = gamePanel;
            m_graphics = gamePanel.CreateGraphics();
            snake = new Snake(m_graphics,BlockPixelSize);
            Ticker = new System.Windows.Forms.Timer();
            Ticker.Interval = 1;
            Ticker.Tick += Tick;
            Ticker.Start();
            stopwatch = new Stopwatch();
            stopwatch.Start();
            MoveDelay = 1000;
            Apple = Apple.GenerateApple(m_graphics, snake, new Point(GridSize, GridSize), BlockPixelSize);
            Clear();
            
        }
        private bool m_gameOver = false;
        public bool GameOver
        {
            get
            {
                return m_gameOver;
            }
        }
        public void Tick(object sender, EventArgs e)
        {
            snake.Draw();
            if (snake.AteApple)
            {
                MoveDelay -= 10;
                m_score++;
                snake.AteApple= false;
            }
            if (snake.IsSnakeOnSnake)
            {
                m_gameOver= true;
                stopwatch.Stop();
                Ticker.Stop();
            }
            Apple.Render(Block.RenderMode.Draw);
            if(stopwatch.ElapsedMilliseconds > MoveDelay)
            {
                Update();
                //stopwatch.Restart();
            }
        }
        public void Update() {
            MoveSnake(Snake.Directions.Last);
        }
        public void MoveSnake(Snake.Directions Direction)
        {
            if (!GameOver)
            {
                snake.Move(Direction);
                Apple = Apple.Eat(m_graphics, snake, new Point(GridSize, GridSize), BlockPixelSize, Apple);
                stopwatch.Restart();
            }
            
            
        }
        private int m_score = 0;
        public int score { get
            {
                return m_score;
            } }
        public void Draw()
        {

        }
        public void Clear()
        {
            PaintEventArgs PaintEvent = new PaintEventArgs(m_gamePanel.CreateGraphics(), new Rectangle(0, 0, m_gamePanel.Size.Width, m_gamePanel.Size.Height));
            PaintEvent.Graphics.FillRectangle(GameBackground, new Rectangle(0, 0, m_gamePanel.Size.Width, m_gamePanel.Size.Height));
            PaintEvent.Dispose();
            m_gamePanel.Update();
        }
    }
}
