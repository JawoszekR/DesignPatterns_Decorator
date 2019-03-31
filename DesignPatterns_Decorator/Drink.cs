using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Decorator
{
    abstract class Drink : IDrink
    {
        protected Size _size;
        protected string _name;

        public Drink(Size size)
        {
            _size = size;
        }

        public Size GetSize()
        {
            return _size;
        }

        public string GetName()
        {
            return _size.ToString() + " " + _name;
        }

        public abstract double GetPrice();
    }
}
