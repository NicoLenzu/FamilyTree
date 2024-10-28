namespace Library;

public class OldestChildAgeVisitor<T>:Visitor<T> where T : Person
{
    public int OldestChildAge { get; set; } = 0;

    public override void Visit(Node<T> node)
    {
        // Si el nodo no tiene hijos, comparo la edad de la persona con la edad del hijo más grande
        if (node.Children.Count == 0)
        {
            if (node.Content.Age > OldestChildAge)
            {
                OldestChildAge = node.Content.Age;
            }
        }
        // Visito a los hijos
        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }
}