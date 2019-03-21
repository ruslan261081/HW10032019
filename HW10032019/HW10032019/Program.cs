using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10032019
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundTable<Magician> magicians = new RoundTable<Magician>();

            RoundTable<Knight> knights = new RoundTable<Knight>();

            magicians.Add(new Magician("Hoodiny", "budapest", "effects"));

            magicians.Add(new Magician("davidBlan", "brooklin", "effects"));

            magicians.Add(new Magician("kooperfield", "newyork", "megic"));

            knights.Add(new Knight("artur", "albion", "king"));

            knights.Add(new Knight("lenslot", "alboin", "ser"));

            knights.Add(new Knight("galahad", "albion", "ser"));

            magicians.InsertAt(6, new Magician("kooperfield", "newyork", "megic"));

            Console.WriteLine(magicians);

            magicians.RemoveAt(6);

            Console.WriteLine(magicians);

            Console.WriteLine("----------");

            Console.WriteLine(magicians[6]);
        }
    }
}
