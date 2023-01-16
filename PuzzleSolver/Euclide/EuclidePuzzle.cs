using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver.Euclide
{
    internal class EuclidePuzzle : Puzzle
    {
        private List<EuclideWheel> wheels;
        public EuclidePuzzle(List<EuclideWheel> wheels)
        {
            this.wheels = wheels;
        }
        public bool IsSolved()
        {
            var sum = new int[16];
            for (int i = 0; i < 16; i++)
            {
                foreach (var wheel in wheels)
                {
                    sum[i] += wheel.GetSegment(i);
                    if (i > 0 && sum[i] != sum[i - 1])
                        return false;
                }
            }
            return true;
        }

        public string Print()
        {
            throw new NotImplementedException();
        }

        public bool Solve()
        {
            while (wheels.Last().Offset < 16)
            {
                if (IsSolved()) return true;
                var iter = wheels.GetEnumerator();
                iter.MoveNext();

                iter.Current.Rotate();
                if (iter.Current.Offset % 16 == 15)
                {
                    do
                    {
                        iter.MoveNext();
                        iter.Current.Rotate();
                    } while (iter.Current.Offset % 4 == 0 && iter.Current != wheels.Last());
                }
            }
            return false;
        }
    }
}
