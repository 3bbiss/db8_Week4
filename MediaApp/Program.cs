
List<Media> allMedia = new List<Media>();
Init(allMedia);

while (true)
{
    string choice = printMenu(allMedia);
    if (choice == "A")
    {
        AddNew(allMedia);
    }
    else if (choice == "Q" || choice == "q")
    {
        break;
        // quit
    }
    else
    {
        int index = int.Parse(choice) - 1;
        Buy(allMedia, index);
    }
}



static void Init(List<Media> _allMedia)
{
    Video vid1 = new Video("The Shining", "Horror", "Kubrik", "R");
    Digital dig1 = new Digital("The Wall", "Rock", "Pink Floyd", 80, "iTunes");
    Vinyl vin1 = new Vinyl("who cares!", "classical", "bethoven", 12, 300);

    _allMedia.Add(vid1);
    _allMedia.Add(dig1);
    _allMedia.Add(vin1);
}


static void Buy(List<Media>_allMedia, int _index)
{
    Console.WriteLine("Is this the item you want to buy?");
    Console.WriteLine(_allMedia[_index]);  // grabbing the media instance and calling ITS ToString()
    Console.Write(" y/n: ");
    string yesno = Console.ReadLine().ToLower();
    if (yesno == "y" || yesno == "yes")
    {
        _allMedia.RemoveAt(_index);
        Console.WriteLine("Item purchased!");
    }
    else
    {
        Console.WriteLine("Thanks anyway!");
    }
}

static void AddNew(List<Media> _allMedia)
{
    Console.Write("What type of media do you want to add?: Video, Digital, or Vinyl?: ");
    string type = Console.ReadLine().ToLower();
    // Ask for title and genre, for the base-class. i.e. before the specific questions.
    Console.Write("Title: ");
    string title = Console.ReadLine();
    Console.Write("Genre: ");
    string genre = Console.ReadLine();

    if (type == "video")
    {
        Console.Write("Director: ");
        string director = Console.ReadLine();

        Console.Write("Rating: ");
        string rating = Console.ReadLine();

        _allMedia.Add(new Video(title, genre, director, rating));

    }
    else if (type == "digital")
    {
        Console.Write("Artist: ");
        string artist = Console.ReadLine();

        Console.Write("Duration: ");
        string duration = Console.ReadLine();

        Console.Write("Platform: ");
        string platform = Console.ReadLine();

        _allMedia.Add(new Digital(title, genre, artist, int.Parse(duration), "iTunes"));
    }
    else if (type == "vinyl")
    {
        Console.Write("Artist: ");
        string artist = Console.ReadLine();

        Console.Write("Duration: ");
        string duration = Console.ReadLine();

        Console.Write("Count: ");
        string count = Console.ReadLine();

        _allMedia.Add(new Vinyl(title, genre, artist, int.Parse(duration), int.Parse(count)));
    }
}


static string printMenu(List<Media> _allMedia)
{
    Console.WriteLine("Choose a media or other option:");
    for (int i = 0; i < _allMedia.Count; i++)
    {
        //Media med = allMedia[i];
        //Console.WriteLine($"{i}: {med}");

        Console.WriteLine($"{i + 1}: {_allMedia[i]}");
    }
    Console.WriteLine("(A)dd new media");
    Console.WriteLine("(Q)uit");
    Console.Write("Your choice: ");
    string entry = Console.ReadLine();
    return entry;
    //return Console.ReadLine();
}


class Media
{
    public string title;
    public string genre;
    public virtual void Play()
    {
        Console.WriteLine("The media is playing.");
    }
    public Media(string _title, string _genre)
    {
        title = _title;
        genre = _genre;
    }
}


class Video : Media
{
    public string director;
    public string rating;

   public Video(string _title, string _genre, string _director, string _rating) : base(_title, _genre)
    {
        director = _director;
        rating = _rating;
    }

    public override void Play()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"The video {title} ({genre}) - directed by {director} and rated: {rating}";
    }
}


class Music : Media
{
    public string artist;
    public int duration;

    public Music(string _title, string _genre, string _artist, int _duration) : base(_title, _genre)
    {
        artist = _artist;
        duration = _duration;
    }

    public override void Play()
    {
        //Console.WriteLine($"The song {title}({genre}) by {artist} is {duration} minutes long" );
        Console.WriteLine("Musics!");
    }
}


class Digital : Music
{
    public string platform;

    public Digital(string _title, string _genre, string _artist, int _duration, string _platform) : base(_title, _genre, _artist, _duration)
    {
        platform = _platform;
    }

    public override void Play()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Digital song {title} ({genre}) by {artist} on {platform} is {duration} mins long";
    }
}


class Vinyl : Music
{
    public int count;

    public Vinyl(string _title, string _genre, string _artist, int _duration, int _count) : base(_title, _genre, _artist, _duration)
    {
        count = _count;
    }

    public override void Play()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Vinyl song {title} ({genre}) by {artist} is {duration} mins long and there are {count} in the world!";
    }
}