using System;

namespace Lab_OOP_Collections_Generic
{
    class Product
    {
        public int code { get; set; }
        public string name { get; set; }
        public string producer { get; set; }
        public int price { get; set; }
        public int amount { get; set; }

        public Product(int code, string name, string producer, int price, int amount)
        {
            this.code = code;
            this.name = name;
            this.producer = producer;
            this.price = price;
            this.amount = amount;
        }

        override public string ToString()
        {
            return String.Format("{0,3} {1,10} {2,10} {3,5} {4,7}", code, name, producer, price, amount);
        }
    }
}
