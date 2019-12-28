using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    public class Dolar : Observable<int>
    {
        public Dolar(int price)
        {
            this.value = price;
            observers = new List<Observer<int>>();
        }

        public void generate_price()
        {
            while (true)
            {
                var rand = new Random();
                value = rand.Next(8000, 12000);
                notify();
                Thread.Sleep(1000);
            }
        }
    }
}