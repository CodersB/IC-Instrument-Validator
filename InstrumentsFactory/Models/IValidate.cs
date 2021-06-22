using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsFactory
{
    public interface IValidate
    {
        bool Validate(Pins pin, int volt);
    }
}
