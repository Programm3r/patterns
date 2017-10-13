using NUnit.Framework;

namespace StrategyPattern.Test
{
    [TestFixture]
    public class When_creating_unit
    {
        [TestCase(UnitType.Soldier, 50, 50)]
        [TestCase(UnitType.Tank, 1000, 500)]
        [TestCase(UnitType.Aircraft, 500, 1000)]
        public void It_should_create_correct_unit_with_appropriate_parameters(UnitType unitType, int expectedHitPoints,
            int expectedAttack)
        {
            // Given
            UnitFactory unitFactory = new UnitFactory();

            // When
            IUnit unit = unitFactory.Create(unitType);

            // Then
            Assert.Multiple(() =>
            {
                Assert.NotNull(unit);
                Assert.AreEqual(expectedHitPoints, unit.HitPoints);
                Assert.AreEqual(expectedAttack, unit.Attack);
            });
        }
    }
}