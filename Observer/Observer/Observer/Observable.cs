using System.Collections.Generic;

namespace Observer
{
    public abstract class Observable <T>
    {
        public List<Observer<T>> observers { get; set; }
        public T value { get; set; }

        public void notify()
        {
            foreach (var observer in observers)
            {
                observer.update(value);
            }
        }

        public void attach(Observer<T> observer)
        {
            observers.Add(observer);
        }

        public void detach(Observer<T> observer)
        {
            observers.Remove(observer);
        }
    }
}