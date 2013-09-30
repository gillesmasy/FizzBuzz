using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compta
{
    public class Guichet
    {
        public object Depot(Compte compte, int montant)
        {
            compte.Add(montant);

            return compte.Solde();
        }
    }
}
