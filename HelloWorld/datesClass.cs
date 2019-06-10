using System;
using System.Globalization;
namespace HelloWorld

{
    public class datesClass
    {
        public void practice()
        {
            var dateTime = new DateTime(2019, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

         /*   Console.WriteLine("Hour "+now.Hour);
            Console.WriteLine("Minute "+now.Minute);*/

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            /*   Console.WriteLine(now.ToLongDateString());
               Console.WriteLine(now.ToShortDateString());
               Console.WriteLine(now.ToLongTimeString());
               Console.WriteLine(now.ToShortTimeString());

               Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));*/


            //CREATING TIMESPAN OBJECTS
            var timespan = new TimeSpan(1, 2, 3);

            //these two are the same, second is more readable
            var timespan1 = new TimeSpan(1, 0, 0);
            TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration "+duration);

            //properties
            Console.WriteLine("Minutes "+ timespan.Minutes);
            Console.WriteLine("total minutes "+ timespan.TotalMinutes);

            //Add
            Console.WriteLine("add example: "+timespan.Add(TimeSpan.FromMinutes(8)));
            //Subtract
            Console.WriteLine("subtract example :"+ timespan.Subtract(TimeSpan.FromMinutes(2)));


            //ToString
            Console.WriteLine(timespan.ToString());

            //Parse
            Console.WriteLine("Parse :"+ TimeSpan.Parse("01:02:03"));
        }

    }

    }
 