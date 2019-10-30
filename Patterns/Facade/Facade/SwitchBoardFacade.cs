using System;

namespace Facade
{
    public class SwitchBoardFacade
    {
        private readonly Light _light;
        private readonly Fan _fan;
        private readonly PlugPoint _plugPoint;

        public SwitchBoardFacade()
        {
            _light = new Light();
            _fan = new Fan();
            _plugPoint = new PlugPoint();
        }

        public string PressSwitch(SwitchType type, bool state)
        {
            switch (type)
            {
                case SwitchType.Light:
                    if (state)
                        return _light.Off();
                    else
                        return _light.On();
                case SwitchType.Fan:
                    if (state)
                        return _fan.Off();
                    else
                        return _fan.On();
                    
                case SwitchType.PlugPoint:
                    if (state)
                        return _plugPoint.Off();
                    else
                        return _plugPoint.On();
                default:
                    return "";
            }
        }
    }
}
