using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Decorator
{
    class Sugar : DrinkDecorator
    {
        public Sugar(IDrink drink)
            :base(drink)
        {

        }

        public override string GetName()
        {
            return _drink.GetName() + " with sugar";
        }

        public override double GetPrice()
        {
            switch (_drink.GetSize())
            {
                case Size.small:
                    return _drink.GetPrice() + 0.10;
                case Size.medium:
                    return _drink.GetPrice() + 0.10;
                case Size.big:
                    return _drink.GetPrice() + 0.20;
                default:
                    throw new Exception("Not implemented size");
            }
        }
    }
}
