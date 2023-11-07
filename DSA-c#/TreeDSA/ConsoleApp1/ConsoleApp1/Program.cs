// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

var tree = new Tree<int>();
tree.Root = new TreeNode<int>() { Data = 100 };
tree.Root.Children = new List<TreeNode<int>>()
{
    new TreeNode<int>(){Data = 50, Parent = tree.Root},
    new TreeNode<int>(){Data = 1, Parent = tree.Root},
    new TreeNode<int>(){Data = 150, Parent = tree.Root},
};

tree.Root.Children[2].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>(){Data = 30, Parent = tree.Root.Children[2]}
};


var company = new Tree<Person>();
company.Root = new TreeNode<Person>()
{
    Data = new Person(100, "Gideon Edoghotu", "CEO"),
};
company.Root.Children = new List<TreeNode<Person>>()
{
    new TreeNode<Person>(){Data = new Person(1, "John Smith", "Head of Development"), Parent = company.Root},
    new TreeNode<Person>(){Data = new Person(50, "Mary Fox", "Head of Research"), Parent = company.Root},
    new TreeNode<Person>(){Data = new Person(55, "Lily Smith", "Head of Sales"), Parent = company.Root},
};

company.Root.Children[2].Children = new List<TreeNode<Person>>()
{
    new TreeNode<Person>(){Data = new Person(5, "Anthony Black", "Senior Sales Specialist"), Parent = company.Root.Children[2]}
};

Console.WriteLine();