using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NSubstitute;
using NUnit.Framework;

namespace Compta.Test
{
    [TestFixture]
    class GuichetTest
    {
        private Guichet guichet;

        [SetUp]
        public void Init()
        {
            guichet = new Guichet();
        }

        [Test]
        public void GivingMontantWhenDepotThenGain()
        {
            var montant = 100;
            Compte cpt = Substitute.For<Compte>();
            cpt.Solde().Returns(200);

            var retour = guichet.Depot(cpt, montant);

            cpt.Received().Add(montant);

            Assert.AreEqual(200, retour);
        }
    }
}
