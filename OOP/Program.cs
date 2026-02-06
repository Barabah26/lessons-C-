var rectangle1 = new Rectangle(5, 10);
var calculator = new ShapesMeasurementsCalculator();

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeigth();
Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle1));
Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle1));

Console.ReadKey();

class Rectangle
{
    private int _width;
    private int _height;

    public Rectangle(int width, int heigth)
    {
        width = GetLengthOrDefault(width, nameof(Width);
        heigth = GetLengthOrDefault(heigth, nameof(Height);

    }

    public int GetHeigth() => _height;

    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
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

    public string Description => $"A rectangle with width {Width} " + $"and height {_height}";

}

class ShapesMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;
    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;

}