using System;
namespace DMCsharp
{
	public interface ICharacter
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



        public virtual void DoAttack(ICharacter Player1, ICharacter Player2, int margeAttaque)
        {
            Player2.CurrentLife -= margeAttaque * Player1.Attack / 100;

        }

        public virtual void DoCounterAttack(ICharacter Player1, ICharacter Player2, int margeAttaque)
        {
            Player2.CurrentLife -= margeAttaque * Player1.Attack / 100 + Math.Abs(margeAttaque);

        }
    }
}

