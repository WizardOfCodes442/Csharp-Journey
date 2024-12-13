using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace New2 {
    class Program {
        // a simple program that process command line arguments using for loop
        public static void Main(string[] args){
            Console.WriteLine("\nA simple program that process command line arguments");
            Console.WriteLine("\n");
            
            //process any incoming args
            for (int i = 0; i < args.Length; i++){
                Console.WriteLine("Arg: {0} ", args[i]);
            }
            //press enter to quit program execution
            Console.ReadLine();

        }
    }
}