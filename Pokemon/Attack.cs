using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Attack
    {
        private string _name;
        private ElementType _type;
        private int _basePower;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
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

        public int BasePower
        {
            get
            {
                return _basePower;
            }
            set
            {
                _basePower = value;
            }

        }

        public Attack(string name, ElementType type, int basePower)
        {
            this.Name = name;
            this.Type = type;
            this.BasePower = basePower;
        }

        public void Use (int level)
        {
            Console.WriteLine($"{this.Name} hit with a total power of {level + this.BasePower}");
        }
    }
}
