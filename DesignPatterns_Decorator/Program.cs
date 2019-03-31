using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrink coffee1 = new Coffee(Size.medium);
            IDrink coffee2 = new Coffee(Size.small);
            IDrink tea = new Tea(Size.big);

            coffee1 = new Sugar(new Milk(coffee1));
            coffee2 = new Milk(coffee2);

            Console.WriteLine(coffee1.GetName() + " Price: " + coffee1.GetPrice());
            Console.WriteLine(coffee2.GetName() + " Price: " + coffee2.GetPrice());
            Console.WriteLine(tea.GetName() + " Price: " + tea.GetPrice());

            Console.ReadKey();
        }
    }
}
