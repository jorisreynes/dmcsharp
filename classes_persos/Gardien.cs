using System;

namespace DMCsharp
{
	class Gardien : ICharacter
	{
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Initiative { get; set; }
        public int Damages { get; set; }
        public int MaximumLife { get; set; }
        public int CurrentLife { get; set; }
        public int CurrentAttackNumber { get; set; }
        public int TotalAttackNumber { get; set; }

        public Gardien()
        {
            Attack = 50;
            Defense =150;
            Initiative = 50;
            Damages = 50;
            MaximumLife = 150;
            CurrentLife = 150;
            CurrentAttackNumber = 3;
            TotalAttackNumber = 3;
        }
    }
}