using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaket
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldSet w = new WorldSet("Albert");
            w.AddBot("Murlk", 25);
            w.AddInventionary("Knife", 32);
            w.AddInventionary("Zoom", 5);
            w.AddLocation("Mafioznik");
            w.AddNPC("Old knife ", 60);
            w.AddNPC("lamba", 77);

            Console.ReadKey();
        }
    }
}
