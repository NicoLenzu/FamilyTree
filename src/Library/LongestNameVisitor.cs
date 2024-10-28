namespace Library;

public class LongestNameVisitor<T>: Visitor<T> where T: Person
{
    public string LongestName { get; set; } = "";
    public override void Visit(Node<T> node)
    {
        // Si el nombre del nodo es más largo que el nombre más largo, lo guardo
        if (node.Content.Name.Length > LongestName.Length)
        {
            LongestName = node.Content.Name;
        }
        // Visito a los hijos
        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }
}