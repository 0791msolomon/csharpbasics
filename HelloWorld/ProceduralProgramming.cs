using System;
using System.Collections.Generic;
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
         
    }

    }
 