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