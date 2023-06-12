using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CSharp
{
    abstract class Lamp: ILightSource
    {
        public abstract double Temperature { get; set; }
        public abstract double Power { get; set; }
        public abstract double LifeTime { get; set; }
        public abstract string SourceType { get; set; }


        public  Lamp() { }

        public abstract bool IsActive();
        public abstract bool TurnOn();
        public abstract bool TurnOff();
    }
}
