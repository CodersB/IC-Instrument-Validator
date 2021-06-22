using System.Collections.Generic;

namespace InstrumentsFactory
{
    public class HighVoltageInstrument : VoltageInstrument
    {
        public override List<Pins> SupportedPins
        {
            get { return new List<Pins> { Pins.Pin_9, Pins.Pin_10, Pins.Pin_11, Pins.Pin_12 }; }
        }

        //public override bool Validate(Pins pin, int volt)
        //{
        //    return false;
        //}
    }
}