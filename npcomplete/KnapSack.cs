using System;

namespace AlgorithmTest.npcomplete{
    class KnapSack{
        private int n, Capacity;
        private int[] weight,value;
        const int MAX_NUM = 1000;
        int[,] dpBuffer;

        public KnapSack(){
            weight = new int[MAX_NUM];
            value = new int[MAX_NUM];
            dpBuffer = new int[MAX_NUM, Capacity];
        }

        public int search(int idx, int cap){
            if(dpBuffer[idx,cap]!=0){
                return dpBuffer[idx, cap];
            }
            int res;
            if(idx==n){
                res = 0;
            } else if(cap<weight[idx]){
                res = search(idx+1, cap);
            } else {
                res = Math.Max( search(idx+1, cap),
                                search(idx+1, cap-weight[idx])+value[idx]);
            }

            return dpBuffer[idx,cap] = res;
        }
    }
}