using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Design_Patterns
{

    interface IPhoneCharger
    {
        void ChargePhone();
    }

    class EuropeanCharger
    {
        public void ChargeWithEuropeanPlug()
        {
            Console.WriteLine("Charging with European Plug...");
        }
    }

    class ChargerAdapter : IPhoneCharger
    {
        private EuropeanCharger _europeanCharger;

        public ChargerAdapter(EuropeanCharger europeanCharger)
        {
            _europeanCharger = europeanCharger;
        }

        public void ChargePhone()
        {
            Console.WriteLine("Using Adapter...");
            _europeanCharger.ChargeWithEuropeanPlug();
        }
    }

    class Program
    {
        static void Main()
        {
            EuropeanCharger oldCharger = new EuropeanCharger();
            IPhoneCharger adapter = new ChargerAdapter(oldCharger);
            adapter.ChargePhone();
            Console.ReadLine(); 
        }
    }

}
