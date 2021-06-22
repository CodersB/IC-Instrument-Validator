using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public class InstrumentFactory
    {
        private VoltageHandler voltageHandler;
        private CurrentHandler currentHandler;

        private Instruments instrument;

        public InstrumentFactory(Instruments instrument, Models model)
        {
            voltageHandler = instrument.CreateVoltageHandler(model);
            currentHandler = instrument.CreateCurrentHandler(model);
            
        }


        public Instruments CreateFactory(Categories category, Models model)
        {
            switch (category)
            {
                case Categories.Current:
                    return new Instruments(Categories.Voltage, Models.Low);
                    break;
            }

        }

        //public InstrumentFactory(Categories category, Models model)
        //{
        //    switch(category)
        //    {
        //        case Categories.Current:
        //            instrument = new Instruments(model).CreateCurrentHandler();
        //    }

        //    //switch (category)
        //    //{
        //    //    case Categories.Current:
        //    //        instrument = new  CurrentHandler().CreateCurrentHandler(model);
        //    //    default:
        //    //        instrument = new CurrentHandler().CreateCurrentHandler(model);

        //    //        //return new CurrentHandler().CreateCurrentHandler(model);

        //    //        // case Categories.Voltage:
        //    //        // return new VoltageHandler().CreateVoltageHandler(model);

        //    //}
        //    // voltageHandler = instrument.CreateVoltageHandler(model);
        //    // currentHandler = instrument.CreateCurrentHandler(model);

        //}

        public bool ValidateVoltage(Pins pin, int volt )
        {
            return voltageHandler.Validate(pin, volt);
        }

        public bool ValidateCurrent(Pins pin, int volt)
        {
            return currentHandler.Validate(pin, volt);
        }
    }
}
