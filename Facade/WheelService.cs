using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class WheelService
    {
        public Wheel[] MakeWheels(int count, decimal tireWidth)
        {
            var wheels = new Wheel[count];
            for (int i = 0; i < count; i++)
            {
                wheels[i] = new Wheel()
                {
                    TireWidth = tireWidth
                };
            }
            return wheels;
        }
    }
}
