namespace DecoratorPattern
{
    public class WeaponSight : WeaponDecorator
    {
        public WeaponSight(IWeapon weapon) : base(weapon)
        {
        }

        public override string Mount()
        {
            return $"{_weapon.Mount()} Sight added!";
        }
    }
}
