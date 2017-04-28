using System;
using System.Collections.Generic;
using AlgorithmTest.sort;
using AlgorithmTest.hash;

namespace AlgorithmTest{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "4";
            string[] p = test.Split(' ');
            for(int i=0; i<p.Length; i++){
                Console.WriteLine(p[i]);
            }
            List<int> l = new List<int>();
            Queue<int> arr = new Queue<int>();

            int[,] list = new int[4,5];
            Console.WriteLine("totalLength="+list.Length+", Length1="+list.GetLength(0)+", Length2="+list.GetLength(1));
            Console.WriteLine(list);
            // Console.WriteLine("Start");
            // HashTable hash = new HashTable(10);
            // int[] arr = {8,5,6,2,3,4,8,9,6,4,2};
            // for(int i=0; i<arr.Length; i++){
            //     hash.add(arr[i]);
            // }
            // hash.delete(2); 

            // hash.print();
            // // Test(new HeapSort());
            // Console.WriteLine("Finish");
        }

        public static void Test(dynamic SortAlgorithm){
            int[] arr = {8,5,6,2,3,4,8,9,6,4,2};
            SortAlgorithm.sort(arr);
            outputArray(arr);
        }

        private static void outputArray(int[] arr){
            for(int i=0; i<arr.Length; i++){
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}