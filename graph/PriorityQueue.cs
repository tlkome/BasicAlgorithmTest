using System;
using System.Collections.Generic;
namespace AlgorithmTest.graph{
    class PriorityQueue{
        private Element[] heap;
        private int count;
        public PriorityQueue(int size){
            heap = new Element[size];
        }

        public bool contain(Object i){
            return false;
        }

        public void push(Object value, int priority){
            Element element = new Element(value, priority);

            count++;
            int idx = count;

            while((idx!=1) && (heap[idx/2-1].priority > priority)){
                heap[idx-1] = heap[idx/2-1];
                idx = idx/2;
            }
            heap[idx-1] = element;
        }

        private Object pop(){
            Object val = heap[0].value;
            //先頭に持ってくる
            count--;
            heap[0] = heap[count];
            Element rootVal = heap[0];
            int idx = 1;
            while(2*idx<=count){
                bool left = heap[2*idx-1].priority < rootVal.priority;
                bool right = false;
                if(2*idx+1<=count){
                    right = heap[2*idx].priority < rootVal.priority;
                }
                if(left && right){
                    if(heap[2*idx-1].priority < heap[2*idx].priority){
                        heap[idx-1] = heap[2*idx-1];
                        idx = 2*idx;
                    } else {
                        heap[idx-1] = heap[2*idx];
                        idx = 2*idx+1;
                    }
                } else if(left){
                    heap[idx-1] = heap[2*idx-1];
                    idx = 2*idx;
                } else if(right){
                    heap[idx-1] = heap[2*idx];
                    idx = 2*idx+1;
                } else {
                    break;
                }
            }
            heap[idx-1] = rootVal;

            return val;
        }

        class Element{
            public Object value;
            public int priority;
            public Element(Object value, int priority){
                this.value = value;
                this.priority = priority;
            }
        }
    }
}