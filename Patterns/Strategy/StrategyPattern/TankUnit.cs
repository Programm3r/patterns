namespace StrategyPattern
{
    public class TankUnit : IUnit
    {
        public TankUnit()
        {
            HitPoints = 1000;
            Type = UnitType.Tank;
        }

        public int HitPoints { get; }

        public UnitType Type { get; }
    }
}