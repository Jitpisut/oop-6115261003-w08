using System;

namespace oop_6115261003_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor a1 = new Actor("Chantavit", "Dhanasevi", "Ter", "36");
            Actor a2 = new Actor("Urassaya", "Sperbund", "Yaya", "27");
            Movies m1 = new Movies("Fanday", "Romance - Drama", "Banjong Pisanthanakun", a1);
            Movies m2 = new Movies("Brother of the Year", "Romance - Comedy - Drama", "Witthaya Thongyooyong", a2);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }
    }
}
