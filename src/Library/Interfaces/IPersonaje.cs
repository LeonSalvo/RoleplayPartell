using System;

namespace RoleplayGame
{
    public interface IPersonaje
    {
        public int Health{get;}
        public string AttackValue{get;set;}
        public string DefenseValue{get;set;}

    }
}