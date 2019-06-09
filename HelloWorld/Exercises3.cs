using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Exercises3
    {
        public void exercises1()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("type a name and hit enter to add, hit enter without anything to quit");
                var name = Console.ReadLine();
                if (name.Length > 0)
                    names.Add(name);
                else
                    break;
            }
            if (names.Count == 1)
            {
                Console.WriteLine("{0} liked your post", names[0]);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} liked your post" , names[0], names[1]);
            }
            else if (names.Count > 2)
                Console.WriteLine("{0} {1} and {2} others liked your post", names[0], names[1], (names.Count - 2));
            else return;
        }

        public void exercise2()
        {
            Console.WriteLine("enter your name");
            var name = Console.ReadLine();
            var nameArray = new char[name.Length];
            for(var i = 0; i < name.Length; i++)
            {
                nameArray[i] = name[i];
            }
            Array.Reverse(nameArray);
            var reversedName = new String(nameArray);
            Console.WriteLine(reversedName);
            
        }

        public void exercise3()
        {
            var numbers = new List<int>();
           
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number");
                var entered = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(entered))
                {
                    Console.WriteLine("you already entered that numbers, choose another");
                    continue;
                }
                numbers.Add(entered); 
            }
            numbers.Sort(); 
            foreach(var n in numbers)
            {
                Console.Write(n + " ");
            }
        }

        public void exercise4()
        {
            var numbers = new List<int>();
            var unique = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or type 'Quit' to exit");
                var response = Console.ReadLine();
                if (response == "quit" || response == "Quit")
                {
                    break;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(response));
                }
            }
            foreach (var number in numbers)
            {
                if (unique.Contains(number))
                {
                    continue;
                }
                else
                {
                    unique.Add(number);
                }
            }
            foreach (var n in unique)
            {
                Console.Write(n + " ");
            }

        }
        public void exercise5()
        {
            var numbers = new List<int>();
            Console.WriteLine("supply a list of comma separated numbers");
            var response = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("invalid list");
                return; 
            }
            var split = response.Split(',');
            if(split.Length < 5)
            {
                Console.WriteLine("invalid List");
                return; 
            }
            Array.Sort(split);
            Console.Write("{0} {1} {2}", split[0], split[1], split[2]);
        }
       
    }

    }
 