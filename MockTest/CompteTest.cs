using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace Compta.Test
{
    [TestFixture]
    class CompteTest
    {
        private Compte compte;
        private IConnection c;

        [SetUp]
        public void Init()
        {
            c = Substitute.For<IConnection>();
            compte = new Compte(c);
        }

        [Test]
        public void SoldeTest() 
        {
            compte.Solde();

            c.Received().Connect();
        }
    }
}
