using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsFactory
{
    public class InstrumentFactory
    {
        private Categories Category;
        private Models Model;
        public InstrumentFactory(Categories category, Models model)
        {
            Category = category;
            Model = model;
        }

       public IInstruments CreateInstrument()
        {
            switch (Category)
            {
                case Categories.Current:
                    return GetCurrentInstrument();
                case Categories.Voltage:
                    return GetVoltageInstrument();
                default:
                    throw new NotImplementedException();
            }
        }

        private IInstruments GetCurrentInstrument()
        {
            if (Model == Models.Low)
                return new LowCurrentInstrument();
            else if (Model == Models.High)
                return new HighCurrentInstrument();
            else
                throw ThrowUnSupportedModel();
        }

        private Exception ThrowUnSupportedModel()
        {
            throw new NotImplementedException($"The Model# {Model} is not a supported. Choose either Low (1) or High (2).");
        }

        private IInstruments GetVoltageInstrument()
        {
            if (Model == Models.Low)
                return new LowVoltageInstrument();
            else if (Model == Models.High)
                return new HighVoltageInstrument();
            else
                throw ThrowUnSupportedModel();
        }
    }
}
