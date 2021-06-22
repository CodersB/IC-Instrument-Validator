using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class MediumVoltageHandler : VoltageHandler
    {

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
        public override bool Validate(Pins pin, int volt)
        {
            throw new NotImplementedException();
        }
    }
}
