namespace StateDesign
{
    public class Person
    {
        public State state { get; set; }

        public Person(State state)
        {
            this.state = state;
        }
    }
}