using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class EngineService
    {
        public Engine MakeEngine(int horsePower)
        {
            return new Engine()
            {
                HorsePower = horsePower
            };
        }
    }
}
