using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using quaddxmas.DTOs;
using quaddxmas.Managers;

namespace quaddxmas.Tests
{
    [TestClass]
    public class PersonnageTest
    {
        [TestMethod]
        public void CreerPersonnageTest()
        {
            PersonnageManager personnageManager = new PersonnageManager();
            personnageManager.CreerNouveauPersonnage("test");

            Personnage personnage = personnageManager.GetPersonnage("test");

            Assert.AreEqual("test", personnage.Nom);
        }
    }
}
