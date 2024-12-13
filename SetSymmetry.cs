using System;

namespace SetSymmetry{
    class Program {
        public static void Main(string[] args){
            int[] A = {1, 2, 3};
            int [] B = {2, 4, 6};

            int [] C = difference(A, B);

            foreach(int a in C) {
                Console.WriteLine(a);
            }

        }
        static int[] difference (int[] setA, int[] setB){
            int count = 0;
            int[] setC = {};
            for (int i =0; i < setA.Length; i++){
                for (int j = 0; setB.Length; j++){
                    if(setA[i] == setB[i]){
                        break;n
                    }
                    setC[count] = setA[i];
                    count++;

                }

            }
            return setC;
        }
    }
}