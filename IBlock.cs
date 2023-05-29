using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Owo.Block;

namespace Owo
{
    public interface IBlock
    {
        Brush Color { get; set; }
        int X { get; }
        int Y { get; }
        int W { get; }
        void Render(RenderMode mode);
        void Move(bool clear, Block block);
        void Move(bool clear, int x, int y);
        bool IsOnBlock(Block compareAgainst);
        bool IsOnBlocks(IEnumerable<Block> compareAgainst);

    }
}
