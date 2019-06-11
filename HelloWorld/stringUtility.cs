using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class stringUtility
    {
       public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {

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
    }
}
