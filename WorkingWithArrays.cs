using System;

namespace WorkingWithArrays {
    class Program {
        public static void Main(string[] args) {
            DeclareImplicitArrays();
            ArrayOfObject();
            RectMultidimensionalArray();
            JaggedMultiDimensionalArray();

        }

        static void DeclareImplicitArrays(){
            Console.WriteLine("=> Implicit Array Initialization.");
            
            // a is really int[]
            var a = new[] {1, 2, 3, 4, 5};
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[]
            var b = new[] {1, 1.5, 2, 2.5};
            Console.WriteLine("b is b: ", b.ToString());

            // c is really string[]   
            var c = new [] {"hello", "null", "world"};
            Console.WriteLine("c is c: ", c.ToString());
            Console.WriteLine();

        }

        static void ArrayOfObject(){
            Console.WriteLine("=> Array of Objects.");
            //an array of object can be anyything 
            object[] myObject = new object[4];
            myObject[0] = 10;
            myObject[1] = false;
            myObject[2] = new DateTime(1969, 3, 24);
            myObject[3] = "Form & Void";
            foreach(object obj in myObject){
                //print the type and value of each item in the array
                Console.WriteLine("Type : {0}, value: {1}", obj.GetType(), obj);

            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray(){
            Console.WriteLine("=>Rectangular MultiDimensional Array");
            //A rectangular MD array
            int[,] myMatrix;
            myMatrix = new int[3,4];

            //populate 3 * 4 array .
            for (int i = 0; i < 3; i++)
                for(int j = 0; j < 4; j++ )
                    myMatrix[i, j] = i*j;
            

            //print (3* 4) array 
            for (int i = 0; i < 3; i++){
                for (int j=0; j < 4 ; j++){
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        
        static void JaggedMultiDimensionalArray(){
            Console.WriteLine("=> Jagged MultiDimensional Array ");
            //A  jagged M.D array i.e an array of array
            //here we have an array of 5 different arrays
            int[][] myJagArray = new int[5][];

            //create the jagged array 
            for(int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            //print each row, each element is element is defaulted to zero
            for (int i= 0; i < 5; i++){
                for (int j = 0; j < myJagArray[i].Length; j++){
                    Console.Write(myJagArray[i][j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] myInt) {
            for (int i = 0; i < myInt.Length; i++){
                Console.WriteLine("Item {0} is {1}", i, myInt[i]);
            }
        }

        static string[] GetStringArray() {
            string[] theString = {"Hello", "From", "The String"};
            return theString;
        }

        static void PassAndRecieveArrays(){
            Console.WriteLine("=> Arrays as parameters and return values ");
            //pass array as an argument
            int[] ages = {20, 22, 13, 0};
            PrintArray(ages);

            //Get array as return value
            string[] strs = GetStringArray();
            foreach(string s in strs) Console.WriteLine(s);

            Console.WriteLine();
        }

        static void SystemArrayFunctionality(){
            Console.WriteLine("=>Working with System.Array");
            //Initialize array at start up 
            string[] gothicBand = {"Tones on Tails", "Bauhaus", "Sisters of Mercy"};

            //print out names in declared order
            Console.WriteLine("-> Here is the array");
            for(int i = 0; i < gothicBand.Length; i++)
                Console.Write(gothicBand[i] + ", ");
            Console.WriteLine("\n");

            //Reverse the array
            Array.Reverse(gothicBand);
            Console.WriteLine("-> The reversed array");
            //... and print them
            for (int = 0; i < gothicBand.Length; i++) Console.WriteLine(gothicBand[i] + ", ");
            Console.WriteLine("\n");

            //clear out all but the first member
            Console.WriteLine("clear out all but one.. ");

            Array.Clear(gothicBand, 1, 2);

            for (int i = 0; i < gothicBand; i++){
                Console.WriteLine(gothicBand[i] + ", ");
            }
            Console.WriteLine();
        }

        static void ProcessBytes(){
            bytes b1 = 100;
            byte b2 = 250;

            //This time , tell the compiler CIL code
            // to throw an exception if overflow / underflow occured

            try {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);

            }
            catch (OverflowException ex){
                Console.Writeline(ex.Message);
            }
        }

        static void DeclareImplicitVars(){
            //Implicitly typed local variables.
            var myInt = 0;
            var myBool = true;
            var myString = " Time marches on....";

            //print the underlying type
            Console.WriteLine("myInt is a : {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a : {0}", myString.GetType().Name);

        }

        static void LinqQueryOverInts(){
            int [] numbers = {10, 20, 30, 40, 1, 2, 3, 4, 5, 6};
            //Linq query !
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset : ");
            foreach(var i in subset){
                Console.Write("{0} ", i);
            }
            Console>WriteLine();
            //what type is subset
            Console.WriteLine("subset is a : {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined  in : {0}", subset.GetType().Namespace);
            
        }

    }
}