using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_OOP_Collections_Generic
{
    [Serializable]
    class Collection : IEnumerable
    {
        public List<Product> innerList;
        public Collection()
        {
            innerList = new List<Product>();
        }

        public void Add(Product arg)
        {
            innerList.Add(arg);
        }
        public void RemoveAt(int index)
        {
            if (innerList.Count <= index)
                throw new IndexOutOfRangeException("Error!");
            else
                innerList.RemoveAt(index);
        }
        public IEnumerator<Product> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
        internal void Sort()
        {
            CompareClasse Comp = new CompareClasse();
            innerList.Sort(Comp);
        }
    }
}
