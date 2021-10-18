using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizmas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAttack> organism = new List<IAttack>();
            organism.Add(new Monster());
            organism.Add(new Monster());
            organism.Add(new Player());
            
            foreach (IAttack item in organism)
            {
                item.Attack();
            }
            Console.ReadKey();

        }
    }
    public interface IRead
    {
        string Read();
    }
    public interface IAttack
    {
        void Attack(Organism target);
        void Attack();
    }
    public class Monster : Organism, IAttack
    {
        public Monster()
        {
        
            Console.WriteLine("Kanda");
         
        }

        public Monster(int lifePoint, int damage) : base(lifePoint)
        {
            Damage = damage;
         
        }

        public int Damage { get; set; }

       public void Attack(Organism target)
        {
            
            Console.WriteLine($"KANDU {Damage}");
        }

        public void Attack(Player target)
        {
      
        }

        public void Attack()
        {
       
        }
    }
    public class Player : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Kertu is Kalavijo");
      
        }

        public void Attack(Player target)
        {
     
        }

        public void Attack(Organism target)
        {
       
        }
    }
    public abstract class Organism
    {
        public int lifePoint { get; set; }

        public Organism(int lifePoint)
        {
            var lifePoint1 = lifePoint;
        }

    }
}

