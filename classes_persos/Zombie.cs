using System;

namespace DMCsharp
{
	class Zombie : ICharacter
	{
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Initiative { get; set; }
        public int Damages { get; set; }
        public int MaximumLife { get; set; }
        public int CurrentLife { get; set; }
        public int CurrentAttackNumber { get; set; }
        public int TotalAttackNumber { get; set; }

        public Zombie()
        {
            Attack = 100;
            Defense = 0;
            Initiative = 20;
            Damages = 60;
            MaximumLife = 1000;
            CurrentLife = 1000;
            CurrentAttackNumber = 1;
            TotalAttackNumber = 1;
        }
    }
}