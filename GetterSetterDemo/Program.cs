
RAM module1 = new RAM("Intel", "DDR3", 32);
Console.WriteLine(module1.getBrand());
Console.WriteLine(module1.getType());

module1.setType("DDR2");
Console.WriteLine(module1.getType());

module1.setGB(1000);
Console.WriteLine(module1.getGB());


class RAM
{
    // Common technique ("pattern") -- make all our member variables private
    // Generally true for most programming languages, not just C#
    private string brand;
    private string type; // DDR, DDR2, DDR3, DDR4
    private int gb;     //  any # between 1-32 inclusive


    public RAM(string _brand, string _type, int _gb)
    {
        brand = _brand;
        if (_type == "DDR" || _type == "DDR2" || _type == "DDR3" || _type == "DDR4")
        {
            type = _type;
        }
        else
        {
            type = "DDR";
        }

        if (_gb >= 1 && _gb <= 32)
        {
            gb = _gb;
        }
        else
        {
            gb = 4;
        }
    }

    // Protection
    // 1. User cannot change the BRAND, but can look at it.   Only Getter?
    // 2. User can set the TYPE and look at it, but is limited to available types.  Getter/Setter?
    // 3. User can set the GB and look at it, but is limited to range 1-32 inclusive. Getter/Setter?

    // Methods called getters/setters

    public string getBrand()
    {
        return brand;
    }

    public string getType()
    {
        return type;
    }

    public void setType(string _type)
    {
        // valid choices: DDR, DDR2, DDR3, DDR4
        if (_type == "DDR" || _type == "DDR2" || _type == "DDR3" || _type == "DDR4")
        {
            type = _type;
        }
    }


    public int getGB()
    {
        return gb;
    }

    public void setGB(int _gb)
    {
        if (_gb >= 1 && _gb <= 32)
        {
            gb = _gb;
        }
    }


    public void setBrand(string _brand)
    {
        brand= _brand;
    }
}

