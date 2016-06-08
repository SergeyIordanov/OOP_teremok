using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teremok teremok = new Teremok("поле");
            Mouse mouse = new Mouse();
            teremok.Knock(mouse);
            Frog frog = new Frog();
            teremok.Knock(frog);
            Bear bear = new Bear();
            teremok.Knock(bear);
            Console.WriteLine("Вот и сказочке конец, а кто слушал - программист.");
            Console.ReadLine();
        }
    }
}
