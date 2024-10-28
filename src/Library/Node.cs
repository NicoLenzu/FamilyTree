using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private T content;

        private List<Node<T>> children = new List<Node<T>>();

        public T Content {
            get
            {
                return this.content;
            }
        }

        public ReadOnlyCollection<Node<T>> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T node)
        {
            this.content = node;
        }
        

        public void AddChildren(Node<T> child)
        {
            this.children.Add(child);
        }
        public void Accept(Visitor<T> visitor)
        {
            visitor.Visit(this);
        }
    }
}
