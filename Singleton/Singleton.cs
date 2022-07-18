using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton? _instance;
        public int Counter { get; private set; }

        protected Singleton(int counter)
        {
            Counter = counter;
        }

        public static Singleton GetInstance( int value)
        {
            if (_instance == null)
                _instance = new Singleton(value);
            return _instance;
        }

        public void Increment() => Counter++;
        public void Decrement() => Counter--;
    }
}
