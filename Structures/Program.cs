using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Structures.LinkedList;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList.Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach(var item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

            list.InsertAfter(2, 6);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

            list.InsertAfter(6, 9);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
