﻿


RAM mod1 = new RAM("Intel", "DDR3", 32);
Console.WriteLine(mod1.Brand);
Console.WriteLine(mod1.Stock);
Console.WriteLine(mod1.Vendor);

mod1.Type = "DDR2";
Console.WriteLine(mod1.Type);

mod1.Type = "Hello";
Console.WriteLine(mod1.Type);

mod1.Stock = 100;
Console.WriteLine(mod1.Stock);

class RAM
{
    private string pBrand;
    private string pType;
    private int pGB;
    private int pStock;
    public string Vendor { get; set; }

    public RAM(string _Brand, string _Type, int _GB)
    {
        pBrand = _Brand;
        if (_Type == "DDR" || _Type == "DDR2" || _Type == "DDR3" || _Type == "DDR4")
        {
            pType = _Type;
        }
        else
        {
            pType = "DDR";
        }
        if (_GB >= 1 && _GB <= 32)
        {
            pGB = _GB;
        }
        else
        {
            pGB = 4;
        }
        pStock = 130;  // set to 130 during the constructor
        Vendor = "Amazon";
    }

    public string Brand
    {
        get
        {
            return pBrand;
        }
    }


    public string Type
    {
        get
        {
            return pType;
        }
        set
        {
            if (value == "DDR" || value == "DDR2" || value == "DDR3" || value == "DDR4")
            {
                pType = value;
            }
        }
    }

    public int Stock
    {
        get
        {
            return pStock;
        }
        set
        {
            pStock = value;
        }
    }
}