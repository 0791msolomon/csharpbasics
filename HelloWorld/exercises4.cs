using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class exercises4
    {
        public void exercise1()
        {
            Console.WriteLine("enter numbers separated bya hyphen");
            var response = Console.ReadLine();
            var numbers = response.Split('-');
            var consecutive = true;
            var i = 1;
            while (i < numbers.Length)
            {
                if (Convert.ToInt32(numbers[i]) < Convert.ToInt32(numbers[i - 1]))
                {
                    consecutive = !consecutive;
                    break;
                }
                i += 1;
            }
            if (consecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
                Console.WriteLine("not consecutive");

        }

        public void exercise2()
        {
            Console.WriteLine("enter numbers separated by a hyphen");
            var response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
            {
                return;
            }
            var numbers = new List<int>();
            var split = response.Split('-');
            foreach (var n in split)
            {
                numbers.Add(Convert.ToInt32(n));
            }
            numbers.Sort();
            var dups = false;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    dups = !dups;
                    break;
                }
            }
            if (dups)
            {
                Console.WriteLine("duplicates");
            }
            else
                Console.WriteLine("no dups");
        }
        public void exercise3()
        {
            Console.WriteLine("enter a time in military input: i.e 23:00");
            var response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
                Console.WriteLine("invalid");

            var split = response.Split(':');
            var hour = Convert.ToInt32(split[0]); 
            var minute = Convert.ToInt32(split[1]);
            var validHour = true;
            var validMinute = true; 
            if (hour < 0 || hour > 23)
                validHour = !validHour;
            if (minute < 0 || minute > 59)
                validMinute = !validMinute; 
            if(validMinute && validHour)
            {
                Console.WriteLine("valid");
            }
            else
                Console.WriteLine("invalid");
        }
        public void exercise4()
        {
            Console.WriteLine("enter a few words separated by spaces");
            var response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
            {
                return; 
            }
            var answer = ""; 
            foreach(var word in response.Split(" "))
            {
                var subword = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                answer += subword;
            }
            Console.WriteLine(answer);
            
        }

        public void exercise5()
        {
            Console.WriteLine("enter any word");
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var response = Console.ReadLine();
            var count = 0; 
            foreach(var letter in response)
            {
                if (vowels.Contains(letter))
                {
                    count += 1; 
                }
            }
            Console.WriteLine(count);
        }
    }
}
