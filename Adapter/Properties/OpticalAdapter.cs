namespace Adapter.Properties
{
    public class OpticalAdapter : Motor
    {
        private OpticalMotor _opticalMotor;


        public OpticalAdapter()
        {
            _opticalMotor = new OpticalMotor();
        }
        
        public void Drive()
        {
            _opticalMotor.OpticalDrive();
        }
    }
}