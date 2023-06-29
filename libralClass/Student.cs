class Student
{
    //attributes
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    //methods for my class
    public void showDetails()
    {
        Console.WriteLine("student information");
        Console.WriteLine($"student id:{Id},student name: {Name},student address: {Address}");
    }
}
