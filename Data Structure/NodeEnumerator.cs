using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Data_Structure
{
    class NodeEnumerator<T> : IEnumerator<Node<T>>
    {
        SingleLinkedList<T> list;
        Node<T> Head;

        public NodeEnumerator(SingleLinkedList<T> _list)
        {
            this.list = _list;
            this.Head = null;
        }

        public Node<T> Current => this.Head;

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            Node<T> temp;
            if (this.Head == null)
            {
                this.Head = this.list.Head;
                if (this.Head != null)
                    return true;

                return false;
            }

            temp = this.Head;
            this.Head = temp.Next;
            if (temp.Next == null)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            this.Head = null;
        }
    }
}

