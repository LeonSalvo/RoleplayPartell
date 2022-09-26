using NUnit.Framework;

namespace RoleplayGame
{
    public class AttackTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackTest1()
        {
            Dwarf prueba1 = new Dwarf("prueba1");
            Wizard prueba2 = new Wizard("prueba2");
            prueba1.Axe = new Axe();
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            prueba2.Staff = new Staff();
            prueba2.SpellsBook = book;
            prueba2.ReceiveAttack(prueba1);
            Assert.AreEqual(prueba2.Health, 100);
        }
        [Test]
        public void AttackTest2()
        {
            Dwarf prueba1 = new Dwarf("prueba1");
            Archer prueba2 = new Archer("prueba2");
            prueba1.Axe = new Axe();
            prueba2.Helmet = new Helmet();
            prueba2.ReceiveAttack(prueba1);
            Assert.AreEqual(prueba2.Health, 93);
        } 

    }
}