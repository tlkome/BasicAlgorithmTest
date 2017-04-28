using System;

namespace AlgorithmTest.sort{
    class MergeSort{

        public MergeSort(){

        }
        public void sort(int[] arr){
            int size = arr.Length;
            if( size > 1 ){
                int leftSize = arr.Length / 2;
                int rightSize = size - leftSize;
                int[] leftArr = new int[leftSize];
                int[] rightArr = new int[rightSize];

                for(int i=0; i<leftSize; i++) leftArr[i] = arr[i];
                for(int i=0; i<rightSize; i++) rightArr[i] = arr[leftSize+i]; 
                
                sort(leftArr);
                sort(rightArr);

                merge(leftArr, rightArr, arr);

                outputArray(arr);
            }
        }

        private void merge(int[] left, int[] right, int[] arr){
            int l=0, r=0;
            while(l < left.Length || r < right.Length){
                if(l < left.Length && r<right.Length && left[l] <= right[r]){
                    arr[l+r] = left[l]; l++;
                } else if(r < right.Length){
                    arr[l+r] = right[r]; r++;
                } else if(l >= left.Length){
                    arr[l+r] = right[r]; r++;
                } else if(r >= right.Length){
                    arr[l+r] = left[l]; l++;
                }
            }
        }

        private void outputArray(int[] arr){
            string output = "";
            for(int i=0; i<arr.Length; i++) output += arr[i] + " ";
            Console.WriteLine(output);
        }
    }
}