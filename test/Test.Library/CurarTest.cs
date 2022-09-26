using NUnit.Framework;

namespace RoleplayGame
{
    public class CureTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CurarTest1()
        {
            Knight knight1 = new Knight("knight1");
            Dwarf dwarf1 = new Dwarf("dwarf1");
            dwarf1.Axe = new Axe();
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();
            knight1.ReceiveAttack(dwarf1);
            knight1.Cure();
            Assert.AreEqual(knight1.Health, 100);

        }
    }
}