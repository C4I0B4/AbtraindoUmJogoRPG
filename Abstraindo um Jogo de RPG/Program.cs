using Abstraindo_um_Jogo_de_RPG.Entities;
using System;

namespace Abstraindo_um_Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            Black_Wizard black_Wizard = new Black_Wizard("Topapa", 42, "Black Wizard");

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(ninja.Attack(7));
            Console.WriteLine(black_Wizard.Attack(5));
           
        }
    }
}
