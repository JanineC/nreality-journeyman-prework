using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyManTrains.Classes
{

    public class Graph<T> : IEnumerable<T>
    {
        private NodeList<T> nodeSet;

        public Graph() : this(null)
        {
        }

        public Graph(NodeList<T> nodeSet)
        {
            if (nodeSet == null)
                this.nodeSet = new NodeList<T>();
            else
                this.nodeSet = nodeSet;
        }

        public void AddNode(GraphNode<T> node)
        {
            // adds a node to the graph
            nodeSet.Add(node);
        }

        public void AddNode(T value)
        {
            // adds a node to the graph
            nodeSet.Add(new GraphNode<T>(value));
        }


        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);
        }

        public bool Contains(T value)
        {
            return nodeSet.FindByValue(value) != null;
        }

        public bool Remove(T value)
        {
            // first remove the node from the nodeset
            GraphNode<T> nodeToRemove = (GraphNode<T>) nodeSet.FindByValue(value);
            if (nodeToRemove == null)
                // node wasn't found
                return false;

            // otherwise, the node was found
            nodeSet.Remove(nodeToRemove);

            // enumerate through each node in the nodeSet, removing edges to this node
            foreach (GraphNode<T> gnode in nodeSet)
            {
                int index = gnode.Neighbors.IndexOf(nodeToRemove);
                if (index != -1)
                {
                    // remove the reference to the node and associated cost
                    gnode.Neighbors.RemoveAt(index);
                    gnode.Costs.RemoveAt(index);
                }
            }

            return true;
        }

        public NodeList<T> Nodes
        {
            get
            {
                return nodeSet;
            }
        }

        public int Count
        {
            get { return nodeSet.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int GetCost(GraphNode<T> Start, GraphNode<T> End)
        {
            var i = Start.Neighbors.IndexOf(End);
            return Start.Costs[i];
        }

        public int GetDistanceBetweenMultipleNodes(List<GraphNode<T>> listOfNodes)
        {
            int distance = 0;

            for (int i = 0; i < listOfNodes.Count - 1; i++)
            {
                if (listOfNodes[i].Neighbors.Contains(listOfNodes[i + 1]))
                {
                    distance += GetCost(listOfNodes[i], listOfNodes[i + 1]);
                }
                else
                {
                    return 0;
                }
            }

            return distance;
        }

        public int GetShortestRoute(GraphNode<T> Start, GraphNode<T> End)
        {
            //int distance = 0;
            //foreach (var node in nodeSet)
            //{
            //    if()
            //}
//            function Dijkstra(Graph, source):
//      dist[source] := 0                     // Initializations
//      for each vertex v in Graph:           
//4          if v ≠ source
//5              dist[v] := infinity           // Unknown distance from source to v
//6              previous[v] := undefined      // Predecessor of v
//7          end if
//8          PQ.add_with_priority(v,dist[v])
//9      end for 
//10
//11
//12     while PQ is not empty:                // The main loop
//13         u := PQ.extract_min()             // Remove and return best vertex
//14         for each neighbor v of u:         // where v has not yet been removed from PQ.
//15             alt = dist[u] + length(u, v) 
//16             if alt < dist[v]              // Relax the edge (u,v) 
//17                 dist[v] := alt 
//18                 previous[v] := u
//19                 PQ.decrease_priority(v,alt)
//20             end if
//21         end for
//22     end while
//23     return previous[]

            return 1;
        }
    }
}
