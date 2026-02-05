var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());




var rectangle2 = new Rectangle(3, 11);

Console.WriteLine("Width is " + rectangle2.Width);
Console.WriteLine("Height is " + rectangle2.Height);
Console.WriteLine("Area is " + rectangle2.CalculateArea());
Console.WriteLine("Circumference is " + rectangle2.CalculateCircumference());

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

    public int CalculateCircumference()
    {
        return 2 * Width + 2 * Height;
    }

    public int CalculateArea()
    {
        return Width * Height;
    }

}