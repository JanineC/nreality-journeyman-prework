using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JourneyManTrains.Classes;

namespace JourneyManTrains
{
    public partial class frmMain : Form
    {
        public Graph<string> TrainStations;

        public frmMain()
        {
            InitializeComponent();

            PopulateTownNodes();

            List<int> questions = new List<int>();
            questions.Add(Question1());
            questions.Add(Question2());
            questions.Add(Question3());
            questions.Add(Question4());
            questions.Add(Question5());

            foreach (var question in questions)
            {
                if (question > 0)
                {
                    MessageBox.Show(question.ToString(),"Question ");                
                }
                else
                {
                    MessageBox.Show("No such route exists");
                }
                
            }
         



        }

        private int Question1()
        {
            List<GraphNode<string>> q1 = new List<GraphNode<string>>();
            q1.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("A"));
            q1.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("B"));
            q1.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("C"));
            return TrainStations.GetDistanceBetweenMultipleNodes(q1);
        }

        private int Question2()
        {
            List<GraphNode<string>> q2 = new List<GraphNode<string>>();
            q2.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("A"));
            q2.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("D"));            
            return TrainStations.GetDistanceBetweenMultipleNodes(q2);
        }
        private int Question3()
        {
            List<GraphNode<string>> q3 = new List<GraphNode<string>>();
            q3.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("A"));
            q3.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("D"));
            q3.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("C"));
            return TrainStations.GetDistanceBetweenMultipleNodes(q3);
        }

        private int Question4()
        {
            List<GraphNode<string>> q4 = new List<GraphNode<string>>();
            q4.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("A"));
            q4.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("E"));
            q4.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("B"));
            q4.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("C"));
            q4.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("D"));
            return TrainStations.GetDistanceBetweenMultipleNodes(q4);
        }

        private int Question5()
        {
            List<GraphNode<string>> q5 = new List<GraphNode<string>>();
            q5.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("A"));
            q5.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("E"));
            q5.Add((GraphNode<string>)TrainStations.Nodes.FindByValue("D"));
            return TrainStations.GetDistanceBetweenMultipleNodes(q5);
        }
        public void PopulateTownNodes()
        {
            TrainStations = new Graph<string>();

            TrainStations.AddNode("A");
            TrainStations.AddNode("B");
            TrainStations.AddNode("C");
            TrainStations.AddNode("D");
            TrainStations.AddNode("E");
            TrainStations.AddNode("F");


            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("A"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("B"), 5);

            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("B"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("C"), 4);

            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("C"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("D"), 8);

            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("D"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("C"), 8);

            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("D"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("E"), 6);

            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("A"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("D"), 5);

            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("C"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("E"), 2);

            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("E"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("B"), 3);

            TrainStations.AddDirectedEdge((GraphNode<string>)TrainStations.Nodes.FindByValue("A"),
                (GraphNode<string>)TrainStations.Nodes.FindByValue("E"), 7);
        }
    }
}
