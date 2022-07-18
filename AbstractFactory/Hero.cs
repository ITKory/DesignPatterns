using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Hero
    {
        private Weapoon _weapoon;
        private Movement _movement;
        public int Helth { get; set; }

        public Hero( HeroFactory heroFactory, int helth)
        {
            _weapoon = heroFactory.CreateWeapoon();
            _movement = heroFactory.CreateMovement();
            Helth = helth;
        }
        public void Run()
        {
            _movement.Move();
        }
        public void ReciveDamage( int hit)
        {
            Helth -= hit;
        }

        public int Hit()
        {
         return _weapoon.Hit();
        }
    }
}
