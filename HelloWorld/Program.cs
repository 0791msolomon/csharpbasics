using System;
using HelloWorld.Math;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Matt = new Person();
            Matt.firstName = "matthew";
            Matt.lastName = "solomon";
            Matt.age = 27;
            Matt.Introduce();

            var dogs = new string[2];
            dogs[0] = "huxley";
            dogs[1] = "duncan";
            Console.WriteLine(dogs[0]);
            Console.WriteLine(dogs[1]);
        }

    }
}
