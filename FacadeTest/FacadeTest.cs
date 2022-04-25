using Facade;
using System.Linq;
using Xunit;

namespace FacadeTest
{
    public class FacadeTest
    {
        [Fact]
        public void Car_creation_is_correct()
        {
            WheelService wheelFactory = new WheelService();
            EngineService engineFactory = new EngineService();
            BodyworkService bodyworkFactory = new BodyworkService();

            var wheels = wheelFactory.MakeWheels(4, 170);
            var engine = engineFactory.MakeEngine(120);
            var bodywork = bodyworkFactory.MakeBodywork("Red");

            Car car = new Car(wheels, bodywork, engine);

            Assert.Equal("Red", car.Bodywork.Color);
            Assert.Equal(4, car.Wheels.Length);
            Assert.Equal(170, car.Wheels.Select(w => w.TireWidth).Distinct().FirstOrDefault());
            Assert.Equal(120, car.Engine.HorsePower);
        }
        [Fact]
        public void Car_creation_is_correct_facade()
        {
            CarService carFactory = new CarService();

            Car car = carFactory.MakeCar(120, "Red", 170);

            Assert.Equal("Red", car.Bodywork.Color);
            Assert.Equal(4, car.Wheels.Length);
            Assert.Equal(170, car.Wheels.Select(w => w.TireWidth).Distinct().FirstOrDefault());
            Assert.Equal(120, car.Engine.HorsePower);
        }
    }
}