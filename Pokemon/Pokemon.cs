using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pokemon
{
    internal abstract class Pokemon
    {
        private string _name;
        private int _level;
        private ElementType _type;
        private List<Attack> _attacks;


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ((value.Length > 1) && (value.Length < 16))
                    {
                    _name = value;
                    }
            }

        }

        public int Level
        {

            get
            {
                return _level;
            }
            set
            {
                if (value >= 1)
                {
                    _level = value;
                }
            }
        }

        public ElementType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public List<Attack> Attacks
        {
            get
            {
                return _attacks;
            }
            set
            {
                _attacks = value;

            }

        }

        public Pokemon(string name, ElementType type, List<Attack> attacks, int level = 1)
        {
            this.Name = name;
            this.Level = level;
            this.Type = type;
            this.Attacks = attacks;

        }


        public void RandomAttack()
        {
            Attack attack = Attacks[Random.Shared.Next(Attacks.Count)];
            attack.Use(this.Level);

        }

        public void Attack()
        {
            Console.WriteLine("Välj mellan följande attacker. Tryck på nummer och Enter.");
            for (int i = 1; i <= Attacks.Count; i++)
            {
                Console.WriteLine($"{i}. {Attacks[i - 1].Name}");

            }
            try
            {
                int chosenAttack = int.Parse(Console.ReadLine());
                Attack attack = Attacks[chosenAttack - 1];
                attack.Use(this.Level);

            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du har inte skrivit in rätt format");
                Console.ResetColor();
            }
            
        }

        public void RaiseLevel()
        {
            this.Level += 1;
            Console.WriteLine($"{this.Name} har levlat up. Level {this.Level} nu.");
        }

    }
}
