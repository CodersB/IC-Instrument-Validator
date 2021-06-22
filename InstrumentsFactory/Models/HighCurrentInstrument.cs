using System.Collections.Generic;

namespace InstrumentsFactory
{
    internal class HighCurrentInstrument : CurrentInstrument
    {
        public override List<Pins> SupportedPins
        {
            get { return new List<Pins> { Pins.Pin_13, Pins.Pin_14 }; }
        }

        //public override bool Validate(Pins pin, int volt)
        //{
        //    return false;
        //}
    }
}