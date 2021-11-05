using System;

namespace Adapter.Properties
{
    public class ElectricAdapter : Motor
    {
        private ElectricMotor _electricMotor;

        public ElectricAdapter()
        {
            _electricMotor = new ElectricMotor();
        }

        public void Drive()
        {
            _electricMotor.ElectricDrive();
        }
    }
}