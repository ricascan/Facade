using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CarService
    {
        private readonly WheelService _wheelFactory;
        private readonly EngineService _engineFactory;
        private readonly BodyworkService _bodyworkFactory;

        public CarService(WheelService wheelFactory, EngineService engineFactory, BodyworkService bodyworkFactory)
        {
            _wheelFactory = wheelFactory;
            _engineFactory = engineFactory;
            _bodyworkFactory = bodyworkFactory;
        }

        public CarService() : this(new WheelService(), new EngineService(), new BodyworkService())
        {
        }

        public Car MakeCar(int horsePower, string color, decimal tireWidth)
        {
            var wheels = _wheelFactory.MakeWheels(4, tireWidth);
            var engine = _engineFactory.MakeEngine(horsePower);
            var bodywork = _bodyworkFactory.MakeBodywork(color);
            Car car = new(wheels, bodywork, engine);
            return car;
        }
    }
}
