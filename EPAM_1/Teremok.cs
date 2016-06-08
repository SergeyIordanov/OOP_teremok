using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_1
{
    class Teremok : List<Animal>
    {
        public Teremok(string location)
        {
            Console.WriteLine("Стоит в " + location + " " + GetType().ToString().Split('.')[1]);
        }

        public void Knock(Animal animal)
        {
            Console.WriteLine(animal.GetType().ToString().Split('.')[1] + " cтучит в теремок");
            animal.Ask();
            if (Count != 0)
            {
                Console.WriteLine("Ответ из " + GetType().ToString().Split('.')[1]
                    +  ": Иди к нам жить\nВошел " + animal.GetType().ToString().Split('.')[1] 
                    + " и стало их " + (Count + 1));
                Console.WriteLine("Тут: ");
                foreach (Animal an in this)
                {
                    Console.Write("\t");
                    an.Greet();
                }
            }
            else
            {
                Console.WriteLine("Никто не отозвался\n" + "Вошел " + animal.GetType().ToString().Split('.')[1] + " в теремок и стал там жить");
            }
            Add(animal);
            if(animal.GetType().ToString().Split('.')[1].Equals("Bear"))
            {
                colaps();
            }
        }

        private void colaps()
        {           
            Console.WriteLine(this[Count-1].GetType().ToString().Split('.')[1] + 
                " влез в " + GetType().ToString().Split('.')[1] + " и он развалился" );
            Clear();
        }

    }
}
