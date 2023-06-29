namespace _2d_array;
internal class Player
{
    public int Id
    {
        get; set;
    }
    public string Name
    {
        get; set;
    }
    public int Age
    {
        get; set;
    }
    public int Number
    {
        get; set;
    }
    public string Position
    {
        get; set;
    }
    public string Foot
    {
        get; set;
    }

    public Player(string name, int age, int number, string position, string foot)
    {
        Name = name;
        Age = age;
        Number = number;
        Position = position;
        Foot = foot;
    }
}
