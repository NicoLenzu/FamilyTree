namespace Library;

public abstract class Visitor<T>
{
    public abstract void Visit(Node<T> node);
}