using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("enter a number between one and ten");
              var answer = Console.ReadLine();
             if(Int32.Parse(answer)> 0 && Int32.Parse(answer) < 11)
              {
                  Console.WriteLine("valid");
              }
              else
              {
                  Console.WriteLine("invalid"); 
              }*/


            /*Console.WriteLine("enter a number");
            var num1 = Console.ReadLine();
            Console.WriteLine("enter a second number");
            var num2 = Console.ReadLine();
            var total = Int32.Parse(num1) + Int32.Parse(num2);
            Console.WriteLine("the sum of your two numbers is " + total);*/


            Console.WriteLine("enter the width of an image");
            var width = Console.ReadLine();
            Console.WriteLine("enter the height of an image");
            var height = Console.ReadLine();
            if(Int32.Parse(width) > Int32.Parse(height))
            {
                Console.WriteLine("this image is in landscape mode");
            }
            else if(Int32.Parse(width) < Int32.Parse(height))
            {
                Console.WriteLine("this image is in portrait mode");
            }
            else
            {
                Console.WriteLine("the dimensions are the exact same");
            }
        }



    }
}
