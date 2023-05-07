using SquareLibrary;
using SquareLibrary.Figures;

namespace Tests
{
    public class SquareTest
    {
        [Fact]
        public void IsCorrect_not_ok_1()
        {
            Square square = new Square(radius: -1);
            Assert.False(square.IsCorrect(), "radius must be greater than 0");
        }

        [Fact]
        public void IsCorrect_not_ok_2()
        {
            Square square = new Square(side: new List<double> { 1, 2, 12 });
            Assert.False(square.IsCorrect(), "wrong sides");
        }

        [Fact]
        public void IsCorrect_not_ok_3()
        {
            Square square = new Square(side: new List<double> { 1, 2 });
            Assert.False(square.IsCorrect(), "must be at least 3 sides");
        }

        [Fact]
        public void IsCorrect_not_ok_4()
        {
            Square square = new Square(side: new List<double> { 1, 2, 1, 2 });
            Assert.False(square.IsCorrect(), "not implemented");
        }

        [Fact]
        public void IsCorrect_not_ok_5()
        {
            Square square = new Square(side: new List<double> { double.MaxValue, double.MaxValue, double.MaxValue });
            Assert.False(square.IsCorrect(), "the sides are too big");
        }

        [Fact]
        public void IsCorrect_ok_1()
        {
            Square square = new Square(side: new List<double> { 11, 11, 11 });
            Assert.True(square.IsCorrect());
        }

        [Fact]
        public void IsCorrect_ok_2()
        {
            Square square = new Square(radius: 13);
            Assert.True(square.IsCorrect());
        }

        [Fact]
        public void GetSquare_ok_1()
        {
            Square square = new Square(radius: 13);
            var square1 = square.GetSquare();
            var square2 = Math.PI * Math.Pow(13, 2);
            bool res = square1 == square2;
            Assert.True(res);
        }

        [Fact]
        public void GetSquare_not_ok()
        {
            Square square = new Square(radius: double.MaxValue - 13);
            var square1 = square.GetSquare();
            Assert.True(square1 == -1, "the area is too big");
        }

        [Fact]
        public void GetSquare_ok_2()
        {
            Square square = new Square(side: new List<double> { 893, 924, 1285 });
            var square1 = square.GetSquareUnsafe();
            var square2 = square.GetSquare();
            Assert.True(square1 == square2);
        }
    }
}
