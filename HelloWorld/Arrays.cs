using System; 
namespace HelloWorld
{
    public class Arrays
    {
        public void matrixArrays()
        {
            var matrix = new int[2, 5] { { 1,2,3,4,5},{ 6, 7, 8, 9, 10 } };
        }
        public void jaggedArray()
        {
            var jagged = new int[3][];
            jagged[0] = new int[3];
            jagged[1] = new int[5];
            jagged[2] = new int[2];
        }
        public void practice()
        {

            var numbers = new int[5] { 1, 3, 6, 3, 4 };
            Array.Sort(numbers); 
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("space between");
            var second = new int[5] { 1, 2, 3, 4, 5 };
            Array.Reverse(second); 
            foreach(var n in second)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("space between");
            var third = new int[5] { 8, 45, 2, 66, 4 };
            var index = Array.IndexOf(third, 66);
            Console.WriteLine(index);

            Console.WriteLine("space between");
            var fourth = new int[5] { 1, 2, 3, 4, 5 };
            Array.Clear(fourth, 1,1 );
            foreach(var n in fourth)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("space between");
            int[] fifth = new int[5];
            Array.Copy(fourth, fifth, 5);
            foreach(var n in fifth)
            {
                Console.WriteLine(n);
            }

       
            
        }

    }

    }
 