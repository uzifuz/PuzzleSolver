using PuzzleSolver.BlockTower;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver.BlockTower
{
    internal class BlockTowerPuzzle : Puzzle
    {
        private List<Block> blocks;
        public BlockTowerPuzzle(List<Block> blocks)
        {
            this.blocks = blocks;
        }
        public bool IsSolved()
        {
            int[] sum = { 0, 0, 0, 0 };
            for (int i = 0; i < 4; i++)
            {
                foreach (var block in blocks)
                {
                    sum[i] += block.GetSide(i);
                }
            }
            if (sum[0] == sum[1] && sum[1] == sum[2] && sum[2] == sum[3])
                return true;
            else return false;
        }
        public bool Solve()
        {
            while (blocks.Last().Offset < 4)
            {
                if (IsSolved()) return true;
                var iter = blocks.GetEnumerator();
                iter.MoveNext();

                iter.Current.Rotate();
                if (iter.Current.Offset % 4 == 3)
                {
                    do
                    {
                        iter.MoveNext();
                        iter.Current.Rotate();
                    } while (iter.Current.Offset % 4 == 0 && iter.Current != blocks.Last());
                }

            }
            return false;
        }
        public string Print()
        {
            string s = "";
            foreach (var block in blocks)
            {
                s += "(";
                for (int i = 0; i < 4; i++)
                {
                    s += block.GetSide(i);
                    if (i < 3) s += ", ";
                }
                s += ")\n";
            }
            return s;
        }
    }
}
