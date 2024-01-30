using System.Collections.Generic;
using System.Text;

namespace Binary_Trees_and_Linked_Lists
{
    public partial class Form1 : Form
    {
        BinarySearchTree myTree = new BinarySearchTree();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear tree
            myTree = new BinarySearchTree();

            //Get integers from textbox and split them by comma
            string[] values = txtInsert.Text.Split(',');

            //Insert each integer into search tree
            foreach (string value in values)
            {
                myTree.Insert(Convert.ToInt32(value));
            }

            txtDisplay.Text = DisplayTree(myTree);
        }
        private string DisplayTree(BinarySearchTree myTree)
        {
            StringBuilder sb = new StringBuilder();
            LevelOrderTraversal(myTree.root, sb);
            return sb.ToString();
        }
        private void LevelOrderTraversal(Node root, StringBuilder sb)
        {
            if (root == null)
                return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    Node current = queue.Dequeue();
                    sb.Append(current.Data + " ");

                    if (current.Left != null)
                        queue.Enqueue(current.Left);

                    if (current.Right != null)
                        queue.Enqueue(current.Right);
                }

                sb.AppendLine(); // Move to the next level
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.AddNodeToFront(5);
            linkedlist.AddNodeToFront(7);
            linkedlist.AddNodeToFront(1);
            linkedlist.AddNodeToFront(5);
            linkedlist.AddNodeToFront(10);
            linkedlist.AddNodeToFront(15);
            linkedlist.AddNodeToFront(4);

            txtLinkedListDisplay.Text = linkedlist.PrintList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.AddNodeToBack(5);
            linkedlist.AddNodeToBack(7);
            linkedlist.AddNodeToBack(1);
            linkedlist.AddNodeToBack(5);
            linkedlist.AddNodeToBack(10);
            linkedlist.AddNodeToBack(15);
            linkedlist.AddNodeToBack(4);

            txtLinkedListDisplay.Text = linkedlist.PrintList();
        }

        private void btnParenthesisCheck_Click(object sender, EventArgs e)
        {
            ParenthesesChecker checker = new ParenthesesChecker();
            checker.CheckForParentheses("() asdf [] { () []");
        }
    }
}
