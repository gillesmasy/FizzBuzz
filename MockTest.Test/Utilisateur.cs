using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compta
{
    public class Utilisateur
    {
        private IEnumerable<Compte> comptes;
        public IEnumerable<Compte> Comptes { get; set; }
    }
}
