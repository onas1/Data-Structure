using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    //Declaring class for Generic Queue
    class Queue<T> : IEnumerable<Node<T>>
    {
        private SingleLinkedList<T> List = new SingleLinkedList<T>();
        //Declaring method to check if Queue is empty 
        public bool IsEmpty()
        {
            return this.List.IsEmpty();
        }
        //Method to enqueue
        public void Enqueue(T item)
        {
            this.List.AddToTail(item);
        }
        //Method to Dequeue
        public Node<T> Dequeue()
        {
            if (this.List.IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty");
            }
            return this.List.RemoveFromTop();
        }
        //method to return the size of Queue
        public int Size()
        {
            return this.List.Size();
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            return this.List.GetEnumerator();
        }
        //Method to iterate through Queue
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

