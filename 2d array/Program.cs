using _2d_array;

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("\t\t\t\t WELCOME TO MANCHERSTER UNITED TEAM SQUAD\n");

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("\t\t\t the following are the list of player we have in our squad\n");

Console.ForegroundColor = ConsoleColor.Red;
List<Player> player = new List<Player>
{
    new Player("David degea", 28, 1, "goalkeeper", "left"),
    new Player("Aron wan-bisaka", 24, 2, "left-side-back", "right"),
    new Player("Luke shaw", 32, 3, "right-side-back", "left"),
    new Player("Raphael varrane", 34, 4, "center-back", "left"),
    new Player("Martinez", 29, 5, "center-back", "right"),
    new Player("Fred", 26, 7, "defense-midfield", "right"),
    new Player("Scott MCtommney", 22, 6, "defense-midfield", "right"),
    new Player("jadon Sancho", 21, 8, "right-wing", "left"),
    new Player("bluno Fernandez", 26, 9, "center-forward", "right"),
    new Player("Antoni", 22, 11, "left-wing", "left"),
    new Player("Marcus rashford", 23, 10, "center-forward", "right")
};


for (var i = 0; i < player.Count; i++)
{

    var p = player[i];
    Console.WriteLine($"\n\t\t\t {i + 1}:{p.Name},{p.Age}");
}
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("\n choose the no of player to see more info about he");
var choosenNo = int.Parse(Console.ReadLine());

switch (choosenNo)
{
    case 1:
        Console.WriteLine($"\tName: {player[0].Name}\n\tage: {player[0].Age}\n\tJessy no: {player[0].Number}\n\tposition: {player[0].Position}\n\tfoot: {player[0].Foot}");
        break;
    case 2:
        Console.WriteLine($"\tName: {player[1].Name}\n\tage: {player[1].Age}\n\tJessy no: {player[1].Number}\n\tposition: {player[1].Position}\n\tfoot: {player[1].Foot}");
        break;
    case 3:
        Console.WriteLine($"\tName: {player[2].Name}\n\tage: {player[2].Age}\n\tJessy no: {player[2].Number}\n\tposition: {player[2].Position}\n\tfoot: {player[2].Foot}");
        break;
    case 4:
        Console.WriteLine($"\tName: {player[3].Name}\n\tage: {player[3].Age}\n\tJessy no: {player[3].Number}\n\tposition: {player[3].Position}\n\tfoot: {player[3].Foot}");
        break;
    case 5:
        Console.WriteLine($"\tName: {player[4].Name}\n\tage: {player[4].Age}\n\tJessy no: {player[4].Number}\n\tposition: {player[4].Position}\n\tfoot: {player[4].Foot}");
        break;
    case 6:
        Console.WriteLine($"\tName: {player[5].Name}\n\tage: {player[5].Age}\n\tJessy no: {player[5].Number}\n\tposition: {player[5].Position}\n\tfoot: {player[5].Foot}");
        break;
    case 7:
        Console.WriteLine($"\tName: {player[6].Name}\n\tage: {player[6].Age}\n\tJessy no: {player[6].Number}\n\tposition: {player[6].Position}\n\tfoot: {player[6].Foot}");
        break;
    case 8:
        Console.WriteLine($"\tName: {player[7].Name}\n\tage: {player[7].Age}\n\tJessy no: {player[7].Number}\n\tposition: {player[7].Position}\n\tfoot: {player[7].Foot}");
        break;
    case 9:
        Console.WriteLine($"\tName: {player[8].Name}\n\tage: {player[8].Age}\n\tJessy no: {player[8].Number}\n\tposition: {player[8].Position}\n\tfoot: {player[8].Foot}");
        break;
    case 10:
        Console.WriteLine($"\tName: {player[9].Name}\n\tage: {player[9].Age}\n\tJessy no: {player[9].Number}\n\tposition: {player[9].Position}\n\tfoot: {player[9].Foot}");
        break;
    case 11:
        Console.WriteLine($"\tName: {player[10].Name}\n\tage: {player[10].Age}\n\tJessy no: {player[10].Number}\n\tposition: {player[10].Position}\n\tfoot: {player[10].Foot}");
        break;
    default:
        Console.WriteLine($"chose no between 1 to {player.Count}");
        break;
}





Console.ForegroundColor = ConsoleColor.Black;