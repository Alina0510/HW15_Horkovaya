using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Store
    {
        private Article[] articles;
        public Article this[int index]
        {
            get { return articles[index]; }
            set { articles[index] = value; }
        }
        public Store(int count)
        {
            articles = new Article[count];
        }
        public void ShowByNumber(int number)
        {
            articles[number].ShowInfo();
        }
        public void ShowByName(string name)
        {
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i] != null && articles[i].Name == name)
                {
                    articles[i].ShowInfo();
                    return;
                }
            }
            Console.WriteLine("There are no products with this name.");
        }
    }
}
