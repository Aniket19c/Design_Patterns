using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Design_Patterns
{
    using System;
    using System.Collections.Generic;

    
    interface IObserver
    {
        void Update(float temperature);
    }

    interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    
    class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(float temp)
        {
            temperature = temp;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }


    class MobileDisplay : IObserver
    {
        private string name;

        public MobileDisplay(string name)
        {
            this.name = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{name} Display: Temperature updated to {temperature}°C");
        }
    }

    class Program
    {
        static void Main()
        {
            WeatherStation weatherStation = new WeatherStation();

            IObserver mobileDisplay1 = new MobileDisplay("Mobile 1");
            IObserver mobileDisplay2 = new MobileDisplay("Mobile 2");

            weatherStation.Attach(mobileDisplay1);
            weatherStation.Attach(mobileDisplay2);

            weatherStation.SetTemperature(30);
            weatherStation.SetTemperature(25);

            weatherStation.Detach(mobileDisplay1);

            weatherStation.SetTemperature(28);
            Console.ReadLine();
        }
    }

}
