using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Fizzbuzz.Test
{
    [Binding]
    public class FizzBuzzFeatureSteps
    {
        FizzBuzzMultiple fizzBuzz = new FizzBuzzMultiple();
        string retour;
        string actual;

        [Given(@"J'ai une chaîne de caractères de (.*) à (.*), séparée par un espace")]
        public void GivenJAiUneChaineDeCaracteresDeASepareeParUnEspace(int p0, int p1)
        {
            retour = String.Empty;
            for (int i = p0; i <= p1; i++)
            {
                retour += i + " ";
            }

            retour = retour.Substring(0, (retour.Length - 1));
        }
        
        [When(@"je transforme la chaîne")]
        public void WhenJeTransformeLaChaine()
        {
            actual = String.Empty;

            var banana = retour.Split(' ');
            foreach (var s in banana)
            {
                actual += fizzBuzz.Transform(s) + " ";
            }

            actual = actual.Substring(0, (actual.Length - 1));
        }
        
        [Then(@"j'obtiens une chaine de caractères (.*)")]
        public void ThenJObtiensUneChaineDeCaracteresFizzBuzzFizzFizzBuzz(string p0)
        {
            Assert.AreEqual(p0, actual);
        }
    }
}
