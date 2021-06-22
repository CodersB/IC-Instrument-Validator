using System;
using System.Collections.Generic;

namespace InstrumentsFactory
{
    public class ICPin
    {
        public int PinNumber { get; set; }
        public string PinName { get; set; }
        public List<Models> SupportedModels { get; set; }
        public List<Categories> SupportedCategories { get; set; }
    }
}
