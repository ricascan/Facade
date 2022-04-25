using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Car
    {
        public Wheel[] Wheels { get; private set; }
        public Bodywork Bodywork { get; private set; }
        public Engine Engine { get; private set; }

        public Car(Wheel[] wheels, Bodywork bodywork, Engine engine)
        {
            Wheels = wheels;
            Bodywork = bodywork;
            Engine = engine;
        }
    }
}
