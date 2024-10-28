namespace Library;

public class AgeSumVisitor<T>:Visitor<T> where T : Person
{
    public int AgeSum { get; set; } = 0;

    public override void Visit(Node<T> node)
    {
        // Sumo la edad de la persona
        Person person = node.Content;
        AgeSum += person.Age;
        // Visito a los hijos
        foreach (var child in node.Children)
        {
            child.Accept(this);
        }
    }
    
}