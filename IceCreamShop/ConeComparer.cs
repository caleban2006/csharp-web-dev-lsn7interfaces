using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            Cone cone1 = (Cone)x;
            Cone cone2 = (Cone)y;

            if (cone1.Cost > cone2.Cost)
                return 1;

            if (cone1.Cost < cone2.Cost)
                return -1;

            else
                return 0;
        }
    }
}
