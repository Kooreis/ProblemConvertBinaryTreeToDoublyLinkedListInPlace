Here is a Java console application that converts a binary tree to a doubly linked list in place:

```java
class Node {
    int data;
    Node left, right;

    Node(int item) {
        data = item;
        left = right = null;
    }
}

class BinaryTree {
    Node root;

    void BinaryTree2DoubleLinkedList(Node root) {
        if (root == null)
            return;

        BinaryTree2DoubleLinkedList(root.left);

        if (prev == null)
            head = root;
        else {
            root.left = prev;
            prev.right = root;
        }
        prev = root;

        BinaryTree2DoubleLinkedList(root.right);
    }

    void printList(Node node) {
        while (node != null) {
            System.out.print(node.data + " ");
            node = node.right;
        }
    }

    static Node prev = null;
    static Node head = null;

    public static void main(String[] args) {
        BinaryTree tree = new BinaryTree();

        tree.root = new Node(10);
        tree.root.left = new Node(12);
        tree.root.right = new Node(15);
        tree.root.left.left = new Node(25);
        tree.root.left.right = new Node(30);
        tree.root.right.left = new Node(36);

        tree.BinaryTree2DoubleLinkedList(tree.root);

        tree.printList(head);
    }
}
```

This program creates a binary tree and then converts it to a doubly linked list in place. The conversion is done by doing an in-order traversal of the tree and updating the left and right pointers of the nodes to make them act as previous and next pointers of a doubly linked list. The list is then printed to the console.