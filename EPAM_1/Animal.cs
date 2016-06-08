using System;

namespace EPAM_1
{
    /// <summary>
    /// Base class for all fairy's characters
    /// </summary>
    abstract class Animal : IFairyObject
    {
        const string WHO = "- Теремок-теремок, кто в тереме живет?";

        public string Name {
            get { return GetType().ToString().Split('.')[1]; }
        }

        public void Greet()
        {
            Console.WriteLine("Я, " + Name);
        }

        public void Ask()
        {
            Console.WriteLine(Name + " спрашивает: \n\t" + WHO);
        }

        public void RunThrough()
        {
            Console.WriteLine("Бежит мимо " + Name);
        }
    }
}
