using System;

namespace StateDesign
{
    public class LowPriority : State
    {
        public static readonly State State = new LowPriority();

        private LowPriority()
        {
        }

        public override void printState()
        {
            Console.WriteLine("you are low priority");
        }
    }
}