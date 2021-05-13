using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Data_Structure
{
    //Declaring class
    public class Stack<T> : IEnumerable<Node<T>>
        {
            private SingleLinkedList<T> list = new SingleLinkedList<T>();

            public void Push(T item)
            {
                this.list.AddToHead(item);
            }
        //Method to Pop an item from stack
            public Node<T> Pop()
            {
                if (list.Size() == 0)
                {
                    throw new InvalidOperationException("The stack is empty");
                }
                return this.list.RemoveFromTop();
            }
        //method to return the last time added to the stack  
            public Node<T> Peek()
            {
                if (this.list.IsEmpty())
                {
                    throw new InvalidOperationException("The stack is empty");
                }
                return this.list.Peek();
            }
        //show number of item present in stack
            public int Size()
            {
                return this.list.Size();
            }
        //Method to check if stack is empty
            public bool IsEmpty()
            {
                return this.list.IsEmpty();
            }

        //generic method to iterate through stack element in the stack
            public IEnumerator<Node<T>> GetEnumerator()
            {
                return list.GetEnumerator();
            }
        //non generic method to iterate through element in stack
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
    }
}



