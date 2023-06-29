using System;

namespace new_consoleApp_about_class
{
    internal class Person
    {
        class PersonClass
        {
            public string name;
            public int age;
            public string color;
            public string gender;
            public string triable;

            //methods of my person class
            public void walkingStyle(string walking)
            {
                Console.WriteLine($"{name} walking {walking}");
            }

            public void eatStyle(string eat)
            {
                Console.WriteLine($"{name} is eating {eat}");
            }
        }
    }
}
