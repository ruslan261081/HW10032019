using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10032019
{
    class Magician : INameable, IComparable<Magician>
    {
        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public Magician(string name, string birthtown, string favoriteSpell)
        {
            Name = name;
            Birthtown = birthtown;
            FavoriteSpell = favoriteSpell;
        }

        public string this[string fieldName]
        {
            get
            {
                switch (fieldName)
                {
                    case "Name":
                        return this.Name;
                    case "BirthTown":
                        return this.Birthtown;
                    case "FavoriteSpell":
                        return this.FavoriteSpell;
                }
                return null;
            }
            set
            {
                switch (fieldName)
                {
                    case "Name":
                        this.Name = value;
                        break;
                    case "BirthTown":
                        this.Birthtown = value;
                        break;
                    case "FavoriteSpell":
                        this.FavoriteSpell = value;
                        break;
                }

            }
        }


        public override string ToString()
        {
            return $"Magician Name: {Name} BirthTown: {Birthtown} FavoriteSpell {FavoriteSpell}";
        }

        int IComparable<Magician>.CompareTo(Magician other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
