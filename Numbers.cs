using System;

namespace Numbers {
    class Program{
        static void Main(string[] args){
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range \n
            {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the \n
            range {double.MinValue:N0} to {double.MaxValue:N0}");
        }
    }
}