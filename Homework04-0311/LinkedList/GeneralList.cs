using System;

namespace LinkedList
{
    class GeneralList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        private int count;
        public GeneralList()
        {
            head = tail = null; 
        }
        public Node<T> Head
        {
            get  =>  head;
        }
        public void add(T t)
        {
            Node<T> node = new Node<T>(t);
            if(tail == null)
            {
                head = tail=node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        public void Foreach(Action<T> action)
        {
            for(Node<T> node = head; node != null; node = node.Next)
            {
                action(node.Value);
            }
        }


    }
}