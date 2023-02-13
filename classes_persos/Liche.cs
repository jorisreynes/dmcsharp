using System;

namespace DMCsharp
{
	class Liche : ICharacter
	{
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Initiative { get; set; }
        public int Damages { get; set; }
        public int MaximumLife { get; set; }
        public int CurrentLife { get; set; }
        public int CurrentAttackNumber { get; set; }
        public int TotalAttackNumber { get; set; }

        public Liche()
        {
            Attack = 75;
            Defense =125;
            Initiative = 80;
            Damages = 50;
            MaximumLife = 125;
            CurrentLife = 125;
            CurrentAttackNumber = 3;
            TotalAttackNumber = 3;
        }
    }
}