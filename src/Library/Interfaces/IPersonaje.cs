using System;

namespace RoleplayGame
{
    public interface IPersonaje : IAttack, IDefense
    {
        public int Health{get;}
        public void Cure();
        public void ReceiveAttack(IPersonaje atacante);

    }
}