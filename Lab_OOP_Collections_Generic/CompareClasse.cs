using System.Collections;
using System.Collections.Generic;

namespace Lab_OOP_Collections_Generic
{
    class CompareClasse : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return ((new CaseInsensitiveComparer()).Compare(x.code, y.code));
        }
    }
}