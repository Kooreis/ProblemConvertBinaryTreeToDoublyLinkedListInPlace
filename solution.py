Here is a Python solution for converting a binary tree to a doubly linked list in place:

```python
class Node:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None

class BinaryTree:
    def __init__(self):
        self.root = None

    def binary_tree_to_dll(self, root):
        if root is None:
            return root

        if root.left:
            left = self.binary_tree_to_dll(root.left)
            while left.right:
                left = left.right
            left.right = root
            root.left = left

        if root.right:
            right = self.binary_tree_to_dll(root.right)
            while right.left:
                right = right.left
            right.left = root
            root.right = right

        return root

    def binary_tree_to_dll_inplace(self):
        if self.root is None:
            return
        self.root = self.binary_tree_to_dll(self.root)
        while self.root.left:
            self.root = self.root.left

    def print_dll(self):
        if self.root is None:
            return
        current = self.root
        while current:
            print(current.data, end=" ")
            current = current.right
        print()

if __name__ == "__main__":
    bt = BinaryTree()
    bt.root = Node(10)
    bt.root.left = Node(12)
    bt.root.right = Node(15)
    bt.root.left.left = Node(25)
    bt.root.left.right = Node(30)
    bt.root.right.left = Node(36)

    bt.binary_tree_to_dll_inplace()
    bt.print_dll()
```

This Python program first creates a binary tree with the given nodes. Then it converts the binary tree to a doubly linked list in place using the `binary_tree_to_dll_inplace` method. The `binary_tree_to_dll` method is a helper method that does the actual conversion. Finally, it prints the doubly linked list using the `print_dll` method.