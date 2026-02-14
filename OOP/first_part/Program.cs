//var rectangle1 = new Rectangle(5, 10);
//var rectangle2 = new Rectangle(50, 100);

//Console.WriteLine(
//    "Count of Rectangle objects is " + Rectangle.CountOfInstances);

////var calculator = new ShapesMeasurementsCalculator();

////Console.WriteLine("Width is " + rectangle1.Width);
////Console.WriteLine("Height is " + rectangle1.GetHeigth());
////Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle1));
////Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle1));

//Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
//Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
//Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");


//Console.ReadKey();

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;

}

class Rectangle
{
    public static int CountOfInstances {  get; private set; }
    private static DateTime _firstUsed = DateTime.Now;

    private int _width;
    private int _height;

    public Rectangle(int width, int heigth)
    {
        width = GetLengthOrDefault(width, nameof(_width));
        heigth = GetLengthOrDefault(heigth, nameof(_height));
        ++CountOfInstances;
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

    public string Description => $"A rectangle with width {_width} " + $"and height {_height}";

}

//class ShapesMeasurementsCalculator
//{
//    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle._width + 2 * rectangle._height;
//    public int CalculateRectangleArea(Rectangle rectangle) => rectangle._width * rectangle._height;

//}