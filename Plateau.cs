using System;

namespace Echec_Mat
{
    public class Plateau
    {
        private Object[,] plateau = new Object[8, 8];
        
        public void Init()
        {
            SetuPion();
        }


        private void SetuPion()
        {
            for (int i = 0; i < 8; i++)
            {
                plateau[0,i] = new Pion();
                plateau[6,i] = new Pion();
            }
        }
    }
}