using System;
namespace HelloWorld
{
    public class Exercises2{
        public void exerciseOne()
        {
            var count = 0;
            for(var i =0; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public void exerciseTwo()
        {
            var count = 0; 
            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit");
                var response = Console.ReadLine();
                if(response == "ok")
                {
                    Console.WriteLine(count);
                    break;
                }
               count += Convert.ToInt32(response);
            }
        }

        public void exerciseThree()
        {
            Console.WriteLine("enter any number");
            var response = Convert.ToInt32(Console.ReadLine());
            var first = Convert.ToInt32(Console.ReadLine()); 
             int answer=1;
            do
            {
                answer *= response;
                response--;
            } while (response > 0);
            Console.WriteLine(first+'!'+ " ="+answer);
        }
    }
  

    }
 