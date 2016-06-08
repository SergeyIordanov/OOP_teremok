using System;
using System.Collections.Generic;

namespace EPAM_1
{
    /// <summary>
    /// Represents the teremok using List functionality
    /// </summary>
    class Teremok : List<Animal>, IFairyObject
    {
        public string Name
        {
            get { return GetType().ToString().Split('.')[1]; }
        }
        
        /// <summary>
        /// Create a teremok
        /// </summary>
        /// <param name="location">Place where the teremok will be initialized</param>
        public Teremok(string location)
        {
            Console.WriteLine("Стоит в " + location + " " + Name);
        }

        /// <summary>
        /// Implements an attempt to enter to the teremok
        /// </summary>
        /// <param name="animal">Animal that knocks to the teremok</param>
        public void Knock(Animal animal)
        {
            Console.WriteLine(animal.Name + " cтучит в теремок");
            animal.Ask();
            if (Count != 0)
            {
                Console.WriteLine("Ответ из " + Name + ": \nТут: ");

                foreach (Animal an in this)
                {
                    Console.Write("\t");
                    an.Greet();
                }

                Console.WriteLine("Иди к нам жить");                             
            }
            else
            {
                Console.WriteLine("Никто не отозвался\n" + "Вошел " + animal.Name + " в теремок и стал там жить");
            }
            Add(animal);
            if(animal.Name.Equals("Bear"))
            {
                colaps();
                return;
            }
            Console.WriteLine("Вошел " + animal.Name
                    + " и стало их " + Count);
        }

        /// <summary>
        /// Destroys the teremok
        /// </summary>
        private void colaps()
        {           
            Console.WriteLine(this[Count-1].Name + 
                " влез в " + Name + " и он развалился" );
            Clear();
        }

    }
}
