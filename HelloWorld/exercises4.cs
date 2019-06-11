using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class exercises4
    {
        public void exercise1()
        {
            Console.WriteLine("enter several numbers separated by a hyphen");
            var response = Console.ReadLine();
            var numbers = new List<int>();
            var split = response.Split('-');
            var consecutive = true;
            var i = 0; 
            while(i < split.Length)
            {
                if(i == split.Length-1)
                {
                    break;
                }
               else if(Convert.ToInt32(split[i+1])< Convert.ToInt32(split[i]))
                {
                    consecutive = !consecutive;
                    break;
                }
                else
                {
                    i += 1;
                }
            }
            if (consecutive)
            {
                Console.WriteLine("consecutive");
            }
            else
                Console.WriteLine("not consecutive");

        }

        public void exercise2()
        {
            Console.WriteLine("enter a few numbers separated by a hyphen");
            var response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
            {
                return; 
            }
            var split = response.Split('-');
            var numbers = new List<int>(); 
            foreach(var n in split)
            {
                numbers.Add(Convert.ToInt32(n));
            }
            numbers.Sort();
            var truth = true;
            for(var i =0; i < numbers.Count; i++)
            {
                if(i == numbers.Count-1)
                {
                    break;
                }
               else if(numbers[i] == numbers[i + 1])
                {
                    Console.WriteLine("Duplicate");
                    truth = !truth;
                    break;
                }
            }
            if (truth)
            {
                Console.WriteLine("no duplicates");
            }
        }
    }
}
