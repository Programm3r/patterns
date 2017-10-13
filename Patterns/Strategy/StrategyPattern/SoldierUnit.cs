namespace StrategyPattern
{
    public class SoldierUnit : IUnit
    {
        public SoldierUnit()
        {
            HitPoints = 50;
            Type = UnitType.Soldier;
        }

        public int HitPoints { get; }

        public UnitType Type { get; }
    }
}