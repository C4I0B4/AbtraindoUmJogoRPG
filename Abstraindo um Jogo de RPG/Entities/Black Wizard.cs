using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_Jogo_de_RPG.Entities
{
    class Black_Wizard : Hero
    {
        public Black_Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Atacou com Magia Negra com Bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Atacou com Magia Negra Fraca com Bonus de " + Bonus;
            }
        }
    }
}
