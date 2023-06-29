Car myCar = new()
{
    Make = "new",
    Model = "sportCar",
    Year = 2020,
    Color = "black"
};



Car myCar2 = myCar;
myCar2.Make = "new";

decimal value = determinMarketValue(myCar);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(value.ToString());

Console.WriteLine($"{myCar2.Make}\t{myCar2.Model}\t{myCar2.Year}\t{myCar2.Color}");

static decimal determinMarketValue(Car car)
{
    decimal carValue = 100.1m;
    return carValue;
}


class Car
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? Color { get; set; }
}