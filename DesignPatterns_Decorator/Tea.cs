using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Decorator
{
    class Tea : Drink
    {
        public Tea(Size size)
            : base(size)
        {
            _name = "Tea";
        }

        public override double GetPrice()
        {
            switch (_size)
            {
                case Size.small:
                    return 1.90;
                case Size.medium:
                    return 2.90;
                case Size.big:
                    return 3.90;
                default:
                    throw new Exception("Not implemented size");
            }
        }
    }
}
