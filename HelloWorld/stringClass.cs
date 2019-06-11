using System;
using System.Collections.Generic;
namespace HelloWorld
{
    public class stringClass
    {
        public void liveCoding()
        {
            var sentence = "this is going to be a really really really really long text";
            var summary = stringUtility.SummarizeText(sentence,25);
            Console.WriteLine(summary);
        }

      
        public void practice()
        {
            var fullName = "Matt Solomon ";
            Console.WriteLine("Trim: '{0}' ", fullName.Trim());

            Console.WriteLine("to uppercase '{0}' ", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
           var names =  fullName.Split(' ');
            Console.WriteLine("first name: "+names[0]);
            Console.WriteLine("last name: "+names[1]);
           var newName = fullName.Replace("Matt", "Matthew");
            Console.WriteLine(newName);

            if (string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }
            var input = "25";
            var inputNumber = Convert.ToByte(input);
            Console.WriteLine(inputNumber);
            var price = 29.95f;
            var priceString = price.ToString("C0");
            Console.WriteLine(priceString);
        }
        public void formatting()
        {
            //ToLower()

            //ToUpper()

            //Trim()

            //IndexOf('a')

            //LastIndexOf("hello")

            //Substring(startIndex)

            //Substring(startIndex, length)

            //Replace('a','!')

            //String.IsNullOrEmpty(string)

            //String.IsNullOrWhiteSpace(string);

            //str.Split(' ')

            //Converting strings to numbers
            string s = "1234";

            int i = int.Parse(s);

            int j = Convert.ToInt32(s);

            //Converting numbers to strings
            int n = 1234;

            string numToString = n.ToString();

            string currency = i.ToString("C");

            string noDecimalCurrency = i.ToString("C0"); 
             
        }

    }

    }
 