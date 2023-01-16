using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver
{
    internal interface Puzzle
    {
        bool Solve();
        bool IsSolved();
        string Print();
    }
}
