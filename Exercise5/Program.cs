using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Queue_Linked_List
    {

        class Node
        {
            public string MM;
            public Node next;


            public Node(string mm)
            {
                MM = mm;
            }
        }

        bool empty()
        {
            if (Arfan == null)
                return (true); else return (false);
        }
        Node Arfan;
        Node Maulana;

        public void insert(string mm)
        {
            var newNode = new Node(mm);
            if (Maulana != null)
            {
                Maulana.next = newNode;
            }
            Maulana = newNode;
            if (Arfan == null)
            {
                Arfan = newNode;
            }
        }

        public void delete()
        {
            if (Arfan == null)
            {
                throw new InvalidProgramException("The queue is empty");
            }
            var mm = Arfan.MM;
            Arfan = Arfan.next;
            if (Arfan == null)
            {
                Arfan = null;
            }
        }


        public void Display()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = Arfan; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.MM);
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Queue_Linked_List q = new Queue_Linked_List();
                while (true)
                {
                    Console.WriteLine("\nStack Menu");
                    Console.WriteLine("1. Insert");
                    Console.WriteLine("2. Deleted");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("Exit");
                    Console.WriteLine("\nEnter Your Choice");
                    string input =(Console.ReadLine());
                    char ch = Convert.ToChar(input == "" ? "0" : input);
                    switch (ch)
                    {
                        case '1':
                            Console.WriteLine("\nEnter your alfabeth: ");
                            string num = Convert.ToString(Console.ReadLine());
                            q.insert(num);
                            break;
                        case '2':
                            q.delete();
                            Console.WriteLine("item deleted");
                            break;
                        case '3':
                            q.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("\nInvalid Choice");
                            break ;
                    }
                }
                
            }
        }
    }
}
