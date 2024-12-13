using System;
namespace Program02 {
    class Program {
        static void Main(string[] args) {

            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, str2);
            Console.WriteLine("After:  {0}, {1}", str1, str2);

            #region Ref locals and params
            string[] stringArray = {"one", "two", "three"};
            int pos = 1;
            Console.WriteLine("=>Use Ref Return ");
            Console.WriteLine("Before: {0} , {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);
            ref var refOutput = ref SampleRefReturn(stringArray, pos);
            refOutput = "new";
            Console.WriteLine("After: {0}, {1}, {2} ", stringArray[0], stringArray[1], stringArray[2] );

        }
        
        // helper methods can go below
        /*
            Defining optionsl Parameters
        C# allows you to create methods that can take optional arguments . This technique allows the 
        caller to invoke a single method while omitting arguments deemed unneccessary, provided the caller
        is happy with the specified defaults.. a key motivation for adding optional arguments to C# is to 
        simplify interacting with COM objects , Several Microsoft objects models expose their functionality 
        via COM objects
        */
        static void EnterLogData(string message, string owner="Programmer") {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        /*The default manner in which a parameter is sent into a function is by value . 
        simply put , if you do not mark an argument with a parameter modifier , a copy 
        of the data is sent into the function. As explained later in this chapter , exactly 
        what is copied will depend on whether the parameter is a value type or a reference type
        */
        //Arguments are passed by value by default 
        static int Add(int x, int y) {
            int ans = x + y;
            //Caller will not see these changes 
            // as you are modifying a copy 
            // of the original data
            x = 10000;
            y = 88888;

        }

        /*
         The out Modifier
         Next you have the use of the output parameters . Methods that have been defined to take 
         output parameters (via the out keyword ) are under obligation to assign them to 
         an appropriate value before exiting the method scope (if you fail to do so , you will
         recieve compiler errors)

            To illustrate, here is an alternative version of the Add() methods that returns 
        the sum of two integers using the C# out mpodifier (note the physical return value 
        of this method is now void)
        */
        // Output parameters must be assigned by the called method.
        static void Add(int x, int y, out int ans) {
            ans = x + y;
        }
        /*
         Calling a method with the output modiefier also requires the use of the 
         out modifier . However , the local variables that are passed as output
         variables are not require to be assigned before passing them in 
         as output arguments (if you do so, the original value is lost after the call ). The 
         reason the compiler allows you to send in seemingly unassigned data is because , 
         the method being called must make an assignment. Starting with C# 7, out parameters 
         do not need to be declared before using them. in other words they can be declared inside 
         the method call, like this
        */
        
        /*
        The C# out modifier does serve a useful purpose; it allow the caller to obtain 
        multiple output from a single method invocatition
        */
        // Returning multiple output parameters
        static void FillTheseValues(out int a, out string b, out bool c) {
            a = 9;
            a = "Enjoy your string ";
            c = true;
        }
        
        /* remember that you must use the out modifier when you invoke the method ,
        as well as when you implement the method*/

        /*
            The reference modifier 
        Now consider the use of the C# ref parameter modifier . Reference parameters are necessary when 
        you want to allow a method to operate on (and usually change the values of ) various data points 
        declared in the caller's scope (such as sorting or swapping routine ). Note the distinction between
        output and reference parameters.

        ******* output parameters do not to be initialized before they are passed to the method 
        ******* The reason for this is that the method must assign output parameters before 
        ******* exiting

        ****** Reference parameters must be initialized before they passed to the method 
        ****** The reason for this is that you are passing a reference to an existing variable
        ****** If you don't assign it to an initial value , that would be equivalent of 
        ****** operating on an unassigned local variable
        */

        /*
        *** Let's check out the use of the ref keyword by way of a method that swaps two string 
        *** variables (any two data types could be used here , including int, bol, float and so on)

        */
        //Reference parameters
        public static void SwapStrings(ref string s1, ref string s2) {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        /*
        *** *** ref Locals and Returns
        *** In addition to modifying parameters with the ref keyword, C# 7 introduces, the ability 
        to use and return references to variables defined elswhere. Before showing how that works, 
        let's look at the following method
        */
        //Returns the value at the array position.
        public static string SimpleReturn(string[] strArray, int position) {
            return strArray[position];
        }

        /* 
        *** But what if you didn't want the value of the array position but instead a reference to the 
        *** array position, using the ref keyword makes it much simpler.
        *** There are two changes that need to be made to the simple method. The first is that instead of 
        *** straight return value , the method must do a return ref [reference to be returned ]. The second 
        *** change is that the method declaration must also include the ref keyword. 
         */
         // Returning a reference 
         public static ref string SampleRefReturn(string[] strArray, int position) {
             return ref strArray[position];
         }
         /*
         *** Calling this method also requires the use of the ref keyword, both for the 
         *** return variable and for method call itself, like this :
         *** *** ref var refOutput = ref SampleRefReturn(stringArray, pos);
         *** any change to the reference returned will also update the array, 
         */
    }
}