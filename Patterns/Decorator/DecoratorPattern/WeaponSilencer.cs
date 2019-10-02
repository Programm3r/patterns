namespace DecoratorPattern
{
    public class WeaponSilencer : WeaponDecorator
    {
        public WeaponSilencer(IWeapon weapon) : base(weapon)
        {
        }

        public override string Mount()
        {
            return $"{_weapon.Mount()} Silencer added!";
        }
    }
}
