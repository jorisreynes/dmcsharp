using System;

namespace DMCsharp
{
	class Kamikaze : ICharacter
	{
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Initiative { get; set; }
        public int Damages { get; set; }
        public int MaximumLife { get; set; }
        public int CurrentLife { get; set; }
        public int CurrentAttackNumber { get; set; }
        public int TotalAttackNumber { get; set; }
        public int JetInitiativeCeRound { get; set; }
        public string name { get; set; }



        public Kamikaze(string name)
        {
            Attack = 50;
            Defense =125;
            Initiative = 20;
            Damages = 75;
            MaximumLife = 500;
            CurrentLife = 500;
            CurrentAttackNumber = 6;
            TotalAttackNumber = 6;
            this.name = name;
        }
    }
}