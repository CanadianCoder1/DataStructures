using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Binary_Trees_and_Linked_Lists
{
    public class LinkedList
    {
        int count;
        LinkedListNode head;
        LinkedListNode tail;
        
        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
            
        }
        public void AddNodeToFront(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;
        }
       

        public string PrintList()
        {
            string ret = "";
            LinkedListNode runner = head;
            while(runner != null)
            {
                ret += runner.data.ToString() + ",";
                runner = runner.next;
            }
            return ret.Trim(',');
        }


        public void AddNodeToBack(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            if (head == null)
            {
                // If the list is empty, make the new node both head and tail
                head = node;
                tail = node;
            }
            else
            {
                // Traverse the list to find the last node
                LinkedListNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                // Add the new node after the current tail
                current.next = node;
                // Update the tail to be the new node
                tail = node;
            }
            count++;

        }
    }
}
