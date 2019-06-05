using System;

namespace HelloWorld
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public byte age;
        public void Introduce()
        {
            Console.WriteLine("Hello my name is "+firstName +" " + lastName + " and I'm " +age+ " years old");
        }
        public void test (string first, string second)
        {
            Console.WriteLine(first +" " + second);
        }
    }
}
