using System;

namespace DMCsharp
{
	class Berserker : ICharacter
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


        

        public Berserker(string name)
        {
            Attack = 100;
            Defense =100;
            Initiative = 80;
            Damages = 20;
            MaximumLife = 300;
            CurrentLife = 300;
            CurrentAttackNumber = 1;
            TotalAttackNumber = 1;
            this.name = name;
        }
          public void DoAttack(ICharacter Player1, ICharacter Player2, int margeAttaque)
        {
            Player2.CurrentLife -= margeAttaque * Player1.Attack / 100;

        }
         public void DoCounterAttack(ICharacter Player1, ICharacter Player2, int margeAttaque)
        {
            Player2.CurrentLife -= margeAttaque * Player1.Attack / 100 + Math.Abs(margeAttaque);

        }
    }
}