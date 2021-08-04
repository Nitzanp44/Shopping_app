using System;
using System.Collections.Generic;
using System.Text;

namespace BEEE
{
    public class Product
    {
        private int pid;
        private string name;
        private Double price;
        private Enums.categories category;
        //
        string imagel;
        public int Pid { get => pid; set => pid = value; }
        public string Name { get => name; set => name = value; }
        public Double Price { get => price; set => price = value; }
        public Enums.categories Category { get => category; set => category = value; }
    }
}
