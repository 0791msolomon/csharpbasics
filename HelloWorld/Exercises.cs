using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Exercises
    {
       public void Exercise1()
        {
            Console.WriteLine("enter a number between 1 and 10");
            var response = Convert.ToInt32(Console.ReadLine());
            if(response >=1 && response <= 10)
            {
                Console.WriteLine("that is valid");

            }
            else
            {
                Console.WriteLine("that's an invalid number");
            }
        }
           public void Exercise2()
        {
            Console.WriteLine("enter a number");
            var response1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            var response2 = Convert.ToInt32(Console.ReadLine());

            int finalAnswer = (response1 > response2) ? response1 : response2;
            Console.WriteLine(finalAnswer);
        }

        public void Exercise3()
        {
            Console.WriteLine("enter the width of a photo");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the height of the photo");
            var height = Convert.ToInt32(Console.ReadLine()); 
            if(height > width)
            {
                Console.WriteLine("this is in portrait mode");
            }
            else if(width > height)
            {
                Console.WriteLine("this is in landscape mode");
            }
            else
            {
                Console.WriteLine("the two values are the same it's a perfect square");
            }
        }

        public void Exercise4()
        {
            Console.WriteLine("what is the speed limit on your road");
            var limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how fast were you going?");
            var speed = Convert.ToInt32(Console.ReadLine()); 
            if(speed <= limit)
            {
                Console.WriteLine("you're fine, it's under or equal the speed limit");
            }
            else
            {
                int points = speed = limit / 5;
                string message = (points >= 12) ? "you just lost your license" : "you have " + points + " on your license now";
                Console.WriteLine(message);
            }
            
        }
    }
}
