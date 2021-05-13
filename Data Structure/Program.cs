using System;


namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
           SingleLinkedList<int> newlist = new SingleLinkedList<int>();
           newlist.AddToHead(3);
           newlist.AddToHead(4);
           newlist.AddToHead(5);

            foreach(Node<int> i in newlist)
            {
                Console.WriteLine(i.Data);
            }

            Console.WriteLine("for stack");          
           Stack<int> newstack = new Stack<int>();
           newstack.Push(1);
            newstack.Push(4);
            newstack.Push(7);
            newstack.Push(10);
            foreach(Node<int> i in newstack)
            {
                Console.WriteLine(i.Data);

            }




        }
    }
}
