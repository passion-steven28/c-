internal class Program
{
    private static void Main(string[] args)
    {
        person john = new person
        {
            Name = "passion"
        };

        Console.WriteLine("enter your year of birth");
        var birthYear = Console.ReadLine();

        for (var i = 0; i <= 2023; i++)
        {
            var currentYear = i;
            Console.WriteLine(currentYear);
        }

        //Console.WriteLine(current);
    }
    class person
    {
        public int? Id;
        public string? name;

        public string Name
        {
            get => name;

            set => name = value;
        }
    }
}

