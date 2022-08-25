
string goAgain = string.Empty;
List<Car> _cars = new List<Car>();
Init(_cars);

do
{
    showOptions();
    Console.Write("Select option: ");
    int option = int.Parse(Console.ReadLine());

    if (option == 1)
    {
        showCars(_cars);
    }
    else if (option == 2)
    {
        Buy(_cars);
    }
    else if (option == 3)
    {
        Add(_cars);
    }

    Console.Write("\nWant to go again? (y/n): ");
    goAgain = Console.ReadLine().ToLower();
} while (goAgain[0] == 'y');


static void Add(List<Car> _cars)
{
    bool again = true;

    while (again)
    {
        Console.Write("Do you want to sell a (new) or (used) car, or return to (menu): ");
        string res = Console.ReadLine().ToLower();

        if (res == "menu")
        {
            return;
        }
        else if (res == "new")
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
            Console.Write("Enter miles:");
            decimal mileage = decimal.Parse(Console.ReadLine());

            _cars.Add(new Used(make, model, year, price, mileage));
        }

        Console.Write("Do you want to sell another car? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            again = true;
        }
        else
        {
            again = false;
        }
    }
}


static void Buy(List<Car> _cars)
{
    bool again = true;

    while (again)
    {
        showCars(_cars);
        Console.Write("\nSelect listing # or -1 to return: ");
        int listing = int.Parse(Console.ReadLine());

        if (listing == -1)
        {
            return;
        }

        Console.WriteLine($"\nYou selected:\n {_cars[listing - 1]}\n");
        Console.Write("Do you want to purchase this car? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            _cars.RemoveAt(listing - 1);
        }
        else
        {
            Console.WriteLine("Thanks for shopping!");
            again = false;
        }
    }
}

static void showOptions()
{
    Console.WriteLine("Here's the options menu:");
    Console.WriteLine("-----------------------");
    Console.WriteLine("(1) View Inventory\n(2) Buy a Car\n(3) Sell a Car");
}

static void Init(List<Car> _cars)
{
    _cars.Add(new Car("Ford", "Explorer", 2022, 34000.45m));
    _cars.Add(new Car("GM", "Yukon", 2022, 1234.56m));
    _cars.Add(new Car("Chevy", "Tahoe", 2022, 3242.45m));

    _cars.Add(new Used("Tesla", "Model S", 2021, 23423.32m, 23423));
    _cars.Add(new Used("Audi", "Etron", 2016, 13233.32m, 6423));
    _cars.Add(new Used("Tesla", "Model S", 2021, 25653.32m, 12355));
}

static void showCars(List<Car> _cars)
{
    for (int i = 0; i < _cars.Count; i++)
    {
        Console.WriteLine($"Car listing # {i + 1}: {_cars[i]}\n");
    }
}

class Car
{
    public string make { get; set; }
    public string model { get; set; }
    public int year { get; set; }
    public decimal price { get; set; }


    public Car(string _make, string _model, int _year, decimal _price)
    {
        this.make = _make;
        this.model = _model;
        this.year = _year;
        this.price = _price;
    }

    public override string ToString()
    {
        return $"\nMake: {this.make}\nModel: {this.model}\nYear: {this.year}\nPrice: ${this.price}";
    }
}

class Used : Car
{
    public decimal mileage { get; set; }

    public Used(string _make, string _model, int _year, decimal _price, decimal _mileage) : base (_make, _model, _year, _price)
    {
        this.mileage = _mileage;
    }

    public override string ToString()
    {
        return $"\nMake: (Used) {this.make}\nModel: {this.model}\nYear: {this.year}\nPrice: ${this.price} and has {mileage} miles on it";
    }
}