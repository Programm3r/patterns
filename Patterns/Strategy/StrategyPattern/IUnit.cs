namespace StrategyPattern
{
    public interface IUnit
    {
        int HitPoints { get; }

        int Attack { get; }

        UnitType Type { get; }
    }
}