using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owo
{
    public class Snake
    {
        public enum Directions { Last, Left , Right, Up, Down };
        public Directions Direction;
        private Graphics m_graphics;
        private Snake(Graphics pGraphics)
        {
            Direction = Directions.Up;
            m_graphics = pGraphics;
        }
        public Snake(Graphics pGraphics, int pSize) : this(pGraphics)
        {
            m_blocks.Add(new Block(m_graphics, (Game.GridSize / 2), Game.GridSize / 2, pSize));
            m_blocks[0].Color = Brushes.Pink;

            for (int i = 1; i < 5; i++)
            {
                m_blocks.Add(new Block(m_graphics, (Game.GridSize / 2) - i, Game.GridSize / 2, pSize));
            }
        }
        public void Draw() {
            m_blocks.ForEach((Block block) =>
            {
                block.Render(Block.RenderMode.Draw);
            });
            m_blocks[0].Render(Block.RenderMode.Draw);
        }
        private List<Block> m_blocks = new List<Block>();
        public List<Block> Body
        {
            get { return m_blocks; }
        }
        public Block Head { get { return m_blocks[0]; } }
        public Block Tail { get { return m_blocks[m_blocks.Count -1]; } }
        public bool AteApple { get; set; }
        public void Expand()
        {
            m_blocks.Add(new Block(m_graphics, Tail.X, Tail.Y, Tail.PixelSize));
            AteApple = true;
        }
        public void Move(Directions direction)
        {
            if(direction == Directions.Last)
            {
                direction = Direction;
            }
            else
            {
                Direction = direction;
            }
            MoveBlocks();
            switch (direction)
            {
                case Directions.Left:
                    m_blocks[0].Move(false, m_blocks[0].X - 1, m_blocks[0].Y);
                    break; 
                case Directions.Right:
                    m_blocks[0].Move(false, m_blocks[0].X + 1, m_blocks[0].Y);
                    break; 
                case Directions.Up:
                    m_blocks[0].Move(false, m_blocks[0].X, m_blocks[0].Y - 1);
                    break;
                case Directions.Down:
                    m_blocks[0].Move(false, m_blocks[0].X, m_blocks[0].Y + 1);
                    break;
            }
        }
        private void MoveBlocks()
        {
            for(int i = m_blocks.Count - 1; i > 0; i--)
            {
                m_blocks[i].Move(m_blocks[i] == Tail, m_blocks[i-1]);
            }
        }
        public bool IsSnakeOnSnake
        {
            get
            {
                bool isOn = false;
                m_blocks.ForEach((Block block) =>
                {
                    if (isOn) { return; } else
                    {
                        if (block != Head)
                        {
                            if (block.X == Head.X && block.Y == Head.Y)
                            {
                                isOn = true;
                            }
                        }
                    }
                });
                return isOn;
            }
        }
    }
}
