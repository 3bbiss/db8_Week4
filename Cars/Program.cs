//Console.WriteLine($"\nYou selected:\n {cars[listing -1]}");
string goAgain = string.Empty;
List<Car> cars = new List<Car>();
Init(cars);

do
{
    showCars(cars);

    Console.Write("Select listing #: ");
    int listing = int.Parse(Console.ReadLine());

    Buy(cars, listing);
    Add(cars);

    Console.Write("\nDo you want to view the updated inventory and shop again? (y/n): ");
    goAgain = Console.ReadLine().ToLower();
} while (goAgain[0] == 'y');



static void Init(List<Car> _cars)
{
    _cars.Add(new Car("Ford", "Explorer", 2022, 39999.99m));
    _cars.Add(new Car("Tesla", "Model 3", 2022, 77777.77m));
    _cars.Add(new Car("IDK", "Bugatti", 2021, 1000000.00m));

    _cars.Add(new Used("Chevy", "Camaro", 2019, 48499.99m, 23000.9));
    _cars.Add(new Used("Ferarri", "Spyder", 2015, 200000.99m, 12000.50));
    _cars.Add(new Used("GM", "Denali", 2012, 23499.99m, 65942.23));
}

static void showCars(List<Car> _cars)
{

    for (int i = 0; i < _cars.Count; i++)
    {
        Console.WriteLine($"Car listing # {i + 1}: {_cars[i]}\n");
    }
}

static void Buy(List<Car> _cars, int _listing)
{
    Console.WriteLine($"\nYou selected:\n {_cars[_listing - 1]}");
    Console.Write("\nDo you want to buy the car? (y/n): ");
    string res = Console.ReadLine().ToLower();

    if (res == "y")
    {
        Console.WriteLine($"\nYour purchase is below:\n {_cars[_listing - 1]}\n");
        _cars.RemoveAt(_listing - 1);
    }
    else
    {
        Console.WriteLine("Thanks for shopping, come again!");
    }
}

static void Add(List<Car> _cars)
{
    Console.Write("Do you want to sell (add) a car? (y/n): ");
    string res = Console.ReadLine().ToLower();

    if (res == "y")
    {
        Console.Write("Do you want to add a new or used car: ");
        res = Console.ReadLine().ToLower();

        if (res == "new")
        {
            Console.Write("Enter make: ");
            string make = Console.ReadLine();
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            _cars.Add(new Car(make, model, year, price));
        }
        else if (res == "used")
        {
            Console.Write("Enter make: ");
            string make = Console.ReadLine();
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter mileage: ");
            double mileage = double.Parse(Console.ReadLine());

            _cars.Add(new Used(make, model, year, price, mileage));
        }
    }
    else
    {
        return;
    }
}


class Car
{
    public string make;
    public string model;
    public int year;
    public decimal price;


    public Car(string _make, string _model, int _year, decimal _price)
    {
        make = _make;
        model = _model;
        year = _year;
        price = _price;
    }

    public override string ToString()
    {
        return $"\nMake: {make}\nModel: {model}\nYear: {year}\nPrice: ${price}";
    }
}

class Used : Car
{
    double mileage;
    public Used(string _make, string _model, int _year, decimal _price, double _mileage) : base(_make, _model, _year, _price)
    {
        mileage = _mileage;
    }

    public override string ToString()
    {
        return $"\n(USED) Make: {make}\nModel: {model}\nYear: {year}\nPrice: ${price} -- with {mileage} miles";
    }
}