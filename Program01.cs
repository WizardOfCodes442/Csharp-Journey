using System;

namespace Program01 {
    class Program {
        public static void Main(string[] args) {

        }

        static void ObjectFunctionality() {
            Console.WriteLine("=> System.Object Functionality:");
            // A C# int is really a shorthand for System.Int32,
            // which inherits the following  members from System.object
            Console.WriteLine("12.GetHasCode() = {0}", 12.GetHasCode());
            Console.WriteLine("12.GetEquals(23) = {0}", 12.GetEquals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}" 12.GetType());
        }

        static void ParseFromStringWithTryParse() 
        {
            Console.WriteLine("=>Data Parsing with TryParse: ");
            if (bool.TryParse("True", out bool b));
            {
                Console.WriteLine("Value of b: {0}", b)
            }
            string value = "Hello";
            if (double.TryParse(value out double d))
            {
                Console.WriteLine("value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to double", value);
            }
            Console.WriteLine();

        }

        static void UseDateAndTimes()
        {
            Console.WriteLine("=> Dates and Times");
            
            // This Constructor takes year month day
            DateTime dt = DateTime(2015, 10, 17);

            //what day of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            // Month is now December .
            dt = dt.AddMonths(2);
            Console.Writeline("Daylight Savings: {0}", dt.IsDayLightSavingTime());

            //This Constructor takes (hours, minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            //Substract 15 minutes from the current timespan and print the result
            Console.WriteLine(ts.substract(new TimeSpan(0, 15 , 0)));

        }

        /*
        The new digit seperator also works with binary literals*/
        private static void BinaryLiterals() {
            Console.WriteLine("=> Use Binary Literals: ");
            Console.WriteLine("Sixteen: {0}", 0b001_0000);
            Console.WriteLine("Thirty Two", 0b010_0000)
        }
    }

}