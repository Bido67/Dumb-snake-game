using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owo
{
    public class Block : IBlock
    {
        private Graphics m_Graphics;
        public enum RenderMode { None, Clear, Draw, Both};
        protected int DefaultSize = 100;
        public static Brush DefaultBrush = Brushes.Cyan;
        // These use grid like coordinates, precalculated using the constant above or the size in the drawing routine.
        protected int m_x;
        protected int m_y;
        protected int m_w;
        private int m_h;
        protected Brush m_color = DefaultBrush;
        private bool dummy;
        public int PixelSize
        {
            get { return DefaultSize; }
        }
        public Brush Color
        {
            get{
                return m_color;
            }
            set {
                m_color= value;
            }
        }
        public int X
        {
            get { return m_x; }
        }
        public int Y
        {
            get { return m_y; }
        }
        public int W
        {
            get { if (dummy) return 0; return m_w; }
        }
        private Block(int x, int y)
        {
            dummy = true;
            m_x = x;
            m_y = y;
        }
        public Block(Graphics pGraphics) : this(pGraphics, 0,0) {}
        public Block(Graphics pGraphics, Point pPoint) : this(pGraphics, pPoint.X,pPoint.Y) {}
        public Block(Graphics pGraphics, int pX, int pY)
        {
            dummy = false;
            m_x = pX;
            m_y = pY;
            m_w = Game.SquareSize;
            m_h = m_w;
            m_Graphics = pGraphics;
        }
        public Block(Graphics pGraphics, int pSize) : this(pGraphics, 0, 0)
        {
            dummy = false;
            DefaultSize = pSize;
        }
        public Block(Graphics pGraphics, int pX, int pY, int pSize)
        {
            dummy = false;
            m_x = pX;
            m_y = pY;
            m_w = Game.SquareSize;
            m_h = m_w;
            m_Graphics = pGraphics;
            DefaultSize = pSize;
        }
        public void Render(RenderMode mode)
        {
            if (dummy) return;
            PaintEventArgs PaintEvent = new PaintEventArgs(m_Graphics, new Rectangle(m_x * DefaultSize, m_y * DefaultSize, m_w * DefaultSize, m_h * DefaultSize));
            switch (mode) {
                case RenderMode.Clear:
                    Clear(PaintEvent);
                    break;
                case RenderMode.Draw:
                    Draw(PaintEvent);
                    break;
                case RenderMode.Both:
                    Clear(PaintEvent);
                    Draw(PaintEvent);
                    break;
                case RenderMode.None:
                    break;

            }
            PaintEvent.Dispose();
        }
        private void Draw(PaintEventArgs e)
        {
            if (dummy) return;
            DrawCenter(e, DefaultSize);
        }
        private void DrawCenter(PaintEventArgs e, int size)
        {
            if (dummy) return;
            // create a paint event
            // calculate
            int w = size;
            int diff = m_w * DefaultSize - size;
            int x = m_x * DefaultSize + (diff / 2);
            int y = m_y * DefaultSize + (diff / 2);
            // fill the square
            e.Graphics.FillRectangle(m_color, new Rectangle(x,y,w,w));
            //dispose
            
        }
        private void Clear(PaintEventArgs e)
        {
            if (dummy) return;
            // clear the background
            e.Graphics.FillRectangle(Game.GameBackground, new Rectangle(m_x * DefaultSize, m_y * DefaultSize, m_w * DefaultSize, m_h * DefaultSize));
            // dispose
        }
        public void Move(bool clear, Block block)
        {
            if (dummy) return;
            Move(clear, block.X, block.Y);
        }
        public void Move(bool clear, int x, int y)
        {
            if (dummy) return;
            if (clear)
            {
                Render(RenderMode.Clear);
            }
            Move(x, y);
        }
        private void Move(int x, int y)
        {
            m_x = x; m_y = y;
        }
        public bool IsOnBlock(Block compareAgainst)
        {
            return m_x == compareAgainst.X && m_y == compareAgainst.Y;
        }
        public bool IsOnBlocks(IEnumerable<Block> compareAgainst)
        {
            List<Block> compare = compareAgainst.ToList();
            for (int i = 0; i < compare.Count; i++)
            {
                if (IsOnBlock(compare[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsBlockOnBlock(Block block1, Block block2)
        {
            return block1.IsOnBlock(block2);
        }
        public static Block Dummy(int x, int y)
        {
            return new Block(x, y);
        }
        public static Block Dummy(Point pPoint)
        {
            return new Block(pPoint.X, pPoint.Y);
               
        }

    }
}
