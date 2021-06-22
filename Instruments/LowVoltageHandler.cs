using System.Collections.Generic;

namespace Instruments
{
    public class LowVoltageHandler : VoltageHandler
    {

        public LowVoltageHandler(Models model) : base(model)
        {
        }

        public List<Pins> SupportedPins
        {
            get
            {
                return new List<Pins> { Pins.Pin_1, Pins.Pin_2, Pins.Pin_4 };
            }
        }

        public List<int> SupportedVolts
        {
            get
            {
                return new List<int> { 0, 1, 2, 3, 4 };
            }
        }

        public override VoltageHandler CreateVoltageHandler(Models model)
        {
            throw new System.NotImplementedException();
        }

        public override bool Validate(Pins pin, int volts)
        {
            if (SupportedPins.Contains(pin) && SupportedVolts.Contains(volts))
                return true;

            return false;
        }
    }
}