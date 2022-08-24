

Rectangle r1 = new Rectangle(10.5m, 3.6m);
Console.WriteLine(r1);

class Rectangle
{
    public decimal length { get; set; }
    public decimal height { get; set; }

    public Rectangle(decimal _length, decimal _height)
    {
        length = _length;
        height = _height;
    }

    public override string ToString()
    {
        return $"{length} {height} Area: {length * height}";
    }
}