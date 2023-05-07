using SquareLibrary.Figures;

namespace Tests
{
    public class CirleTests
    {
        [Fact]
        public void IsCorrect_not_ok()
        {
            Circle circle = new Circle(-3);
            Assert.False(circle.IsCorrect(), "radius must be greater than 0");
        }

        [Fact]
        public void IsCorrect_ok()
        {
            Circle circle = new Circle(double.MaxValue);
            Assert.True(circle.IsCorrect());
        }

        [Fact]
        public void GetSquare_ok()
        {
            Circle circle = new Circle(11);
            var square1 = circle.GetSquare();
            var square2 = Math.PI * Math.Pow(11, 2);
            bool res = square1== square2;
            Assert.True(res);
        }

        [Fact]
        public void GetSquare_not_ok()
        {
            Circle circle = new Circle(double.MaxValue-13);
            var square = circle.GetSquare();
            Assert.True(square==-1, "the area is too big");
        }
    }
}