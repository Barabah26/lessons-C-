var rectangle1 = new Rectangle(5, 10);
var calculator = new ShapesMeasurementsCalculator();

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);
Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle1));
Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle1));

Console.ReadKey();

class Rectangle
{
    const int NumberOfSides = 4;
    public readonly int Width;
    public readonly int Height;

    public Rectangle(int width, int heigth)
    {
        width = GetLengthOrDefault(width, nameof(Width);
        heigth = GetLengthOrDefault(heigth, nameof(Height);

    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int DefaultValueOfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return DefaultValueOfNonPositive;
        }
        else
        return length;
    }

}

class ShapesMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;
    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;

}