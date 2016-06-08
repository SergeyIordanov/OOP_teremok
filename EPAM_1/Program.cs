using System;

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
            Hare hare = new Hare();
            teremok.Knock(hare);
            Bear bear = new Bear();
            teremok.Knock(bear);
            Console.WriteLine("Вот и сказочке конец, а кто слушал - программист.");
            Console.ReadLine();
        }
    }
}
