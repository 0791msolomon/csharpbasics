using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
   public class Test
    {
        public void Exercise4()
        {
            Console.WriteLine("Enter the speed limit in your area");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how fast was your car traveling?");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed <= limit)
            {
                Console.WriteLine("you're going under or equal to the speed limit");
            }
            else
            {
                int points = (speed-limit) / 5;
                string message = (points > 12) ? "Your license is suspended" : "you have " + points + " on your license now";
                Console.WriteLine(message);
            }
        }
    }
}
