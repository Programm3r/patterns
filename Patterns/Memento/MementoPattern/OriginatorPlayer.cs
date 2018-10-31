using System;

namespace MementoPattern
{
    public class OriginatorPlayer
    {
        public int Level;
        public int Score;
        public string Health;
        public int lifeline = 3;

        public Memento CreateMarker(OriginatorPlayer player)
        {
            return new Memento(player.Level, player.Score, player.Health);
        }

        public void RestoreLevel(Memento playerMemento)
        {
            Level = playerMemento.Level;
            Score = playerMemento.Score;
            Health = playerMemento.Health;
            lifeline -= 1;
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine("Level: " + this.Level);
            Console.WriteLine("Score: " + this.Score);
            Console.WriteLine("Health: " + this.Health);
            Console.WriteLine("Lifeline left: " + this.lifeline);
        }
    }
}
