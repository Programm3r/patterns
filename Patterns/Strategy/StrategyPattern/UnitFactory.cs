using System;

namespace StrategyPattern
{
    public class UnitFactory
    {
        public IUnit Create(UnitType unitType)
        {
            switch (unitType)
            {
                case UnitType.Soldier:
                    return new SoldierUnit();
                case UnitType.Aircraft:
                    return new AircraftUnit();
                case UnitType.Tank:
                    return new TankUnit();
                default:
                    throw new ArgumentOutOfRangeException(nameof(unitType), unitType, null);
            }
        }
    }
}