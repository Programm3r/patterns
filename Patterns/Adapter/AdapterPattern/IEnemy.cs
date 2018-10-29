namespace AdapterPattern
{
    public interface IEnemy
    {
        void DoDamage();
        void MoveForward();
        void InteractWith(string name);
    }
}