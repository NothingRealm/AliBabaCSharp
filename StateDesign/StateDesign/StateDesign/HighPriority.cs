using System;

namespace StateDesign
{
    public class HighPriority : State
    {
        public static readonly State State = new HighPriority();

        private HighPriority()
        {
        }

        public override void printState()
        {
            Console.WriteLine("you are high priority");
        }
    }
}