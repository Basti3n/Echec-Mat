using System;
using Echec_Mat;

namespace Echec_Mat
{
    public class Roi: IPiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public string Couleur { get; set; }

        public void Move()
        {
            throw new System.NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("{0} ({1},{2}", Name, X, Y);

        }
    }
}