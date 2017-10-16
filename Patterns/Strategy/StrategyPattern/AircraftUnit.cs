namespace StrategyPattern
{
    public class AircraftUnit : IUnit
    {
        public AircraftUnit()
        {
            HitPoints = 500;
            Attack = 1000;
            Type = UnitType.Aircraft;
        }

        public int HitPoints { get; }

        public int Attack { get; }

        public UnitType Type { get; }
    }
}