using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyManTrains.Classes
{
    public class GraphNode<T> : Node<T>
    {
        private List<int> costs;

        public GraphNode() : base()
        {
        }

        public GraphNode(T value) : base(value)
        {
        }


        public GraphNode(T value, NodeList<T> neighbors) : base(value, neighbors)
        {
        }

        public new NodeList<T> Neighbors
        {
            get
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>();

                return base.Neighbors;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public List<int> Costs
        {
            get
            {
                if (costs == null)
                    costs = new List<int>();

                return costs;
            }
        }
    }
}
