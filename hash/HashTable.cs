using System;
namespace AlgorithmTest.hash{
    class HashTable{
        private Node[] table;
        private int capacity;

        public HashTable(int capacity){
            this.capacity = capacity;
            table = new Node[capacity];
        }

        private int getHashCode(Object obj){
            return obj.GetHashCode() % capacity;
        }
        public void add(Object obj){
            int code = getHashCode(obj);
            Node n = this.table[code];
            Node m = new Node(obj);

            if(n == null) this.table[code] = m;
            while(n != null){
                if(n.val.Equals(obj)) return;
                else if(n.next == null){
                    n.next = m;
                }
            }
        }

        public void delete(Object obj){
            int code = getHashCode(obj);
            Node n = this.table[code];

            if(n == null) return;
            else if(n != null && n.val.Equals(obj)){
                this.table[code] = null;
                return;
            }
            while(n.next != null){
                if(n.next.val.Equals(obj)){
                    n.next = n.next.next;
                    return;
                }
                n = n.next;
            }
        }

        public bool contains(Object obj){
            int code = getHashCode(obj);
            Node n = this.table[code];
            while(n!=null && !n.val.Equals(obj)){
                n = n.next;
            }
            return n != null;
        }

        public void print(){
            for(int i=0; i<table.Length; i++){
                Node n = table[i];
                while(n!= null){
                    Console.Write(n.val+" ");
                    n = n.next;
                }
                Console.WriteLine();
            }
        }

        internal class Node{
            internal Object val;
            internal Node next;
            internal Node(Object val){
                this.val = val;
                this.next = null;
            }
        }
    }

    
}