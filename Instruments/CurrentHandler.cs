using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public abstract class CurrentHandler : Instruments
    {
        private Instruments instrument;

        protected CurrentHandler(Models model) : base(model)
        {

        }

        public override CurrentHandler CreateCurrentHandler(Models model)
        {
            switch (model)
            {
                case Models.Low:
                    return new LowCurrentHandler(model);
                case Models.High:
                    return new HighCurrentHandler(model);
                default:
                    throw new NotImplementedException();
            }
        }

        public override VoltageHandler CreateVoltageHandler(Models model)
        {
            throw new NotImplementedException();
        }

        public override void CreateInstrument(Models model)
        {
            switch (model)
            {
                case Models.Low:
                    instrument =  new LowCurrentHandler(model);
                    break;
                case Models.High:
                    instrument = new LowCurrentHandler(model);
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

      

    }
}
