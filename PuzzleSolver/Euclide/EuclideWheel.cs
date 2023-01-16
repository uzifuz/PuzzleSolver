using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver.Euclide
{
    internal class EuclideWheel
    {
        public int Offset { get; private set;}
        private int[] segments;
        public EuclideWheel(int[] segments)
        {
            if (segments.Length != 16)
                throw new ArgumentException("EuclideWheel must have 16 segments");
            this.segments = segments;
        }
        public int GetSegment(int i)
        {
            return segments[(i + Offset) % 16];
        }
        public void Rotate()
        {
            Offset++;
        }
    }
}
