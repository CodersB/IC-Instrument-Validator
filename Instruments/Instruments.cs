using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public abstract class Instruments
    {        
        public abstract VoltageHandler CreateVoltageHandler(Models model);
        public abstract CurrentHandler CreateCurrentHandler(Models model);

        public Instruments(Models model)
        {
            this.CreateInstrument(model);
        }

        public abstract void CreateInstrument(Models model);

        public abstract bool Validate(Pins pin, int volt);
       
        public Instruments(Categories category, Models model)
        {
            switch (category)
            {
                case Categories.Current:
                    this.CreateCurrentHandler(model);
                    break;
                case Categories.Voltage:
                    this.CreateVoltageHandler(model);
                    break;

            }
        }

        public void CreateInstrument(Categories category, Models model)
        {
            switch (model)
            {
                case Models.Low:
                    this.CreateCurrentHandler(model);
                    break;
                case Models.High:
                    this.CreateVoltageHandler(model);
                    break;
                default:
                    throw new NotImplementedException();

            }
        }

    }

    public enum Categories
    {
        Voltage,
        Current
    }

    public enum Models
    {
        Low,
        Medium,
        High
    }

    public enum Pins
    {
        Pin_1 = 1,
        Pin_2,
        Pin_3,
        Pin_4,
        Pin_5,
        Pin_6,
        Pin_7,
        Pin_8,
        Pin_9,
        Pin_10,
        Pin_11,
        Pin_12,
        Pin_13,
        Pin_14

    }
}
