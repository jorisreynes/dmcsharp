using System;

namespace DMCsharp
{
	class Vampire : ICharacter
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



        public Vampire(string name)
        {
            Attack = 100;
            Defense =100;
            Initiative = 120;
            Damages = 50;
            MaximumLife = 300;
            CurrentLife = 300;
            CurrentAttackNumber = 2;
            TotalAttackNumber = 2;
            this.name = name;
        }
    }
}