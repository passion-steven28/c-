using System;


namespace new_consoleAsp_about_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("here is my created instances of person class");
            Console.WriteLine("started with my friends");
            Console.WriteLine("\n");


            var person1 = new PersonClass("john", 20, "black", "male");
            person1.PersonIntro();
            person1.walkingStyle("fast");

            var person2 = new PersonClass("roze", 19, "white", "female");
            person2.PersonIntro();
            person2.walkingStyle("slow");

            var person3 = new PersonClass("husna", 20, "white", "female");
            person3.PersonIntro();
            person3.walkingStyle("fast");

            var person4 = new PersonClass("antelima", 20, "white", "female");
            person4.PersonIntro();
            person1.walkingStyle("fast");

            var person5 = new PersonClass("doline", 23, "black", "female");
            person5.PersonIntro();
            person5.walkingStyle("slow");

            Console.WriteLine("\n");
        }


        class PersonClass
        {
            public string name;
            public int age;
            public string color;
            public string gender;

            //methods of my person class
            public void PersonIntro()
            {
                Console.WriteLine($"my name is {name} i have {age} years old, im a {color} {gender}");
            }
            public void walkingStyle(string walking)
            {
                Console.WriteLine($"\t{name} walking {walking}");
            }

            public void eatStyle(string eat)
            {
                Console.WriteLine($"{name} is eating {eat}");
            }


            //craeting class controctor for reducing repeating writiing things
            public PersonClass(string personName, int personAge, string personColor, string personGender)
            {
                name = personName;
                age = personAge;
                color = personColor;
                gender = personGender;
            }
        }
    }
}
