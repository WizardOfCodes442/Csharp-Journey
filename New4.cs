using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace New4 {
    class Program{
        public static void Main(string[] args){
            Console.WriteLine("\nThis simple program uses The System.Environment namespace methods");
            Console.WriteLine("to prints some interesting facts about the development host ");
            Console.WriteLine("\n");

            //call the helper method ShowEnvironmentDetails for the interesting logic
            ShowEnvironmentDetails();
            Console.WriteLine();
        }
        static void ShowEnvironmentDetails() {
            //print out the drives on this machine 
            //and some other interesting details

            foreach(string drive in Environment.GetLogicalDrives()){
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of Processor: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NetVersion: {0}", Environment.Version);
        }

    }
}