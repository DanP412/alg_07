using System;
using System.Collections.Generic;

namespace alg_07
{
    class Stack<T>
    {

      
     
    
        private Node<T> _head;
        private Node<T> _head1;
        private Node<T> _head2;
        public void Push(T value)
        {
            Node<T> node = new Node<T>() { Value = value };
            node.Next = _head;
            _head = node;
            _head1 = node.Next;
            _head2 = node.Next.Next;
        }
        public void Reverse(T value)
        {
            Node<T> node = new Node<T>() { Value = value };
            node.Next = _head;
            node.Next.Next = _head1;
            node.Next.Next.Next = _head2;
            _head = _head2;
        }

        public T pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty!");
            }
            T result =_head.Value;
            _head = _head.Next;
            return result;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }
    }
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();


            Node<string> node = new Node<string> { Value = "adam" };
            node.Next = new Node<string>() { Value = "ewa" };
            node.Next.Next = new Node<string>() { Value = "Karol" };
            Node<string> head = node;
            while (node != null )
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(9);
            stack.Push(8);

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.pop());
            }
        }
    }
}
