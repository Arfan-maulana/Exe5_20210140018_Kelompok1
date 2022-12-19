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
            public int MM;
            public Node next;


            public Node(int mm)
            {
               MM= mm;
            }
        }

        bool empty()
        {
            if(Arfan == null)
                return (true); else return (false);
        }
        Node Arfan;
        Node Maulana;

        public void insert(string mm)
        {
            var newNode == newNode(mm);
            if(Maulana != null)
            {
                Maulana.next = newNode;
            }
            Maulana = newNode;
            if (Maulana == null)
            {
                Maulana = newNode;
            }
        }

        public void delete()
        {



        }








        static void Main(string[] args)
        {

        }
    }
}
