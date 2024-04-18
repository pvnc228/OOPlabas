using System;
public class Node
{
    private List<Node> children;
    private string value;

    public Node(string value)
    {
        this.value = value;
        this.children = new List<Node>();
    }

    public void AddChild(Node child)
    {
        children.Add(child);
    }
    public Node GetChild(int index)
    {
        if (index < 0 || index >= children.Count)
        {
            throw new IndexOutOfRangeException("Индекс выходит за пределы списка");
        }

        return children[index];
    }

    public void PrintTree()
    {
        Console.WriteLine(value);

        foreach (var item in children)
        {
            item.PrintTree();
        }
    }
}
