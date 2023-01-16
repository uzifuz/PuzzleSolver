using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver.BlockTower
{
    public class Block
    {
        private int[] sides;
        public int Offset { get; private set; }
        public Block(int side0, int side1, int side2, int side3)
        {
            int[] sides = { side0, side1, side2, side3 };
            this.sides = sides;
        }
        public int GetSide(int side)
        {
            return sides[(side + Offset) % sides.Length];
        }
        public void Rotate()
        {
            Offset++;
        }
    }
}
