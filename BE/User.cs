using System;
using System.Collections.Generic;
using System.Text;


namespace BE
{
    public class User
    {
        private int uid;
        private string name;
        private List<SoppingList> soppingLists;

        public int Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public List<SoppingList> SoppingLists { get => soppingLists; set => soppingLists = value; }
    }
}
