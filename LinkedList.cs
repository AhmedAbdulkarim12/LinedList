using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList_Project
{
    public class LinkedList<T>
    {
        private Node<T> head;

        public void AddFirst(T _data)
        {
            Node<T> newNode = new Node<T>();

            newNode.data = _data;
            newNode.next = head;

            head = newNode;
        }


        public void AddLast(T _data)
        {
            if (head == null)
            {
                head = new Node<T>();

                head.data = _data;
                head.next = null;
            }
            else
            {
                Node<T> newNode = new Node<T>();
                newNode.data = _data;

                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }

        public void AddINIndex(int IndexNum, T _data)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = _data;

            if (IndexNum == 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }

            int currentIndex = 1;
            Node<T> prev = head;
            Node<T> current = head.next;

            while (current != null)
            {
                if (currentIndex == IndexNum)
                {
                    newNode.next = current;
                    prev.next = newNode;
                    current = newNode;
                    return ;
                }
                prev = current;
                current = current.next;

                currentIndex++;
            }

        }

        public void Reverse()
        {
            Node<T> prev = null;
            Node<T> current = head;

            if (current == null)
                return;

            while (current != null)
            {
                Node<T> next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            head = prev;
        }

        public void Remove(int IndexNum)
        {
            if (head == null)
                return ;

            if (IndexNum == 0)
            {
                head = head.next;
            }

            int count = 0;
            var current = head;
            while (current != null)
            {
                count++;
                if (count == IndexNum)
                {
                    current.next = current.next.next;
                    return ;
                }
                current = current.next;
            }

        }

        public void PrintAll()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.data );
                current = current.next;
            }
            
        }

       public void PrintedReverse()
        {
            Reverse();
            PrintAll();
            Reverse();
        }

        public int Size()
        {
            int count = 0 ;
            Node<T> current = head;
            while (current != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }

        public Node<T> getNode(int IndexNum)
        {
            int currentIndex = 0;
            Node<T> current = head;
            while (current != null)
            {
                if(currentIndex == IndexNum)
                {  return current; }
                current = current.next;
                currentIndex++;
            }
            return null;
        }

       
        public int FindFirstIndex(T _data)
        {
            int currentIndex = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (current.data.Equals(_data))
                { return currentIndex; }
                current = current.next;
                currentIndex++;
            }
            return -1;
        }


        public bool IsNull()
        {
            return head == null ? true : false;
        }

        public void EmptyList()
        {
            head = null;
        }

    }



    public class Node<T>
    {
        public T data;
        public Node<T> next;
    }
}
