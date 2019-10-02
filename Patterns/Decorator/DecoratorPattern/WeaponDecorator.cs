namespace DecoratorPattern
{
    public class WeaponDecorator : IWeapon
    {
        protected IWeapon _weapon;

        public WeaponDecorator(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public virtual string Mount() => _weapon.Mount();
    }
}
