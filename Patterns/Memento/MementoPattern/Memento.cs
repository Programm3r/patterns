namespace MementoPattern
{
    public class Memento
    {
        public int Level;
        public int Score;
        public string Health;

        public Memento(int level, int score, string health)
        {
            Level = level;
            Score = score;
            Health = health;
        }
    }
}
