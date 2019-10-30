using System;
using Xunit;
using Facade;

namespace Facade.Tests
{
    public class FacadeTest
    {
        [Fact]
        public void TestFacade()
        {
            SwitchBoardFacade facade = new SwitchBoardFacade();
            var facLightReturn = facade.PressSwitch(SwitchType.Light, true);
            var facFanReturn = facade.PressSwitch(SwitchType.Fan, true);
            var facPointReturn = facade.PressSwitch(SwitchType.PlugPoint, true);
            Assert.Equal("Light Off !!!", facLightReturn);
            Assert.Equal("Fan Off !!!", facFanReturn);
            Assert.Equal("Plug Point Off !!!", facPointReturn);
            facLightReturn = facade.PressSwitch(SwitchType.Light, false);
            facFanReturn = facade.PressSwitch(SwitchType.Fan, false);
            facPointReturn = facade.PressSwitch(SwitchType.PlugPoint, false);
            Assert.Equal("Light On !!!", facLightReturn);
            Assert.Equal("Fan On !!!", facFanReturn);
            Assert.Equal("Plug Point On !!!", facPointReturn);
        }
    }
}
