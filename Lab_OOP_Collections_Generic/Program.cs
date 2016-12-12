using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_OOP_Collections_Generic.UI;

namespace Lab_OOP_Collections_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Work my collection:");
            collectionWork();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Work deque");
            dequeWork();
            Console.ReadKey();
        }
    }
}
