

Rectangle r1 = new Rectangle(10.5m, 3.6m);
Console.WriteLine(r1);

// Let's change height to a negative number.

r1.height = -5;

Console.WriteLine(r1.height);


class Rectangle
{
    // length with shortcut
    public decimal length { get; set; }

    private decimal pHeight;

    // validation with height: Verify height > 0. Can't use shortcut
    public decimal height
    {

        get
        {
            return pHeight;
        }
        set  //   set included a parameter 'value' automatically.. keyword paramater. takes input.
        {
            if (value > 0)
            {
                pHeight = value;
            }
            else
            {
                pHeight = 1;
            }
        }
    }

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