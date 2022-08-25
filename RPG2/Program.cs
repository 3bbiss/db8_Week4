


List<GameCharacter> gameCharacters = new List<GameCharacter>();


gameCharacters.Add(new GameCharacter("bot1", 14, 20));
gameCharacters.Add(new GameCharacter("bot2", 12, 25));

gameCharacters.Add(new Warrior("Spartacus", 100, 50, "Sword"));
gameCharacters.Add(new Warrior("Kratos", 999, 999, "Spartan Rage"));

gameCharacters.Add(new Magic("Harry", 21, 134, 234));


gameCharacters.Add(new Wizard("Hilty", 201, 32, 23, 32));


foreach (GameCharacter character in gameCharacters)
{
    character.Play();
}



class GameCharacter
{
    private string name;
    private int strength;
    private int intelligence;


    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public GameCharacter(string _name, int _strength, int _intelligence)
    {
        name = _name;
        strength = _strength;
        intelligence = _intelligence;
    }

    public virtual void Play()
    {
        Console.WriteLine($"{name} -- Strength: {strength} -- Intelligence: {intelligence}");
    }

}


class Warrior : GameCharacter
{
    private string weapon;
    public string Weapon
    {
        get { return weapon; }
        set { weapon = value; }
    }

    public Warrior(string _name, int _strength, int _intelligence, string _weapon) : base (_name, _strength, _intelligence)
    {
        weapon = _weapon;
    }

    public override void Play()
    {
        Console.WriteLine($"{weapon} Warrior {Name} -- Strength:{Strength} -- Intelligence:{Intelligence} ");
    }

}

class Magic : GameCharacter
{
    private int energy;
    public int Energy
    {
        get { return energy; }
        set { energy = value; }
    }

    public Magic (string _name, int _strength, int _intelligence, int _energy) : base(_name, _strength, _intelligence)
    {
        energy = _energy;
    }

    public override void Play()
    {
        Console.WriteLine($"Magic user {Name} with {energy} energy level -- strength: {Strength} -- intelligence: {Intelligence}");
    }
}

class Wizard : Magic
{
    private int spells;
    public int Spells
    {
        get { return spells; }
        set { spells = value; }
    }

    public Wizard(string _name, int _strength, int _intelligence, int _energy, int _spells) : base(_name, _strength, _intelligence, _energy)
    {
        spells = _spells;
    }

    public override void Play()
    {
        Console.WriteLine($"Wizard {Name} with {spells} spells and {Energy} energy");
    }
}