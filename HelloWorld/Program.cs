using System;
using HelloWorld.Math;
namespace HelloWorld
{

   
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0; 
            for(int i = 0; i < 101; i++)
            {
                if(i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);


        }
       
    

    }
}
