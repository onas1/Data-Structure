using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    //Declaring single list class 
    sealed class SingleLinkedList<T> : IEnumerable<Node<T>>
    {
        public Node<T> Head;
        public Node<T> Tail;
        private int count = 0;

        //Method to add to Linkedlist from tail
        public int AddToTail(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (this.Head == null)
            {
                newNode.Next = Head;
                this.Head = newNode;
                this.Tail = this.Head;
                ++count;
            }
            else
            {
                Node<T> prev = this.Tail;
                this.Tail.Next = newNode;
                this.Tail = newNode;
                ++count;
            }

            return count;
        }
        //Method to add to linkedlist from head
        public int AddToHead(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = this.Head;
            this.Head = newNode;
            ++count;
            return count;
        }
        //Method to peek through linkedlist
        public Node<T> Peek()
        {
            return this.Head;
        }
        //Method to remove any item from linkedlist
        public bool Remove(T item)
        {
            Node<T> temp = this.Head;
            Node<T> prev = null;
            if (temp != null && temp.Data.Equals(item))
            {
                this.Head = temp.Next;
                --this.count;
                return true;
            }
            while (temp != null && !temp.Data.Equals(item))
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                return false;
            }
            prev.Next = temp.Next;
            --this.count;
            return true;
        }
        //Method to remove from the top, i.e frist element
        public Node<T> RemoveFromTop()
        {
            Node<T> returnValue = this.Head;
            this.Head = this.Head.Next;
            count--;
            return returnValue;
        }
        //To check for specified item in linkedlist 
        public bool Check(T item)
        {
            Node<T> temp = this.Head;
            while (temp != null)
            {
                if (temp.Data.Equals(item)) return true;
                temp = temp.Next;
            }
            return false;
        }
        //Method to return index of any emelent in the singlelinkedlist 
        public int Index(T item)
        {
            int index = 0;
            Node<T> temp = this.Head;
            if (temp != null && temp.Data.Equals(item))
            {
                ++index;
                return 0;
            }
            while (temp != null && !temp.Data.Equals(item))
            {
                temp = temp.Next;
                ++index;
            }
            if (temp == null)
            {
                return -1;
            }
            return index;
        }
        //to find the size of the linkedlist
        public int Size()
        {
            return this.count;
        }
        public bool IsEmpty()
        {
            return count == 0 ? true : false;
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            return new NodeEnumerator<T>(this);
        }
        //Method to iterate through the linkedlist
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

       
    }
}









 







