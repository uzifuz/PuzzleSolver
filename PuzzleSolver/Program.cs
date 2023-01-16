// See https://aka.ms/new-console-template for more information
using PuzzleSolver;
using PuzzleSolver.BlockTower;

List<Block> blocks = new();

blocks.Add(new(25, 60, 95, 30));
blocks.Add(new(20, 70, 55, 25));
blocks.Add(new(10, 20, 50, 55));
blocks.Add(new(45, 55, 65, 15));
blocks.Add(new(80, 90, 55, 90));
blocks.Add(new(90, 85, 55, 60));
blocks.Add(new(55, 45, 95, 15));
blocks.Add(new(55, 55, 75, 65));
blocks.Add(new(55, 55, 70, 35));
blocks.Add(new(60, 75, 55, 55));

var puzzle = new BlockTowerPuzzle(blocks);

if (puzzle.Solve())
{
    Console.WriteLine("solved: ");
    Console.Write(puzzle.Print());
} else
{
    Console.WriteLine("not solved :(");
}