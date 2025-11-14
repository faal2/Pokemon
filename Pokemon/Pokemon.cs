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


        
    }
}
