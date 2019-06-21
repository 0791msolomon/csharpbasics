using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class ProceduralProgramming
    {
        public void first()
        {
            Console.WriteLine("enter a series of numbers separated by hyphens");
            var response = Console.ReadLine();
            var split = response.Split('-');
            var answer = CheckConsecutive(split);
           if(answer)
                Console.WriteLine("consecutive");
             else
                Console.WriteLine("not consecutive");
        }
        public static bool CheckConsecutive(string[] split)
        {
            var consec = true;
            for (var i = 1; i < split.Length; i++)
            {
                if (i == split.Length - 1 && Convert.ToInt32(split[i]) > Convert.ToInt32(split[i - 1]))
                {
                    break;
                }
                else if (Convert.ToInt32(split[i]) > Convert.ToInt32(split[i - 1]))
                {
                    continue;
                }
                else
                {
                    consec = !consec;
                    break;
                }
            }
            return consec;
        }
        public void second()
        {
            Console.WriteLine("enter a few numbers separated bya hyphen");
            var response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
                return;

            var split = response.Split('-');
            var areDuplicates = AnyDuplicates(split); 
            if(areDuplicates)
                Console.WriteLine("duplicates");
            else
                Console.WriteLine("no duplicates");
        }
        public static bool AnyDuplicates(string[] split)
        {
            var dup = false;
            var numbers = new List<int>();

            foreach (var n in split)
            {
                if (numbers.Contains(Convert.ToInt32(n)))
                {
                    dup = !dup;
                    break;
                }
                numbers.Add(Convert.ToInt32(n));
            }
            if (dup)
                return true;
            else
                return false;
        }

        public void third()
        {
            Console.WriteLine("enter a time value in military format");
            var response = Console.ReadLine();
            var split = response.Split(':');
            var valid = ValidTime(split[0], split[1]);
            if(valid)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid time");
        }
        public static bool ValidTime(string hour, string minute)
        {

            if ((Convert.ToInt32(hour) >= 0 && Convert.ToInt32(hour) <= 23) && (Convert.ToInt32(minute) >= 0 && Convert.ToInt32(minute) <= 59))
            {
                return true;
            }
            else
                return false; 
        }
         
       public void fourth()
        {
            Console.WriteLine("enter words separated by spaces");
            var response = Console.ReadLine();
            var final = Pascal(response);
            Console.WriteLine(final);
        }
        public static String Pascal(string sentence)
        {
            var answer = ""; 
            foreach(var word in sentence.Split(" ")){
                var subword = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                answer += subword; 
            }
            return answer; 
        }
        public void fifth()
        {
            Console.WriteLine("enter an english word");
            var response = Console.ReadLine();
            var final = Counter(response);
            Console.WriteLine(final);
        }
        public static Int32 Counter (String word)
        {
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var count = 0; 
            foreach(var letter in word)
            {
                if (vowels.Contains(letter))
                {
                    count += 1; 
                }
            }
            return count; 
        }
    }

    }
 