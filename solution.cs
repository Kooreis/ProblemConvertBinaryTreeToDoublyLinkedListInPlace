Here is a C# console application that converts a binary tree to a doubly linked list in place:

```C#
using System;

public class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    Node root;

    void BinaryTree2DoubleLinkedList(Node root, ref Node head)
    {
        if (root == null)
            return;

        BinaryTree2DoubleLinkedList(root.left, ref head);

        if (prev == null)
            head = root;
        else
        {
            root.left = prev;
            prev.right = root;
        }
        prev = root;

        BinaryTree2DoubleLinkedList(root.right, ref head);
    }

    Node prev = null;

    void printList(Node node)
    {
        while (node != null)
        {
            Console.Write(node.data + " ");
            node = node.right;
        }
    }

    public static void Main(String[] args)
    {
        BinaryTree tree = new BinaryTree();

        tree.root = new Node(10);
        tree.root.left = new Node(12);
        tree.root.right = new Node(15);
        tree.root.left.left = new Node(25);
        tree.root.left.right = new Node(30);
        tree.root.right.left = new Node(36);

        Node head = null;
        tree.BinaryTree2DoubleLinkedList(tree.root, ref head);

        tree.printList(head);
    }
}
```

This program creates a binary tree and then converts it to a doubly linked list. The conversion is done in place, meaning the original binary tree nodes are used to form the linked list. The linked list is then printed to the console.