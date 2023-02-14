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
        public int DegatsSubis { get; set; }
        public int JetInitiativeCeRound { get; set; }
        public string name { get; set; }



        public Guerrier(string name)
        {
            Attack = 100;
            Defense =100;
            Initiative = 50;
            Damages = 100;
            MaximumLife = 200;
            CurrentLife = 200;
            CurrentAttackNumber = 2;
            TotalAttackNumber = 2;
            this.name = name;
        }

        public void DoAttack(ICharacter Player1, ICharacter Player2, int margeAttaque)
        {
            // Douleur
            // if(Player1.CurrentLife <= 0){

            // }
            System.Console.WriteLine("TEEEEEEESTT");
            Player2.CurrentLife -= margeAttaque * Player1.Attack / 100;
        }
    }
}