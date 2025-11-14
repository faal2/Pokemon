using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Squirtle : WaterPokemon, IEvolvable
    {


        public Squirtle(List<Attack> attacks) : base("Squirtle", attacks)
        {
        }

        public void Evolve()
        {
            Console.Write($"{this.Name} is evolving...");
            this.Name = "Wartortle";
            this.Level += 10;
            Console.Write($"Now it is a {this.Name} and its level is {this.Level}");
        }
}
}