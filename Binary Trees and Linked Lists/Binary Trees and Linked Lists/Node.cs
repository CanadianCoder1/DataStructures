using System;


namespace Binary_Trees_and_Linked_Lists
{
    public class Node
{
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int data)
    {
        this.Data = data;
        this.Left = null;
        this.Right = null;
    }
}
    
}
