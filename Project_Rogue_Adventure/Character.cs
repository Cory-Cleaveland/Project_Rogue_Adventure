using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Rogue_Adventure
{
    public class Character
    {
        public string name = string.Empty;
        public double health = 100.0;

        public void CharacterLoad()
        {

        }

        public void CharacterCreation()
        {
            Console.WriteLine("Please enter the name of your character: ");
            name = Console.ReadLine();
            health = 100.0;

        }

        public void Damage_To_Enemy(Enemy_Small enemy, double damage)
        {
            enemy.health -= damage;
        }

        public void Damage_To_Enemy(Enemy_Boss boss, double damage)
        {
            boss.health -= damage;
        }
    }
}
