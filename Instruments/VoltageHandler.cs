using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public abstract class VoltageHandler : Instruments
    {
        private Instruments instrument;
        protected VoltageHandler(Models model) : base(model)
        {
        }

        public override CurrentHandler CreateCurrentHandler(Models model)
        {
            throw new NotImplementedException();
        }

        public override VoltageHandler CreateVoltageHandler(Models model)
        {
            switch (model)
            {
                case Models.Low:
                    return new LowVoltageHandler(model);
                case Models.High:
                    return new HighVoltageHandler(model);
                default:
                    throw new NotImplementedException();
            }
        }

        public override void CreateInstrument(Models model)
        {
            switch (model)
            {
                case Models.Low:
                    instrument = new LowVoltageHandler(model);
                    break;
                case Models.High:
                    instrument = new HighVoltageHandler(model);
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

       // public abstract bool Validate(Pins pin, int volts);
        
    }
}
