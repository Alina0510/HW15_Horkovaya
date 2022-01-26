using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Article
    {
        private string _name;
        private string _store;
        private uint _price;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public Article(string name, string store, uint price)
        {
            _name = name;
            _store = store;
            _price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {_name}\nStore: {_store}\nPrice: {_price}");
        }
    }
}
