namespace memberClass;

internal class Member
{
    //member private field
    public string MemberName
    {
        get; set;
    }

    private readonly string memberName;
    private string jobTitle;
    private readonly double sarary;

    //member public field
    public int age;

    //member properties

    public string JobTitle
    {
        get => jobTitle;
        set => jobTitle = value;
    }

    //public member method - can called from other class
    public void introducing(bool isFriend)
    {
        if (isFriend)
        {
            sharingPrivateInfo();
        }
        else
        {
            Console.WriteLine($"my name is {MemberName}, and my job is {JobTitle}. I'm {age} years old");
        }
    }

    private void sharingPrivateInfo()
    {
        Console.WriteLine($"my salary is {sarary}");
    }

    //member constructor

    public Member()
    {
        memberName = "john Steven";
        jobTitle = "developer";
        sarary = 12222.20;
        age = 20;

        Console.WriteLine("object created");
    }

    //member finalize - destructor
    ~Member()
    {
        Console.WriteLine("member is destroyed");
    }
}