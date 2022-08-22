


List<GameCharacter> gameCharacters = new List<GameCharacter>();

gameCharacters.Add(new GameCharacter("bot1", 14, 20));
gameCharacters.Add(new GameCharacter("bot2", 12, 25));

gameCharacters.Add(new Warrior("Spartacus", 100, 50, "Sword"));
gameCharacters.Add(new Warrior("Kratos", 999, 999, "Spartan Rage"));

gameCharacters.Add(new MagicUsingCharacter("Atlus", 18, 99, 80));


gameCharacters.Add(new Wizard("Harry", 30, 150, 99, 12));
gameCharacters.Add(new Wizard("Wanda", 50, 240, 39, 42));
gameCharacters.Add(new Wizard("Loki", 250, 349, 123, 100));




foreach (GameCharacter character in gameCharacters)
{
    character.play();
}


class GameCharacter
{
    public string name;
    public int strength;
    public int intelligence;

    public GameCharacter(string _name, int _strength, int _intelligence)
    {
        name = _name;
        strength = _strength;
        intelligence = _intelligence;
    }

    public virtual void play()
    {
        Console.WriteLine($" NPC {name}: {strength} strength -- {intelligence} intelligence");
    }
}


class Warrior : GameCharacter
{
    public string weaponType;

    public Warrior(string _name, int _strength, int _intelligence, string _weaponType) : base(_name, _strength, _intelligence)
    {
        weaponType = _weaponType;
    }

    public override void play()
    {
        Console.WriteLine($" Warrior {name} - strength:{strength} - intelligence:{intelligence} - weapon:{weaponType}");
    }
}


class MagicUsingCharacter : GameCharacter
{
    public int magicalEnergy;

    public MagicUsingCharacter(string _name, int _strength, int _intelligence, int _magicalEnergy) : base(_name, _strength, _intelligence)
    {
        magicalEnergy = _magicalEnergy;
    }

    public override void play()
    {
        Console.WriteLine($" Magic User {name} - strength:{strength} - intelligence:{intelligence} - magic energy:{magicalEnergy}");
    }
}


class Wizard : MagicUsingCharacter
{
    public int spellNumber;

    public Wizard(string _name, int _strength, int _intelligence, int _magicalEnergy, int _spellNumber) : base(_name, _strength, _intelligence, _magicalEnergy)
    {
        spellNumber = _spellNumber;
    }

    public override void play()
    {
        Console.WriteLine($" Wizard {name} - strength:{strength} - intelligence:{intelligence} - magic energy:{magicalEnergy} - spell number:{spellNumber}");
    }
}