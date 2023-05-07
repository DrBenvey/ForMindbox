using SquareLibrary;
using SquareLibrary.Figures;

namespace Tests
{
    public class TriangleTests
    {
        [Fact]
        public void IsCorrect_not_ok_1()
        {
            Triangle triangle = new Triangle(-3,11,12);
            Assert.False(triangle.IsCorrect(), "wrong sides");
        }

        [Fact]
        public void IsCorrect_not_ok_2()
        {
            Triangle triangle = new Triangle(1, 2, 12);
            Assert.False(triangle.IsCorrect(), "wrong sides");
        }

        [Fact]
        public void IsCorrect_not_ok_3()
        {
            OrthogonalTriangle orthogonalTriangle = new OrthogonalTriangle(11, 11, 11);
            Assert.False(orthogonalTriangle.IsCorrect(), "wrong sides");
        }

        [Fact]
        public void IsCorrect_not_ok_4()
        {
            OrthogonalTriangle orthogonalTriangle = new OrthogonalTriangle(double.MaxValue, double.MaxValue, double.MaxValue);
            Assert.False(orthogonalTriangle.IsCorrect(), "wrong sides");
        }

        [Fact]
        public void IsCorrect_not_ok_5()
        {
            Triangle triangle = new Triangle(double.MaxValue, double.MaxValue, double.MaxValue);
            Assert.False(triangle.IsCorrect(), "wrong sides");
        }

        [Fact]
        public void IsCorrect_ok_1()
        {
            Triangle triangle = new Triangle(11, 11, 11);
            Assert.True(triangle.IsCorrect());
        }

        [Fact]
        public void IsCorrect_ok_2()
        {
            OrthogonalTriangle orthogonalTriangle = new OrthogonalTriangle(3,4, 5);
            Assert.True(orthogonalTriangle.IsCorrect());
        }

        [Fact]
        public void GetSquare_not_ok_1()
        {
            Triangle triangle = new Triangle(double.MaxValue-11, 11, 11);
            var square = triangle.GetSquare();
            Assert.True(square == -1, "the area is too big");
        }

        [Fact]
        public void GetSquare_ok_2()
        {
            OrthogonalTriangle orthogonalTriangle = new OrthogonalTriangle(893, 924, 1285);
            var square = orthogonalTriangle.GetSquare();
            Assert.True(square == (893.0* 924.0)/2.0);
        }

        [Fact]
        public void GetSquare_ok_1()
        {
            Triangle triangle = new Triangle(893, 924, 1285);
            var square1 = triangle.GetSquareUnsafe();
            var square2 = triangle.GetSquare();
            Assert.True(square1 == square2);
        }
    }
}
