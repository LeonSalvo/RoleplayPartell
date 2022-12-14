namespace RoleplayGame
{
    public class Dwarf : IPersonaje
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Axe Axe { get; set; }

        public Shield Shield { get; set; }

        public Helmet Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                return Axe.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Shield.DefenseValue + Helmet.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(IPersonaje atacante)
        {
            if (this.DefenseValue < atacante.AttackValue)
            {
                this.Health -= atacante.AttackValue - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}