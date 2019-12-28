using System;

namespace Observer
{
    public class Label : Observer<int>
    {
        private int _price;
        public int id { get; set; }

        public Label(int id, int price)
        {
            this.id = id;
            _price = price;
        }

        public void update(int price)
        {
            _price = price;
            Console.WriteLine("{0} got price {1}" , id, price);
        }
    }
}