using DecoratorPattern;
using System;
using Xunit;

namespace DecoratorTests
{
    public class DecoratorTests
    {
        [Fact]
        public void Decorating_fullweapon_object()
        {
            var fullWeapon = new WeaponSilencer(new WeaponSight(new BaseWeapon()));
            Assert.Equal("This is the base weapon! Sight added! Silencer added!", fullWeapon.Mount());
        }

        [Fact]
        public void Decorating_simple_weapon_object()
        {
            var simpleWeapon = new BaseWeapon();
            Assert.Equal("This is the base weapon!", simpleWeapon.Mount());
        }


        [Fact]
        public void Decorating_weapon_with_silencer_object()
        {
            var simpleWeapon = new BaseWeapon();
            var weaponWithSilencer = new WeaponSilencer(simpleWeapon);
            Assert.Equal("This is the base weapon! Silencer added!", weaponWithSilencer.Mount());
        }

        [Fact]
        public void Decorating_weapon_with_sight_object()
        {
            var simpleWeapon = new BaseWeapon();
            var weaponWithSight = new WeaponSight(simpleWeapon);
            Assert.Equal("This is the base weapon! Sight added!", weaponWithSight.Mount());
        }
    }
}
