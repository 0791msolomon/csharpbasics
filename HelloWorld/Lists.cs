using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Lists
    {
        public void exercise()
        {
            //similar to array, except size is dynamic;
            // Ensure you specify that you're using System.Collections.Generic up top
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 7, 8, 9 });
            /*  foreach(var n in numbers)
              {
                  Console.WriteLine(n);
              }*/
           var answer =  numbers.IndexOf(1);
            Console.WriteLine("the first index of 1 is position " + answer);
            var lastIndex = numbers.LastIndexOf(1);
            Console.WriteLine("the last index of number 1 is position "+lastIndex);

            Console.WriteLine("Count: "+numbers.Count);

            

           for(var i =0; i < numbers.Count; i++)
            {
                if(numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Clear();
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }

    }
 