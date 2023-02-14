using System;

namespace DMCsharp
{
	class Goule : ICharacter
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

    

        public Goule(string name)
        {
            Attack = 50;
            Defense =80;
            Initiative = 120;
            Damages = 30;
            MaximumLife = 250;
            CurrentLife = 250;
            CurrentAttackNumber = 5;
            TotalAttackNumber = 5;
            this.name = name;
        }
    }
}