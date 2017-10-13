namespace StrategyPattern
{
    public interface IUnit
    {
        int HitPoints { get; }

        UnitType Type { get; }
    }
}