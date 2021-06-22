using System.Collections.Generic;

namespace InstrumentsFactory
{
    public class LowCurrentInstrument : CurrentInstrument
    {
        public override List<Pins> SupportedPins
        {
            get { return new List<Pins> { Pins.Pin_5, Pins.Pin_6, Pins.Pin_7, Pins.Pin_8 }; }
        }

        //public override bool Validate(Pins pin, int volt)
        //{
        //    if (pin == Pins.Pin_1)
        //        return true;

        //    return false;

        //}
    }
}