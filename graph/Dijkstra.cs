namespace AlgorithmTest.graph{

    class Dijkstra{
        private Node[] nodes;
        private int start = 0;

        void main(){

            foreach(Node node in nodes){
                node.done = false;
                node.cost = -1;
            }
            PriorityQueue q // 優先度付き待ち行列

            nodes[start].cost = 0; // スタートノードのコストは0
            q.push(nodes[start]);

            Node doneNode;
            // アルゴリズム実行
            while(!q.empty()){
                // 確定ノードを取り出す
                doneNode = q.pop();
                // 確定フラグを立てる
                doneNode.done = true;
                // 接続先ノードの情報を更新する
                for(int i = 0; i< doneNode.connectNodes.Length; i++){
                    int connectNode = doneNode.connectNodes[i];
                    int cost = doneNode.cost + doneNode.connectCosts[i];
                    if (nodes[connectNode].cost < 0 || cost < nodes[connectNode].cost){
                        nodes[connectNode].cost = cost;
                        if(!q.contain(nodes[connectNode])){
                            q.push(nodes[connectNode]);
                        }
                    }
                }
            }
        }

        class Node{
            public int[] connectNodes;
            public int[] connectCosts;
            public bool done;
            public int cost;
            public Node(){

            }
        }
    }
}