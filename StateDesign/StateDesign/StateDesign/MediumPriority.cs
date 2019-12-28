using System;

namespace StateDesign
{
    public class MediumPriority : State
    {
        public static readonly State State = new MediumPriority();

        private MediumPriority()
        {
        }

        public override void printState()
        {
            Console.WriteLine("you are medium priority");

        }
    }
}