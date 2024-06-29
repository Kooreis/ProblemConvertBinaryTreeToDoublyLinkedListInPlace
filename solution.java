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
}