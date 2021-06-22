using System.Collections.Generic;

namespace Instruments
{
    public class HighVoltageHandler : VoltageHandler
    {

        public List<Pins> SupportedPins
        {
            get
            {
                return new List<Pins> { Pins.Pin_10, Pins.Pin_11, Pins.Pin_12 };
            }
        }

        public List<int> SupportedVolts
        {
            get
            {
                return new List<int> { 10, 11, 12, 13, 14 };
            }
        }

        public HighVoltageHandler(Models model): base(model)
        {

        }

        public override bool Validate(Pins pin, int volt)
        {
            if (SupportedPins.Contains(pin) && SupportedVolts.Contains(volt))
                return true;

            return false;
        }

        public override VoltageHandler CreateVoltageHandler(Models model)
        {
            throw new System.NotImplementedException();
        }
    }
}