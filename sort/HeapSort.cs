
namespace AlgorithmTest.sort{

    class HeapSort{

        private int[] heap;
        private int count = 0;

        public HeapSort(){
        }

        private void create(int[] arr){
            heap = new int[arr.Length];
            for(int i=0; i<arr.Length; i++){
                insert(arr[i]);
            }
        }
        private void insert(int val){
            count++;
            int idx = count;

            while((idx!=1) && (heap[idx/2-1] > val)){
                heap[idx-1] = heap[idx/2-1];
                idx = idx/2;
            }
            heap[idx-1] = val;
        }

        private int removeRoot(){
            int val = heap[0];
            //先頭に持ってくる
            count--;
            heap[0] = heap[count];
            int rootVal = heap[0];
            int idx = 1;
            while(2*idx<=count){
                bool left = heap[2*idx-1] < rootVal;
                bool right = false;
                if(2*idx+1<=count){
                    right = heap[2*idx] < rootVal;
                }
                if(left && right){
                    if(heap[2*idx-1] < heap[2*idx]){
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

        public void sort(int[] arr){
            create(arr);
            
            for(int i=0; i<arr.Length; i++){
                arr[i] = removeRoot();
            }
        }
    }
}