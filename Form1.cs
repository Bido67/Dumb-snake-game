using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Owo.Snake;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Owo
{
    public partial class Form1 : Form
    {
        private Game game;
        private System.Windows.Forms.Timer Ticker;
        private bool owo = false;
        private Scores scores = new Scores();
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            game = new Game(gamePanel);
            game.Draw();
            Ticker = new System.Windows.Forms.Timer();
            Ticker.Interval = 1;
            Ticker.Tick += Tick;
            Ticker.Start();
            txt_Score.Enabled = false;
            chk_Ded.Enabled = false;
            
        }
        public void Tick(object sender, EventArgs e)
        {
            chk_Ded.Checked = game.snake.IsSnakeOnSnake;
            txt_Score.Text = "Score: " + game.score.ToString();
            if (chk_EasyMode.Checked)
            {
                switch (game.snake.Direction)
                {
                    case Snake.Directions.Left:
                        Right.Enabled = false;
                        Left.Enabled = Down.Enabled = Up.Enabled = true; break;
                    case Snake.Directions.Right:
                        Left.Enabled = false;
                        Right.Enabled = Down.Enabled = Up.Enabled = true; break;
                    case Snake.Directions.Up:
                        Down.Enabled = false;
                        Right.Enabled = Left.Enabled = Up.Enabled = true; break;
                    case Snake.Directions.Down:
                        Up.Enabled = false;
                        Right.Enabled = Left.Enabled = Down.Enabled = true; break;
                }
            }
            
            if (game.GameOver)
            {
                if (!owo)
                {
                    scores.Add(new Score(game.score, "Anonymous"));
                    scores.Show(listView1);
                    
                    owo = true;
                    DialogResult result = MessageBox.Show("Wanna play again", "Funny snake game by Lily (https://github.com/bido67)", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        game = new Game(gamePanel);
                        owo = false;
                    }
                    else
                    {
                        MessageBox.Show("Score: " + game.score.ToString(), "Funny snake game by Lily (https://github.com/bido67)");
                    }
                }
                
            }
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            game.Clear();
            game.Draw();
        }


        private void Left_Click(object sender, EventArgs e)
        {
            keyDownOWO(Keys.A);

        }

        private void Up_Click(object sender, EventArgs e)
        {
            keyDownOWO(Keys.W);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            keyDownOWO(Keys.S);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            keyDownOWO(Keys.D);
        }

        private void last_Click(object sender, EventArgs e)
        {
            keyDownOWO(Keys.Space);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownOWO(e.KeyCode);
            e.Handled = false;
        }
        private void keyDownOWO(Keys key)
        {
            gamePanel.Select();
            switch (key)
            {
                case (Keys.D):
                    if (chk_EasyMode.Checked && !(game.snake.Direction == Snake.Directions.Left))
                    {
                        game.MoveSnake(Snake.Directions.Right);
                    }
                    else if(!chk_EasyMode.Checked)
                    {
                        game.MoveSnake(Snake.Directions.Right);
                    }
                    break;
                case (Keys.A):
                    if (chk_EasyMode.Checked && !(game.snake.Direction == Snake.Directions.Right))
                    {
                        game.MoveSnake(Snake.Directions.Left);
                    }
                    else if (!chk_EasyMode.Checked)
                    {
                        game.MoveSnake(Snake.Directions.Left);
                    }
                    break;
                case (Keys.W):
                    if (chk_EasyMode.Checked && !(game.snake.Direction == Snake.Directions.Down))
                    {
                        game.MoveSnake(Snake.Directions.Up);
                    }
                    else if (!chk_EasyMode.Checked)
                    {
                        game.MoveSnake(Snake.Directions.Up);
                    }
                    break;
                case (Keys.S):
                    if (chk_EasyMode.Checked && !(game.snake.Direction == Snake.Directions.Up))
                    {
                        game.MoveSnake(Snake.Directions.Down);
                    }
                    else if (!chk_EasyMode.Checked)
                    {
                        game.MoveSnake(Snake.Directions.Down);
                    }
                    break;
                case (Keys.Space):
                    game.MoveSnake(Snake.Directions.Last);
                        break;
                default:
                    break;
            }

        }
        private void chk_EasyMode_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk_EasyMode.Checked)
            {
                Left.Enabled = Right.Enabled = Down.Enabled = Up.Enabled = true;
            }
        }
    }
}
