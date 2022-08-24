using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    public class LinkedList
    {
        public Node head;
        public Node last;

        public void Enqueue(int value)
        {
            if (head == null)
            {
                Node newItem = new Node();
                newItem.value = value;
                newItem.next = newItem;

                head = newItem;
                last = newItem;
            }
            else
            {
                Node newItem = new Node();
                newItem.value = value;

                Node node = head;
                while(node.next != head)
                {
                    node = node.next;
                }

                node.next = newItem;
                newItem.next = head;

                last = newItem;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                if (last == head)
                {
                    Console.WriteLine(head.value);
                    head = null;
                }
                else
                {
                    Console.WriteLine(head.value);
                    Node temp = head.next;
                    head = null;
                    head = temp;
                    last.next = temp;
                }
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Console.WriteLine(head.value);
                Node node = head;
                while(node.next != head)
                {
                    node = node.next;
                    Console.WriteLine(node.value);
                }
            }
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
