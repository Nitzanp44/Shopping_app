using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class SoppingList
    {
        private int lid;
        private List<Product> products;

        public int Lid { get => lid; set => lid = value; }
        public List<Product> Products { get => products; set => products = value; }
    }

 
}
