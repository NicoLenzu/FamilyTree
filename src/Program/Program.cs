using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person grandparent = new Person("Grandparent", 75);
            Person parent1 = new Person("Parent1", 50);
            Person parent2 = new Person("Parent2", 48);
            Person child1 = new Person("Child1", 20);
            Person child2 = new Person("Child2", 18);
            Person child3 = new Person("Child3", 16);
            Person child4 = new Person("Child4LongestName", 14);

            Node<Person> root = new Node<Person>(grandparent);
            Node<Person> nodeParent1 = new Node<Person>(parent1);
            Node<Person> nodeParent2 = new Node<Person>(parent2);
            Node<Person> nodeChild1 = new Node<Person>(child1);
            Node<Person> nodeChild2 = new Node<Person>(child2);
            Node<Person> nodeChild3 = new Node<Person>(child3);
            Node<Person> nodeChild4 = new Node<Person>(child4);

            root.AddChildren(nodeParent1);
            root.AddChildren(nodeParent2);
            nodeParent1.AddChildren(nodeChild1);
            nodeParent1.AddChildren(nodeChild2);
            nodeParent2.AddChildren(nodeChild3);
            nodeParent2.AddChildren(nodeChild4);
            
            // visitar el árbol aquí
            
            AgeSumVisitor<Person> ageSumVisitor = new AgeSumVisitor<Person>();
            root.Accept(ageSumVisitor);
            Console.WriteLine(ageSumVisitor.AgeSum);
            
            OldestChildAgeVisitor<Person> oldestChildAgeVisitor = new OldestChildAgeVisitor<Person>();
            root.Accept(oldestChildAgeVisitor);
            Console.WriteLine(oldestChildAgeVisitor.OldestChildAge);
            
            LongestNameVisitor<Person> longestNameVisitor = new LongestNameVisitor<Person>();
            root.Accept(longestNameVisitor);
            Console.WriteLine(longestNameVisitor.LongestName);
        }
    }
}
