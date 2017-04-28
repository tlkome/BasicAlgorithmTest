using System;

namespace AlgorithmTest.sort{

    class QuickSort{
        public QuickSort(){

        }

        public void sort(int[] arr, int lEdge=0, int rEdge=-int.MaxValue){

            if(rEdge == -int.MaxValue) rEdge = arr.Length-1;
            
            if(lEdge < rEdge){
                int pivot = selectPivot(arr, lEdge, rEdge);
                if(pivot == -1){
                    Console.WriteLine("sorted");
                    return;
                }
                int l = lEdge;
                int r = rEdge;

                while(l < r){
                    while(l <= rEdge && arr[l] < pivot) l++;
                    while(r >= lEdge && arr[r] >= pivot) r--;

                    if(l > r) break;

                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    l++;
                    r--;
                }

                sort(arr, lEdge, l-1);
                sort(arr, r+1, rEdge);
            }
        }

        private int selectPivot(int[] arr, int lEdge, int rEdge){
            int p = 0;
            int count = 1;
            int size = rEdge - lEdge+1;
            while(count < size && arr[lEdge+count-1] == arr[lEdge+count]){
                count++;
            }
            if(count == size) return -1;
            p = arr[lEdge+count-1] < arr[lEdge+count] ? arr[lEdge+count] : arr[lEdge+count-1];

            return p;
        }
    }
}