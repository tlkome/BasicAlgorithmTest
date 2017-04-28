using System;
using System.Collections.Generic;

namespace AlgorithmTest{
    class TravelSalesman{

        private int[,] costMap;
        const int CITY_NUM = 10;

        private int[,] memo;

        public TravelSalesman(){
            costMap = new int[CITY_NUM, CITY_NUM];
            memo = new int[CITY_NUM,CITY_NUM];
        }

        public int travel(int current, int state){
            if(memo[current,bitCount(state)]!=0){
                return memo[current,bitCount(state)];
            }

            int cost = 0;
            
            for(int i=0; i<CITY_NUM; i++){
                if(((state>>i) & 1)==0){
                    if(cost !=0)
                        cost = Math.Min(cost, travel(i, state+1<<i) + costMap[current, i]);
                }
            }
            
            return memo[current, bitCount(state)] = cost;
        }

        private int bitCount(int i){
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            i = (i + (i >> 4)) & 0x0f0f0f0f;
            i = i + (i >> 8);
            i = i + (i >> 16);
            return i & 0x3f;
        }
    }
}