
Dog first = new Dog() { name = "Fido", hair = "Black", barkVolume = 8, legs = 4 };
Dog second = new Dog() { name = "Rico", hair = "Yellow", barkVolume = 5, legs = 4 };
Orangutan third = new Orangutan() { name = "Fred", hair = "Orange", legs = 2, thumbLength = 3 };


List <Mammal> pets = new List<Mammal>();
pets.Add(first);
pets.Add(second);
pets.Add(third);


foreach (Mammal pet in pets)   // var works too...
{
    string info = pet.ToString();
    Console.WriteLine(info);
    //Console.WriteLine(pet.name);
}



class Mammal
{
    public string name;
    public string hair;
    public int legs;

    public void Walk()
    {
        Console.WriteLine("I am walking!");
    }
    public override string ToString()
    {
        return $"This is a Mammal";
    }
}


class Dog : Mammal
{
    public int barkVolume; // how loud the dog's bark ise
    public void Bark()
    {
        Console.WriteLine("Bark!");
    }


    public override string ToString()
    {
        return $"Dog named {name}, hair {hair}, legs {legs}, and barks at volume {barkVolume}";
    }
}


class Orangutan : Mammal
{
    public int thumbLength;

    public override string ToString()
    {
        {
            return $"Orangutan named {name}, hair {hair}, legs {legs}, and thumbs are {thumbLength} inches.";
        }
    }
}