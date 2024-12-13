using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace New3{
    class Program {
        public static void Main(string[] args){
            /*
            Finally, you are also able to access command-line arguments using the static GetCommandLineArgs()
method of the System.Environment type. The return value of this method is an array of strings. The first
index identifies the name of the application itself, while the remaining elements in the array contain the
individual command-line arguments. Note that when using this approach, it is no longer necessary to define
Main() as taking a string array as the input parameter, although there is no harm in doing so.
            */
            //Get command line arguments using System.Environment
            Console.WriteLine("\nThis simple program processes command arguments using System.Evironment namespace ");
            Console.WriteLine("\n");
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs) {
                Console.WriteLine("Arg: {0}", arg);  
            }

        } 
    }
}