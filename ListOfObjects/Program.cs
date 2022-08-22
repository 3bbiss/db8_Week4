
List<Rectangle> rects = new List<Rectangle>();

//rects.Add(new Rectangle("Fred", 3.5, 4.2));


Rectangle r1 = new Rectangle("Fred", 3.5, 4.2);
rects.Add(r1);

Rectangle r2 = new Rectangle("Sally", 4.6, 5.5);
rects.Add(r2);

Console.WriteLine("Which rectangle?");
string entry = Console.ReadLine();

Rectangle found = null;

foreach (Rectangle rect in rects)
{
    if (rect.name == entry)
    {
        found = rect;
        break;
    }
}


if (found != null)
{
    Console.WriteLine(found);
}
else
{
    Console.WriteLine("Sorry not found!");
}

class Rectangle
{
    public string name;
    public double length;
    public double height;

    public Rectangle(string _name, double _length, double _height)
    {
        name = _name;
        length = _length;
        height = _height;
    }

    //public override string ToString()
    //{
    //    return $"{name}: {length} X {height},   Area = {length * height}";
    //}

    public override string ToString()
    {
        return base.ToString();
    }
}