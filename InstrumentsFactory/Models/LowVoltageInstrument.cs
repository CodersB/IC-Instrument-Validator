using System.Collections.Generic;

namespace InstrumentsFactory
{
    internal class LowVoltageInstrument : VoltageInstrument
    {
        public override List<Pins> SupportedPins
        {
            get { return new List<Pins> { Pins.Pin_1, Pins.Pin_2, Pins.Pin_3, Pins.Pin_4}; }
        }

        //public override bool Validate(Pins pin, int volt)
        //{
        //    return false;
        //}
    }
}