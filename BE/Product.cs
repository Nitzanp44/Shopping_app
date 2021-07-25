using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZXing;



namespace BE
{
    public class Product
    {
        private int pid;
        private string name;
        private int price;
        private Enums.categories category;
        //
        string imagel;
        public int Pid { get => pid; set => pid = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public Enums.categories Category { get => category; set => category = value; }
    }
}



