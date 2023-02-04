namespace UrbanPlanner;

public class Building
{
    private string _designer = "Deanna";
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }

    public string Designer 
    { 
        get { return _designer; } 
    }

    public DateTime DateConstructed 
    { 
        get { return _dateConstructed; }
    }
    public string Address 
    {
        get { return _address; }
    }

    public string Owner
    {
        get { return _owner; }
    }
    public double Volume 
    {
        get { return Width * Depth * (3 * Stories); }
    }

    public Building(string address)
    {
        _address = address;
    }

    public void Construct()
    {
        _dateConstructed = DateTime.Now;
    }

    public void Purchase(string owner)
    {
        _owner = owner;
    }
}
