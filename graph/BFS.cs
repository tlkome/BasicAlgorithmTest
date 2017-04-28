namespace AlgorithmTest.graph{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class BFS {
        void TEST(String[] args) {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string line;
            string[] p; 
            
            //まず問題数
            line = Console.ReadLine();
            int q = int.Parse(line);
            
            for(int i=0; i<q; i++){
                //頂点数とエッジの数
                line = Console.ReadLine();
                p = line.Split(' ');
                int nNum = int.Parse(p[0]);
                int eNum = int.Parse(p[1]);
                bool end = false;
                
                int[,] nodeList = new int [nNum, nNum];
                int sNode = -1;
                
                while(!end){
                    line = Console.ReadLine();
                    p = line.Split(' ');
                    if(p.Length > 1){
                        int node1 = int.Parse(p[0]);
                        int node2 = int.Parse(p[1]);
                        nodeList[node1-1, node2-1] = 1;
                        nodeList[node2-1, node1-1] = 1;
                    } else {
                        sNode = int.Parse(p[0]);
                        end = true;
                    }
                
                }
                bfs(nodeList, sNode);
            }
            
            
        }
        static void bfs(int[,] nodeList, int sNode){
            if(sNode < 1) return;
            
            int[] distance = new int[nodeList.GetLength(0)];
            Queue<int> children = new Queue<int>();
            children.Enqueue(sNode-1);

            while(children.Count > 0){
                int child = children.Dequeue();
                for(int i=0; i<nodeList.GetLength(0); i++){
                    if(child!=i && nodeList[child,i]==1 && distance[i] == 0){
                        distance[i] = distance[child]+6;
                        children.Enqueue(i);
                    }
                }
            }

            for(int i=0; i<distance.Length; i++){
                if(sNode-1 != i){
                    int dist = distance[i] == 0 ? -1 : distance[i];
                    Console.Write(dist+" ");
                }
            }
            Console.WriteLine();
        }
    }
}