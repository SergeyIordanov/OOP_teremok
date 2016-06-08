using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_1
{
    abstract class Animal
    {
        const string WHO = "- Теремок-теремок, кто в тереме живет?";
        public void Greet()
        {
            Console.WriteLine("Я, " + GetType().ToString().Split('.')[1]);
        }

        public void Ask()
        {
            Console.WriteLine(GetType().ToString().Split('.')[1] + " спрашивает: \n\t" + WHO);
        }

        public void RunThrough()
        {
            Console.WriteLine("Бежит мимо " + GetType().ToString().Split('.')[1]);
        }
    }
}
