using System;
using System.Collections.Generic;
namespace HelloWorld
{
    public class stringClass
    {
        public void liveCoding()
        {
            var sentence = "this is going to be a really really really really long text";
            var summary = SummarizeText(sentence, 10);
            Console.WriteLine(summary);
        }

         static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            else {
                
                var words = text.Split(' ');
                var totalChars = 0;
                var summaryWords = new List<string>();
                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalChars += word.Length + 1;
                    if (totalChars >= maxLength)
                    {
                        break;
                    }
                   
                }
                var message = string.Join(" ", summaryWords) + " ...";
                return message;
            }
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
 