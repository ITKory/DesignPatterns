using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserver : IObserver
    {
        public int CurrentValue { get; protected set; }
        public string ObserverName { get; } = Guid.NewGuid().ToString(); 
        public void Update(int value) =>  CurrentValue = value;

    }
}
