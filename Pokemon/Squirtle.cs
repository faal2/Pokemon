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

        }
}
}