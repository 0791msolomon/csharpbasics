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
           var copyInt = response;
            var total = 1;

            do
            {
                total *= response;
                response--;
            } while (response > 0);
            Console.WriteLine(copyInt+"!="+total);
        }
        public void exerciseFour()
        {
            var random = new Random().Next(1,10);
            for(var i =0; i < 4; i++)
            {
                Console.WriteLine("Try and guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == random)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("sorry you lost");
        }
        public void exerciseFive()
        {
            Console.WriteLine("Enter as many numbers as you'd like separated by commas");
            var response = Console.ReadLine();
            var splitNumbers = response.Split(','); 
            var max = Convert.ToInt32(splitNumbers[0]);
            foreach(var number in splitNumbers)
            {
                if (Convert.ToInt32(number) > max)
                {
                    max = Convert.ToInt32(number); 
                }
            }
            Console.WriteLine("your max number entered was "+max);

        }
        

    }
  

    }
 