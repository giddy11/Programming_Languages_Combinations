// See https://aka.ms/new-console-template for more information

using BinaryTree;

var tree = new Tree<int>();

tree.Root = new TreeNode<int>() { Data = 100 };
tree.Root.Left = new TreeNode<int>() { Data = 50 };
tree.Root.Right = new TreeNode<int>() { Data = 105 };

tree.Root.Left.Parent = tree.Root;
tree.Root.Right.Parent = tree.Root;

var tree1 = new TreeNode<string>("a");
var tree2 = new TreeNode<string>("b");
var tree3 = new TreeNode<string>("c");
var tree4 = new TreeNode<string>("d");
var tree5 = new TreeNode<string>("e");
var tree6 = new TreeNode<string>("f");

tree1.Left = tree2;
tree1.Right = tree3;
tree2.Left = tree4;
tree2.Right = tree5;
tree2.Parent = tree1;
tree3.Right = tree6;
tree3.Parent = tree1;
tree4.Parent = tree2;
tree5.Parent = tree2;
tree6.Parent = tree3;


/*
 using BinaryTree; // Make sure to import the BinaryTree namespace

var tree = new Tree<int>();

tree.Root = new TreeNode<int>() { Data = 100 };
tree.Root.Left = new TreeNode<int>() { Data = 50 };
tree.Root.Right = new TreeNode<int>() { Data = 105 };

// Connect the left and right nodes to their parent
tree.Root.Left.Parent = tree.Root;
tree.Root.Right.Parent = tree.Root;

// Add more nodes as needed

// ...

Console.WriteLine();
 */

Console.WriteLine();