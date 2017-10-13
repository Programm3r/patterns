namespace StrategyPattern
{
    public class TankUnit : IUnit
    {
        public TankUnit()
        {
            HitPoints = 1000;
            Attack = 500;
            Type = UnitType.Tank;
        }

        public int HitPoints { get; }

        public int Attack { get; }

        public UnitType Type { get; }
    }
}