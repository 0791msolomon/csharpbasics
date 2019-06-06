using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Iteration
    {
        public void forLoop()
        {
            for(var i =10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void ForEachh()
        {
            string name = "Matt Solomon";
           foreach(var letter in name)
            {
                Console.WriteLine(letter);
            }
        }
        public void ForEachArray()
        {
            var numbers = new int[] { 1,2,3,4};
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void whileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        public void dowhileLoop()
        {
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 10);
        }
        public void checkString()
        {
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }

}
