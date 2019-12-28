using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(10000);
            Label label1 = new Label(1, dolar.value);
            Label label2 = new Label(2, dolar.value);
            Label label3 = new Label(3, dolar.value);
            dolar.attach(label1);
            dolar.attach(label2);
            dolar.attach(label3);
            dolar.generate_price();
        }
    }
}