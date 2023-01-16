using PuzzleSolver.BlockTower;

namespace Test
{
    public class BlockTowerTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void RotatingBlockIncrementsOffset()
        {
            Block block = new(1, 2, 3, 4);
            int oldOffset = block.Offset;

            block.Rotate();

            Assert.That(oldOffset + 1, Is.EqualTo(block.Offset));
        }

        [Test]
        public void PuzzleSolvedWithEqualSums()
        {
            List<Block> blocks = new();
            blocks.Add(new Block(1, 1, 1, 1));
            blocks.Add(new Block(1, 1, 1, 1));
            blocks.Add(new Block(1, 1, 1, 1));
            blocks.Add(new Block(1, 1, 1, 1));
            BlockTowerPuzzle puzzle = new(blocks);

            Assert.That(puzzle.IsSolved);
        }

        [Test]
        public void PuzzleNotSolvedWithUnequalSums()
        {
            List<Block> blocks = new();
            blocks.Add(new Block(1, 2, 3, 4));
            blocks.Add(new Block(1, 2, 3, 4));
            blocks.Add(new Block(1, 2, 3, 4));
            blocks.Add(new Block(1, 2, 3, 4));
            BlockTowerPuzzle puzzle = new(blocks);

            Assert.That(puzzle.IsSolved, Is.False);
        }
    }
}