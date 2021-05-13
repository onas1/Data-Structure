using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    //Declaring LinkedList class 
    class LinkedList<T>
    {
        private SingleLinkedList<T> List = new SingleLinkedList<T>();
        //Declaring Add to LinkedList Method 
        public int Add(T item)
        {
            this.List.AddToTail(item);
            return this.List.Size();
        }
        //Declaring Method to remove from LinkedList 
        public bool Remove(T item)
        {
            if (this.List.IsEmpty())
            {
                throw new InvalidOperationException("The List is empty");
            }
            return this.List.Remove(item);
        }
        //method to check for an item in linkedlist
        public bool Check(T item)
        {
            return this.List.Check(item);
        }
        //method to return and the index of an item 
        public int Index(T item)
        {
            return this.List.Index(item);
        }
    }
}

