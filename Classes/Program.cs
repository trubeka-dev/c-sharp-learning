using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program cashier = new Program();
            CoffeeMachine machine = new CoffeeMachine();
            int coffePrice = machine.GetPrice("Латте");
            Console.WriteLine("Цена кофе - " + coffePrice);
            machine.MakeCoffee("Латте");

            cashier.PrintGoodbye();
        }
        void PrintGoodbye()
        {
            Console.WriteLine("Досвидания!");
        }
    }

    class CoffeeMachine
    {
        public void MakeCoffee(string coffeType)
        {
            Console.WriteLine($"Готовим ваш {coffeType}.");
        }
        public int GetPrice(string coffeType)
        {
            int price;
            if (coffeType == "Эспрессо")
            {
                price = 150;
            }
            else if (coffeType == "Латте")
            {
                price = 200;
            }
            else
            {
                price = 0;
            }
            return price;
        }
    }
}