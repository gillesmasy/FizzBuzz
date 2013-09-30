using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Compta
{
    public class Compte
    {
        IConnection connect;

        public Compte(IConnection connect)
        {
            this.connect = connect;
        }

        public Utilisateur utilisateur;

        public virtual void Add(int montant)
        {
        }

        public object Solde()
        {
            connect.Connect();

            return 0;
        }
    }
}
