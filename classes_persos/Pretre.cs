using System;

namespace DMCsharp
{
	class Pretre : ICharacter
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



        public Pretre(string name)
        {
            Attack = 75;
            Defense =125;
            Initiative = 50;
            Damages = 50;
            MaximumLife = 150;
            CurrentLife = 150;
            CurrentAttackNumber = 1;
            TotalAttackNumber = 1;
            this.name = name;
        }
    }
}