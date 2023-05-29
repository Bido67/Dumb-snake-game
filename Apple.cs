using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Owo
{
    public class Apple : Block
    {
        private static Random rnd = new Random();
        private Apple(Graphics pGraphics, Point pPoint) : base(pGraphics, pPoint)
        {
            
        }
        private Brush m_color = Brushes.Red;
        public static Apple GenerateApple(Graphics pGraphics, Snake pSnake, Point pGameSize, int pSize)
        {
            Point point = RandomPos(pGameSize);
            do
            {
                point = RandomPos(pGameSize);
            } while (Block.Dummy(point).IsOnBlocks(pSnake.Body));
            Apple temp = new Apple(pGraphics, point);
            temp.DefaultSize = pSize;
            temp.Color = Brushes.Red;
            return temp;
        }
        private static Point RandomPos(Point pGameSize)
        {
            return new Point(rnd.Next(0, pGameSize.X), rnd.Next(0, pGameSize.Y));
        }
        public static Apple Eat(Graphics pGraphics, Snake pSnake, Point pGameSize, int pSize, Apple pApple)
        {
            if (pSnake.Head.IsOnBlock(pApple))
            {
                pSnake.Expand();
                return GenerateApple(pGraphics, pSnake, pGameSize, pSize);
            }
            else
            {
                return pApple;
            }
        }
    }
}
