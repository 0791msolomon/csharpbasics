using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class allExercises
    {
        public void exercise1()
        {
            Console.WriteLine("Please enter a number between 1 and 10");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number < 11)
            {
                Console.WriteLine("valid");
                return;
            }
            Console.WriteLine("Invalid");
        }
        public void exercise2()
        {
            Console.WriteLine("enter a number");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            var second = Convert.ToInt32(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("{0} is bigger", first);
                return;
            }
            Console.WriteLine("{0} is bigger", second);
        }
        public void exercise3()
        {
            Console.WriteLine("enter the height of the image");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the width of the image");
            var width = Convert.ToInt32(Console.ReadLine());
            if (height > width)
            {
                Console.WriteLine("this picture is in portrait mode");
                return;
            }
            Console.WriteLine("this picture is in landscape mode");
        }

        public void exercise4()
        {
            Console.WriteLine("enter the speed limit");
            var limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the speed of the car");
            var speed = Convert.ToInt32(Console.ReadLine());
            if (speed <= limit)
            {
                Console.WriteLine("your fine");
                return;
            }
            else
            {
                var points = (speed - limit) / 5;
                var message = points >= 12 ? "License suspended" : "You have " + points + " points on your license";
                Console.WriteLine(message);
            }
        }

        public void exercise5()
        {
            var count = 0;
            for (var i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public void exercise6()
        {
            var numbers = new List<int>();
            do
            {
                Console.WriteLine("enter a number or 'ok' to exit");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                    continue;
                }
            } while (true);

            var total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }
            Console.WriteLine(total);
        }
        public void exercise7()
        {
            Console.WriteLine("enter a number");
            var number = Convert.ToInt32(Console.ReadLine());
            var baseNumber = 1;
            for (var i = number; i > 0; i--)
            {
                baseNumber *= i;
            }
            Console.WriteLine("{0}!={1}", number, baseNumber);
        }

        public void exercise8()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            var won = 0;
            Console.WriteLine("random number is" + randomNumber);
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                var response = Convert.ToInt32(Console.ReadLine());
                if (response == randomNumber)
                {
                    Console.WriteLine("you won!");
                    return;
                }
                else if (i < 3)
                {
                    Console.WriteLine("wrong. guess again");
                    continue;
                }
                else
                {
                    Console.WriteLine("you lost");
                }
            }

        }
        public void exercise9()
        {
            var numbers = new List<int>();
            Console.WriteLine("enter a series of numbers separated by a comma, to exit just hit enter");
            var entered = Console.ReadLine();
            var split = entered.Split(',');
            var max = Convert.ToInt32(split[0]);
            foreach (var n in split)
            {
                if (Convert.ToInt32(n) > max)
                {
                    max = Convert.ToInt32(n);
                }
            }
            Console.WriteLine("max number is {0}", max);
        }

        public void exercise10()
        {
            var names = new List<string>();
            Console.WriteLine("enter names separated by a comma");
            var response = Console.ReadLine();
            var split = response.Split(',');
            if (string.IsNullOrEmpty(split[0]))
            {
                Console.WriteLine("your a loser");
                return;
            }
            if (split.Length == 1)
            {
                Console.WriteLine("{0} liked your post", split[0]);
            }
            else if (split.Length == 2)
            {
                Console.WriteLine("{0} and {1} liked your post", split[0], split[1]);
            }
            else if (split.Length > 2)
            {
                var remainder = split.Length - 2;
                Console.WriteLine("{0} , {1} and {2} others liked your post", split[0], split[1], remainder);
            }

        }

        public void exercise11()
        {
            Console.WriteLine("enter your name");
            var name = Console.ReadLine();
            var array = new char[name.Length];
            name.Split(" ");
            for (var i = 0; i < name.Length; i++)
            {
                array[i] = name[i];
            }
            Array.Reverse(array);
            var reversal = new string(array);
            Console.WriteLine(reversal);

        }

        public void exercise12()
        {
            var numbers = new List<int>();
            var total = 0;
            Console.WriteLine("enter 5 different numbers");
            do
            {

                var number = Convert.ToInt32(Console.ReadLine());
                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                    total += 1;
                    continue;
                }
                else
                {
                    Console.WriteLine("you already entered that number");
                    continue;
                }

            } while (total <= 4);
            numbers.Sort();
            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }
        }
        public void exercise13()
        {
            var numbers = new List<int>();
            Console.WriteLine("enter numbers spaced by ENTER or 'quit' to exit");
            while (true)
            {
                var response = Console.ReadLine();
                if (response.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(response));
                    continue;
                }
            }
            var unique = new List<int>();
            foreach (var n in numbers)
            {
                if (!unique.Contains(n))
                {
                    unique.Add(n);
                    continue;
                }
                else
                    continue;
            }
            Console.Write("your unique numbers are: ");
            foreach (var n in unique)
            {
                Console.Write(n + " ");
            }
        }

        public void exercise14()
        {
            var numbers = new List<int>();
            Console.WriteLine("enter at least five numbers separated by commas");
            var response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                Console.WriteLine("invalid list");
                return;
            }
            var split = response.Split(',');
            foreach (var n in split)
            {
                numbers.Add(Convert.ToInt32(n));
            }
            if (numbers.Count < 5)
            {
                Console.WriteLine("Invalid list");
            }
            else
            {
                numbers.Sort();
                Console.WriteLine("The 3 smallest numbers are {0} {1} and {2}", numbers[0], numbers[1], numbers[2]);
            }
        }

    }
    }
 