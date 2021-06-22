
using System;
using InstrumentsFactory;
//using Instruments;

namespace IC_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Instrument, press 1 for Voltage or 2 for Current : ");

            var category = (Categories) Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Pick a model, press 1 for Low, 2 for High : ");
            var model = (Models) Convert.ToInt32(Console.ReadLine());

            //Instruments instrument = new LowCurrentInstrument();

            //InstrumentFactory factory = new(Categories.Current, Models.Low);
            try
            {
                InstrumentFactory factory = new(category, model);
                Console.WriteLine("Enter Pin# : ");
                var pin = (Pins)Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter volts: ");
                var volts = Convert.ToInt32(Console.ReadLine());


                IInstruments instrument = factory.CreateInstrument();

                Console.WriteLine(instrument.Validate(pin, volts) == true ? "Validation Succeeded." : "Validation Failed.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                 

            Console.ReadKey();


        }
    }
}
