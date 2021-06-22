using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsFactory
{
    public interface IInstruments: IValidate
    {

        List<Pins> SupportedPins { get; }
        IInstruments CreateInstruments(Categories category, Models model);
        //IVoltageInstruments CreateVoltageInstruments(Categories category, Models model);
        //ICurrentInstruments CreateCurrentInstruments(Categories category, Models model);

        //bool IValidate(Pins pin, int volt);

    }
}
