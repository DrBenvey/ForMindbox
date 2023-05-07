using SquareLibrary;
using SquareLibrary.Figures;

//Get area of ​​a circle
Circle circle = new Circle(13.13);
Console.WriteLine(circle.GetSquare());
//new radius
circle.radius = 10;
Console.WriteLine(circle.GetSquare());
//or with check and unsafe
if (circle.IsCorrect())
    Console.WriteLine(circle.GetSquareUnsafe());
//Get area of ​​a triangle
Triangle triangle = new Triangle(11, 11, 11);
Console.WriteLine(triangle.GetSquare());
//new sides
triangle.a=3; 
triangle.b=4; 
triangle.c=5;
Console.WriteLine(triangle.GetSquare());
//or with check and unsafe
if (triangle.IsCorrect())
    Console.WriteLine(triangle.GetSquareUnsafe());
//Get area of ​​a Orthogonal triangle
OrthogonalTriangle orthogonalTriangle = new OrthogonalTriangle(5, 12, 13);
Console.WriteLine(orthogonalTriangle.GetSquare());
//Get area of ​​a circle or triangle
Square square = new Square(side: new List<double> { 11, 11, 11 });
Console.WriteLine(square.GetSquare());
square.InitFigure(radius:13.13);
Console.WriteLine(square.GetSquare());


Console.ReadLine();