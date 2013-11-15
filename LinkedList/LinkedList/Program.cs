using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C:\Users\ehstudent\Documents\Visual Studio 2012\Projects\LinkedList\LinkedList
//linked list with insert and remove functions and a driver that uses both.
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<string> stringlist = new LinkedList<string>("Hi", "Bye");
            LinkedList<string>.LinkedListNode head = stringlist.head;
            
            //Console.WriteLine("Hi");
            //Console.WriteLine("Bye");

        }
    }
    public class LinkedList<T>
    {
        public class LinkedListNode
        {
            public LinkedListNode next;
            public T value;

            public LinkedListNode(T value)
            {
                this.value = value;
            }

            internal void SetNext(LinkedListNode nextNode)
            {
                this.next = nextNode;
            }
        }

            public LinkedListNode head;

            public LinkedList(params T[] objects)
            {
                foreach(T o in objects)
                {
                    Insert(o);
                }
            }

            public void Insert(T value)
            {
                if (head == null)
                {
                    head = new LinkedListNode(value);
                    return;
                }
                LinkedListNode val = head;
                while(val.next != null)
                {
                    val = val.next;
                }
                val.SetNext(new LinkedListNode(value));
            }
            //public void Delete(T value)
            //{
            //    if (head.value.Equals(value))
            //    {
            //        head = head.next;
            //        return;
            //    }
            //    LinkedListNode currentNode = head.next;
            //    LinkedListNode prevNode = head;
            //    while(currentNode != null)
            //    {
            //        if (head.value.Equals(value))
            //        {
            //            prevNode = currentNode.next;
            //            currentNode = null;
            //            break;
            //        }
            //        else
            //        {
            //            prevNode = currentNode;
            //            currentNode = currentNode.next;
            //        }
            //    }            
            //}
     }    
}
