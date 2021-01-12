using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static void DisplayHuman(Human human)
        {
            Console.WriteLine("{0} is {1} years old", human.Name, human.Age);
        }
        public Human()
        {
            Name = "";
            Age = 0;
        }
        public Human(string name , int age)
        {
            Name = name;
            Age = age;
        }
    }
}
