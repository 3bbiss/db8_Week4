

Sedan myCar = new Sedan(4, "Blue", true, 4);

RaceCar myRaceCar = new RaceCar(4, "red", 400);

RaceCar secondRaceCar = new RaceCar(3, "orange", 1000);

List<Vehicle> raceCars = new List<Vehicle>();

raceCars.Add(myCar);
raceCars.Add(myRaceCar);
raceCars.Add(secondRaceCar);

foreach (var car in raceCars)
{
    car.Drive();
}


class Vehicle
{
    public int wheels;
    public string color;

    public Vehicle(int _wheels, string _color)
    {
        wheels = _wheels;
        color = _color;
    }

    public virtual void Drive()
    {
        Console.WriteLine("I am driving!");
    }
}

class Sedan : Vehicle
{
    public bool isHatchBack;
    public int doors;
    public Sedan(int _SedanWheels, string _SedanColor, bool _isHatchBack, int _doors) : base(_SedanWheels, _SedanColor)
    {
        isHatchBack = _isHatchBack;
        doors = _doors;
    }
    public override void Drive()
    {
        Console.WriteLine($"I am driving the speed limit."); ;
    }
}

class RaceCar : Vehicle
{
    public int engineSize;
    public RaceCar(int _wheels, string _color, int _engineSize) : base(_wheels, _color)
    {
        engineSize = _engineSize;
    }
    public override void Drive()
    {
        Console.WriteLine($"I am speeding!"); ;
    }
}