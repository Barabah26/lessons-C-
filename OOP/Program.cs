var rectangle1 = new Rectangle(5, 10);
var calculator = new ShapesMeasurementsCalculator();

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);
Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle1));
Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle1));

Console.ReadKey();

class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width; 
        Height = height;
    }
}

class ShapesMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;
    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;

}