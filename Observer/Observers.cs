using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observers
    {
        private List<IObserver> _observers;

        public Observers()
        {
            _observers = new();
        }
        public void AddObserver(IObserver observer) => _observers.Add(observer);
        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        public void UpdateObserverValue(int value)
        {
            foreach (IObserver observer in _observers)
                observer.Update(value);
        }
    

    }
}
