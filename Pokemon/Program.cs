using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Attack waterthrower = new Attack("Waterthrower", ElementType.Water, 12);
            Attack waterbomb = new Attack("Waterbomb", ElementType.Water, 6);
            Attack watersword = new Attack("Watersword", ElementType.Water, 3);

            List<Pokemon> pokemons = new ()
            {
            new Squirtle([waterthrower, waterbomb]),
            };

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"Använder {pokemon.Name} som är typ {pokemon.Type} och level {pokemon.Level}.");

                pokemon.Attack();

                pokemon.RaiseLevel();

                if (pokemon is IEvolvable evolvablePokemon)
                {
                    evolvablePokemon.Evolve();
                }

                Console.WriteLine("\n");
            }


        }
    }
}
