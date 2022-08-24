

//if ((int)_p1.currentChoice == (int)_p2.currentChoice)
//{
//    Console.WriteLine($"Players: {_p1.name}{_p1.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: DRAW");
//}
//else if ((int)_p1.currentChoice > (int)_p2.currentChoice)
//{
//    Console.WriteLine($"Players: {_p1.name}{_p2.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: {_p1.name} wins!");
//}
//else
//{
//    Console.WriteLine($"Players: {_p1.name}{_p1.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: {_p2.name} wins!");
//}


// Random shi
//Random rand = new Random();
//Roshambo r1 = (Roshambo)rand.Next(0, 3);
//Console.WriteLine(r1);


RandomPlayer p1 = new RandomPlayer("carl");

AlwaysPlayer p2 = new AlwaysPlayer("jimmy", Roshambo.Rock);

AlwaysPlayer p3 = new AlwaysPlayer("sam", Roshambo.Rock);

RandomPlayer p4 = new RandomPlayer("tom");


Play(p1,p2);
Play(p3,p4);
Play(p4,p1);
Play(p3, p1);


static void Play(Player _p1, Player _p2)
{
    _p1.Generate();
    _p2.Generate();

    if (_p1.currentChoice != _p2.currentChoice)
    {
        if (_p1.currentChoice == Roshambo.Rock)
        {
            if (_p2.currentChoice == Roshambo.Scissors)
            {
                Console.WriteLine($"Players: {_p1.name}{_p2.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: {_p1.name} wins!");
            }
            else if (_p2.currentChoice == Roshambo.Paper)
            {
                Console.WriteLine($"Players: {_p1.name}{_p1.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: {_p2.name} wins!");
            }
        }
        else if (_p1.currentChoice == Roshambo.Scissors)
        {
            if (_p2.currentChoice == Roshambo.Rock)
            {
                Console.WriteLine($"Players: {_p1.name}{_p1.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: {_p2.name} wins!");
            }
            else if (_p2.currentChoice == Roshambo.Paper)
            {
                Console.WriteLine($"Players: {_p1.name}{_p2.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: {_p1.name} wins!");
            }
        }
        else // p1 is paper
        {
            if (_p2.currentChoice == Roshambo.Rock)
            {
                Console.WriteLine($"Players: {_p1.name}{_p2.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: {_p1.name} wins!");
            }
            else if (_p2.currentChoice == Roshambo.Scissors)
            {
                Console.WriteLine($"Players: {_p1.name}{_p1.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: {_p2.name} wins!");
            }
        }
    }
    else
    {
        Console.WriteLine($"Players: {_p1.name}{_p1.currentChoice} and {_p2.name}{_p2.currentChoice}. RESULT: DRAW");
    }
}




enum Roshambo
{
    Rock,
    Paper,
    Scissors
}


abstract class Player
{
    public string name;
    public Roshambo currentChoice;
    public virtual void Generate()
    {

    }
}

class RandomPlayer : Player
{
    public RandomPlayer(string _name)
    {
        name = _name;
    }

    public override void Generate()
    {
        Random rnd = new Random();
        currentChoice = (Roshambo)rnd.Next(0, 3);
    }
}

class AlwaysPlayer : Player
{
    public AlwaysPlayer(string _name, Roshambo _choice)
    {
        name = _name;
        currentChoice = _choice;
    }
}