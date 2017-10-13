namespace StrategyPattern
{
    public class AircraftUnit : IUnit
    {
        public AircraftUnit()
        {
            HitPoints = 500;
            Type = UnitType.Aircraft;
        }

        public int HitPoints { get; }

        public UnitType Type { get; }
    }
}