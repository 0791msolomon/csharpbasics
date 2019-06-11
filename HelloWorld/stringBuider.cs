using System;
using System.Text; 
namespace HelloWorld
{
   public class stringBuilder
    {
        public void buildingString()
        {
            //strings are immutable so you can use a string builder
            var builder = new StringBuilder("hello world");
            builder.Append('-', 10).AppendLine().Append("header").AppendLine().Append('-', 10).Replace('-', '+').Remove(0, 10).Insert(0, new String('-', 10));







            var char1 = builder[0];
              Console.WriteLine(builder);
        }
    }

    }
 