namespace da
{
    public class Phone
    {
        public string Screen { get; set; }
        public string Battery { get; set; }
        public string Camera { get; set; }
        public string Processor { get; set; }

        public override string ToString()
        {
            return $"Screen: {Screen}, Battery: {Battery}, Camera: {Camera}, Processor: {Processor}";
        }
    }
    public interface IPhoneBuilder
    {
        void SetScreen();
        void SetBattery();
        void SetCamera();
        void SetProcessor();
        Phone GetPhone();
    }
    public class BasicPhoneBuilder : IPhoneBuilder
    {
        private readonly Phone _phone = new Phone();

        public void SetScreen()
        {
            _phone.Screen = "LCD";
        }

        public void SetBattery()
        {
            _phone.Battery = "2000mAh";
        }

        public void SetCamera()
        {
            _phone.Camera = "5MP";
        }

        public void SetProcessor()
        {
            _phone.Processor = "Snapdragon 200";
        }

        public Phone GetPhone()
        {
            return _phone;
        }
    }

    public class PremiumPhoneBuilder : IPhoneBuilder
    {
        private readonly Phone _phone = new Phone();

        public void SetScreen()
        {
            _phone.Screen = "AMOLED";
        }

        public void SetBattery()
        {
            _phone.Battery = "4000mAh";
        }

        public void SetCamera()
        {
            _phone.Camera = "12MP";
        }

        public void SetProcessor()
        {
            _phone.Processor = "Snapdragon 888";
        }

        public Phone GetPhone()
        {
            return _phone;
        }
    }
    public class PhoneDirector
    {
        public void BuildBasicPhone(IPhoneBuilder builder)
        {
            builder.SetScreen();
            builder.SetBattery();
            builder.SetCamera();
            builder.SetProcessor();
        }

        public void BuildPremiumPhone(IPhoneBuilder builder)
        {
            builder.SetScreen();
            builder.SetBattery();
            builder.SetCamera();
            builder.SetProcessor();
        }
    }

}