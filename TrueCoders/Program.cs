using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            People person1 = new People();
            person1.Age = 32;
            person1.FirstName = "Micheal";
            person1.LastName = "Doyle";
            person1.HairColor = "Brown";

            People person2 = new People();
            person2.Age = 24;
            person2.FirstName = "Charleston";
            person2.LastName = "Gilliand";
            person2.HairColor = "Red";

            People person3 = new People();
            person3.Age = 26;
            person3.FirstName = "Brandon";
            person3.LastName = "Chen";
            person3.HairColor = "Black";

            List<People> TrueCoders = new List<People>();
            TrueCoders.Add(person1);
            TrueCoders.Add(person2);
            TrueCoders.Add(person3);

            foreach (var human in TrueCoders)
            {
                Console.WriteLine($"{human.Age}, {human.FirstName}, {human.LastName}, {human.HairColor}");
            }
        }
    }
}
