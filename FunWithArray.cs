using System;
namespace FunWithArray {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("*********Fun with Array**********");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();


            Console.ReadLine();
        }
        static void SimpleArrays() {
            Console.WriteLine("Simple Array Creation.");
            // create an array of ints containing 3 elements indexed at 0, 1 , 2
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach(int i in myInts) Console.WriteLine(i);
            Console.WriteLine();

            //create a 100 item string array , indexed at 0 --- 99
            string[] booksOnDotNet = new  string[100];

        }

        static void ArrayInitialization() {
            Console.WriteLine("=> Array Initialization.");

            //Array initialization syntax using the new keyword
            string[] stringArray = new string[] {"one", "two", "three"};
            Console.WriteLine("stringArray has  {0} elements", stringArray.Length);
            
            //Array initialization without using the new keyword
            bool[] boolArray = {false, true, false,};
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            //Array initialization with new keyword and size
            int[] intArray = new int[4] {20, 22, 23, 0};
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        static void DeclareImplicitArrays() {
            Console.WriteLine("=> Implicit Array Initialization.");
            //a is really int[]
            var a = new[] {1, 2, 3, 4, 5, 6};
            Console.WriteLine("a is a: {0}", a.ToString());

            //b is really double 
            var b = new[] {1.2, 1.3, 1.4, 1.5, 1.6};
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really a string
            var c = new[] {"hello", "fun", "world"};
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        static void ArrayOfObjects() {
            Console.WriteLine("=> Array of Objects.");

            // An array of object can be anything at all
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach(object obj in myObjects) {
                // print the type and value for each item in the array
                Console.WriteLine("Type: {0}, Value : {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray() {
            Console.WriteLine("=> Rectangular Multi-Dimensional array ");
            // A rectangular MD array
            int[,] myMatrix;
            myMatrix = new int[3,4];

            // populate 3 by 4 array
            for(int i=0; i < 3; i++){
                for (int j=0; j < 4; j++) {
                    myMatrix[i, j] = i * j;
                }
            }

            // print (3 * 4) array
            for (int i=0; i < 3; i++){
                for (int j=0; j < 4; j++ ){
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /**
        The second type of multidimensional array is termed a jagged array. As the name implies, jagged arrays
        contain some number of inner arrays, each of which may have a different upper limit. Here’s an example:
        
        */
        static void JaggedMultidimensionalArray() {
            Console.WriteLine("=> Jagged MultiDimensional Array");
            // A jagged MD array (i.e an array of arrays)
            //Here we have an array of 5 different arrays

            int[][] myJagArray = new int[5][];
            
            //create the jagged array
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int [ i + 7];

            // print each row remember each element is defaulted to zero
            for (int i = 0; i < 5; i++){
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /**
        Arrays As Arguments or Return Values
        After you have created an array, you are free to pass it as an argument or receive it as a member return value.
        For example, the following PrintArray() method takes an incoming array of ints and prints each member to
        the console, while the GetStringArray() method populates an array of strings and returns it to the calle
        */

        static void PrintArray(int[] myInts) {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1} ", i, myInts[i]);
        }

        static string[] GetStringArray(){
            string[] theStrings = {"Hello", "from", "GetString"};
            return theStrings;

        }

        static void PassAndRecieveArrays(){
            Console.WriteLine("Arrays as params and Return values")
            //pass array as a parameter
            int[] ages = {20, 33, 24, 10};
            PrintArray(ages);

            // get array as a return value
            string[] strs = GetStringArray();
            foreach(string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        static void SystemArrayFunctionality(){
            Console.WriteLine("=> Working with System.Array.");
            //initialize array at startup
            string[] gothicBands = {"Tones on Tail", "Bauhaus", "Sister of Mercy"};

            //print out the names in declared order
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++) {
                //print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            //Reverse them 
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            // and print them 
            for (int i = 0; i < gothicBands.Length; i++){
                // print a name 
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // clear out all but the first member
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);

            for (int i = 0; i < gothicBands.Length; i++){
                // print a name 
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
        }
    }
}