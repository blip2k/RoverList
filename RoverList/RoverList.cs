using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here
        public int counter;


        public RoverList()
        {
            counter = 0;
        }

        public int toCounter()
        {
            current = head;
            if (head == null)
            {
                counter = 0;
            }
            while (current != null)
            {
                counter++;
                current = current.Next;
            }
            return counter;
        }
        public override int Counter
        {
            get
            {
                return counter;
            }
        }
        public override void Add(T data)
        {
            Node newNode = new Node(data);
            Node current = head;
            if (head == null)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                while (current != null)
                {
                    if (current.Next == null)
                    {
                        current.Next = newNode;
                        break;
                    }
                    current = current.Next;
                }
            }
        }

        public override void Add(int Position, T data)
        {
            int pos = 0;
            Node current = head;
            Node newNode = new Node(data);
            if (Position == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                while (current != null)
                {
                    if (pos == Position)
                    {
                        current.Next = newNode;
                        break;
                    }
                    current = current.Next;
                    pos++;
                }
            }
        }

        public override void Clear()
        {
            head = null;
            count = 0;
        }

        public override T ElementAt(int Position)
        {
            Node current = head;
            int pos = 0;
            while (current != null)
            {
                if (pos == Position)
                {
                    return current.Data;
                }
                current = current.Next;
                pos++;
            }
            return default(T);
        }

        public override void ListNodes()
        {
            Node current = head;
            while (current != null)
            {

                Console.WriteLine(current.Data + " ,");
                current = current.Next;

            }
        }

        public override bool RemoveAt(int Position)
        {
            Node current = head;
            bool removed = false;
            int pos = 0;
            if (Position == 0)
            {
                head = head.Next;
                removed = true;
            }
            else
            {
                while (current != null)
                {
                    if (pos == Position)
                    {
                        current.Next = current.Next.Next;
                        removed = true;
                        break;
                    }
                    current = current.Next;
                    pos++;
                }
            }
            return removed;
        }
    }
}