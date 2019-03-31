using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Decorator
{
    abstract class DrinkDecorator : IDrink
    {
        protected IDrink _drink;

        public DrinkDecorator(IDrink drink)
        {
            _drink = drink;
        }

        abstract public string GetName();

        abstract public double GetPrice();

        virtual public Size GetSize()
        {
            return _drink.GetSize();
        }
    }
}
