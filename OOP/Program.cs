var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);

var rectangle2 = new Rectangle(3, 11);

Console.WriteLine("Width is " + rectangle2.Width);
Console.WriteLine("Height is " + rectangle2.Height);

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