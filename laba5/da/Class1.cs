namespace da
{
    public class Phone
    {
        public string Screen { get; set; }
        public string Battery { get; set; }
        public string Camera { get; set; }
        public string Processor { get; set; }

        public Phone ShallowCopy()
        {
            return (Phone)this.MemberwiseClone();
        }

        public Phone DeepCopy()
        {
            Phone clone = (Phone)this.MemberwiseClone();
            clone.Battery = String.Copy(Battery);
            clone.Camera = String.Copy(Camera);
            clone.Processor = String.Copy(Processor);
            return clone;
        }
        public void DisplayValues()
        {
            Console.WriteLine("      Screen: {0:s}, Battery: {1:s}, Camera: {2:s}, Processor: {3:s}",
                Screen, Battery, Camera, Processor);
        }
    } 
}