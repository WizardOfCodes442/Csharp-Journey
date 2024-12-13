using System;
namespace FunWithMethod {
    class Program {
        //Argument are passed by value by default
        static int Add(int x, int y){
            int ans = x + y;
            // caller will not see these changes 
            // as you are modifying a copy of the 
            // original data 

            x = 10000;
            y = 88888;

            return ans;
        }

        static void Main(string[] args){
            Console.WriteLine("*****Fun With Methods *****\n");

            // pass two variables in by value
            int x = 9, y = 10;
            Console.WriteLine("Before call: x: {0}, y: {1}", x, y);
            Console.WriteLine("Answer is {1}: ", Add(x, y));
            Console.WriteLine("After call: x: {0}, y: {1}", x, y);

            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);

            Console.WriteLine("Int  is: {0}", i);
            Console.WriteLine("Strin is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);

            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1} ", str1, str2);

            Console.ReadLine();
        }


        //illustration of the out(parameter modifier) keyword
        //returning multiple output parameter
        static void FillTheseValues(out int a, out string b, out bool c){
            a = 9;
            b = "Enjoy Your String";
            c = true;
        }

        // refrence parameters
        public static void SwapStrings(ref string s1, ref string s2){
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
    }
}