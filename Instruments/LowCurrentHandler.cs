using System.Collections.Generic;

namespace Instruments
{
    public class LowCurrentHandler : CurrentHandler
    {
  
        public LowCurrentHandler(Models model) : base(model)
        {
        }

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
                return new List<int> { 0, 1, 2, 3, 4 };
            }
        }



        public override bool Validate(Pins pin, int volts)
        {
            if (SupportedPins.Contains(pin) && SupportedVolts.Contains(volts))
                return true;

            return false;
        }
    }
}