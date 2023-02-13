using System;

namespace DMCsharp
{
	class Guerrier : ICharacter
	{
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Initiative { get; set; }
        public int Damages { get; set; }
        public int MaximumLife { get; set; }
        public int CurrentLife { get; set; }
        public int CurrentAttackNumber { get; set; }
        public int TotalAttackNumber { get; set; }

        public Guerrier()
        {
            Attack = 100;
            Defense =100;
            Initiative = 50;
            Damages = 100;
            MaximumLife = 200;
            CurrentLife = 200;
            CurrentAttackNumber = 2;
            TotalAttackNumber = 2;
        }
    }
}