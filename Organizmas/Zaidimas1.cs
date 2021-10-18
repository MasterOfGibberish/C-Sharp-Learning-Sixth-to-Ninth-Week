using System;

namespace Organizmas
{
    public abstract class Zaidimas1 : Organism, IAttack
    {
    
        public int Sword { get; private set; }
        
       
        public void Ivedimas (int skaicius)
        {
            Console.WriteLine("Iveskite Priesu skaiciu:");
            int skacius = Convert.ToInt32(Console.ReadLine());
          
            Console.ReadLine();
        }
        public void Attack(Organism target)
        {
            while (lifePoint > 0)
            {
                int lifePoint = 1000;
                int bite = 20;
                int Sword = 30;
                int sum1 = lifePoint - bite;
                int sum = lifePoint - Sword;
                if (sum1 > sum)
                {
                    Console.WriteLine("Player laimejo");
                }
                if (sum1 < sum)
                {
                    Console.WriteLine("Monstras laimejo");
                }
            }        
            Console.ReadLine();
        }
        public void Attack()
        {

        }
        public int Confrontation(int sum) => sum = lifePoint - Sword;

    
    }
    
}