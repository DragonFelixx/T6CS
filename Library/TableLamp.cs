using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CSharp
{
    internal class TableLamp: Lamp
    {
        private string manufacturerName;
        private string productName;
        private string tableLampType;
        private double temperature;
        private double power;
        private double lifeTime;
        private string sourceType;
        private bool active = false;

        public TableLamp(): base() { }

        public string ManufacturerName
        {
            get
            {
                return manufacturerName;
            }
            set
            {
                manufacturerName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public string TableLampType
        {
            get
            {
                return tableLampType;
            } set
            {
                tableLampType = value;
            }
        }
        public override double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }
        public override double Power {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }
        public override double LifeTime
        {
            get
            {
                return lifeTime;
            }
            set
            {
                lifeTime = value;
            }
        }
        public override string SourceType 
        {
            get
            {
                return sourceType;
            }
            set
            {
                sourceType = value;
            }
        }


        public override bool IsActive()
        {
            return active;
        }

        public override bool TurnOn()
        {
            this.active = true;
            return active;
        }

        public override bool TurnOff()
        {
            this.active = false;
            return active;
        }

        public string toString()
        {
            return string.Format("Производитель: {0}| Часы работы: {1}| Тепература: {2}| Мощность: {3}| Название: {4}|",
                this.manufacturerName, this.lifeTime, this.temperature, this.power, this.productName);
        }
    }
}
