using System;

namespace StateDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(HighPriority.State);
            Person person2 = new Person(MediumPriority.State);
            Person person3 = new Person(LowPriority.State);
            person1.state.printState();
            person2.state.printState();
            person3.state.printState();
        }
    }
}