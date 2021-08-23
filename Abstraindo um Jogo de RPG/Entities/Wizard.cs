using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_Jogo_de_RPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia Super Efetiva com bonus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }

            
        }
    }
}
