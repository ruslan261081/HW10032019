using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10032019
{
    class Knight : INameable, IComparable<Knight>
    {
        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthtown, string title)
        {
            Name = name;
            Birthtown = birthtown;
            Title = title;
        }

        public string this [string fieldName]
        {
            get
            {
                switch(fieldName)
                {
                    case "Name":
                        return this.Name;
                    case "BirthTown":
                        return this.Birthtown;
                    case "Title":
                        return this.Title;
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
                    case "Title":
                        this.Title = value;
                        break;
                }
                
            }
        }

        public override string ToString()
        {
            return $"Knigth Name: {Name} BirthTown: {Birthtown} Title: {Title}";
        }

       int IComparable<Knight>.CompareTo(Knight other)
       {
            return this.Name.CompareTo(other.Name);
       }
    }
}
