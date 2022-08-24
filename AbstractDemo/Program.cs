
Digital music1 = new Digital("The Wall", "Pink Floyd", "iTunes");
Vinyl music2 = new Vinyl("Sgt. Pepper", "The Beatles", 1000);

List<Music> songs = new List<Music>();
songs.Add(music1);
songs.Add(music2);


// By adding "abstract" we are blocking anyone from creating an instance of MUSIC.
// We can still make instances of classes derived from music.
// We can still use the MUSIC Type in our lists.
abstract class Music
{
    public string title;
    public string artist;

    public Music(string _title, string _artist)
    {
        title = _title;
        artist = _artist;
    }

    //public virtual void Print()
    //{

    //}

    public abstract void Print();
}

class Digital : Music
{
    public string platform;

    public Digital(string _title, string _artist, string _platform) : base(_title, _artist)
    {
        platform = _platform;
    }

    public override void Print()
    {
        Console.WriteLine("This is a digital album!");
    }
}

sealed class Vinyl : Music
{
    public int count;

    public Vinyl(string _title, string _artist, int _count) : base(_title, _artist)
    {
        count = _count;
    }

    public override void Print()
    {
        Console.WriteLine("This is a vinyl record!");
    }
}