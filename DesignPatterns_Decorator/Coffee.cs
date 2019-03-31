using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Decorator
{
    class Coffee : Drink
    {
        public Coffee(Size size)
            : base(size)
        {
            _name = "Coffee";
        }

        public override double GetPrice()
        {
            switch (_size)
            {
                case Size.small:
                    return 2.90;
                case Size.medium:
                    return 3.90;
                case Size.big:
                    return 4.90;
                default:
                    throw new Exception("Not implemented size");
            }
        }
    }
}
