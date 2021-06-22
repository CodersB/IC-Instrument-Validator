using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsFactory
{
    public abstract class Instruments : IInstruments
    {
        public abstract List<Pins> SupportedPins { get; }

        public IInstruments CreateInstruments(Categories category, Models model)
        {
            throw new NotImplementedException();
            //switch (model)
            //{
            //    case Models.Low:
            //        return new LowCurrentInstrument();
            //    case Models.High:
            //        return new HighCurrentInstrument();

            //    default:
            //        throw new NotImplementedException();
            //}
        }
     

        public  bool Validate(Pins pin, int volt)
        {
            if (SupportedPins.Contains(pin))
                return true;

            return false;
        }
        
    }
}
