using System;

namespace Lab_OOP_Collections_Generic
{
    class UI
    {
        public static void collectionWork()
        {
            Collection collection = new Collection();

            Console.WriteLine("Add element from the collection;");
            collection.Add(new Product(8, "Chocolate", "Roshen", 20, 2000));
            collection.Add(new Product(1, "Noodles", "FineFood", 25, 3100));
            collection.Add(new Product(10, "Sausages", "Yatran", 50, 1000));
            collection.Add(new Product(5, "Cheese", "Como", 50, 84000));
            collection.Add(new Product(3, "Wine", "Shabo", 80, 500));

            Console.WriteLine("\nOutput unsorted elements:");
            foreach (Product serial_unsort in collection)
            {
                Console.WriteLine(serial_unsort);
            }

            CompareClasse Compare = new CompareClasse();
            collection.Sort();
            Console.WriteLine("\nOutput sorted elements:");
            foreach (Product serial_sorted in collection)
            {
                Console.WriteLine(serial_sorted);
            }
            Console.WriteLine("\nRemove element index 4");
            try
            {
                collection.RemoveAt(4);
            }
            catch
            {
                Console.WriteLine("Error!Invalid index. The collection has not changed:");
            }
            foreach (Product serial_sorted in collection)
            {
                Console.WriteLine(serial_sorted);
            }
            Console.WriteLine("\nRemove element index 5");
            try
            {
                collection.RemoveAt(5);
            }
            catch
            {
                Console.WriteLine("Error!Invalid index. The collection has not changed:");
            }
            foreach (Product serial_sorted in collection)
            {
                Console.WriteLine(serial_sorted);
            }
        }


        public static void dequeWork()
        {
            Deque<Product> usersDeque = new Deque<Product>();
            Console.WriteLine("Add element from the deque;");
            usersDeque.AddFirst(new Product(8, "Chocolate", "Roshen", 20, 2000));
            usersDeque.AddLast(new Product(1, "Noodles", "FineFood", 25, 3100));
            foreach (Product s in usersDeque)
                Console.WriteLine(s);


            Product temp = usersDeque.AddLast(new Product(10, "Sausages", "Yatran", 50, 1000));
            Console.WriteLine("\nAdd last element from the deque:" +temp);

            temp = usersDeque.AddFirst(new Product(5, "Cheese", "Como", 50, 84000));
            Console.WriteLine("\nAdd first element from the deque:" + temp);

            Console.WriteLine("\nPrint all element");
            foreach (Product s in usersDeque)
                Console.WriteLine(s);


            
            temp = usersDeque.RemoveFirst();
            Console.WriteLine("\nRemove first element from the deque:\n"+temp);

            Console.WriteLine("\nPrint all element");
            foreach (Product s in usersDeque)
                Console.WriteLine(s);

            temp = usersDeque.RemoveLast();
            Console.WriteLine("\nRemove last element from the deque:\n" + temp);

            Console.WriteLine("\nPrint all element");
            foreach (Product s in usersDeque)
                Console.WriteLine(s);

            Product contains = new Product(8, "Chocolate", "Roshen", 20, 2000);
            Console.WriteLine("\nIt contais a deque:" + contains+"  ?");
            Console.WriteLine("Answer:"+usersDeque.Contains(contains));
            Console.WriteLine("It contains a deque:" + temp+"  ?");
            Console.WriteLine("Answer:" + usersDeque.Contains(temp));
        }


    }
}
