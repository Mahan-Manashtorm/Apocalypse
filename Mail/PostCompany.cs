using System.Diagnostics.Metrics;

namespace Post
{
    public interface IPostCompany
    {
        ILetter CreateLetter();
        IParcel CreateParcel();
        IPackage CreatePackage();
    }

    class ConCreteFactoryCustom : IPostCompany
    {
        public ILetter CreateLetter()
        {
            return new CustomLetter();
        }
        public IParcel CreateParcel()
        {
            return new CustomParcel();
        }
        public IPackage CreatePackage()
        {
            return new CustomPackage();
        }
    }
    class ConCreteFactoryValuable : IPostCompany
    {
        public ILetter CreateLetter()
        {
            return new ValuableLetter();
        }
        public IParcel CreateParcel()
        {
            return new ValuableParcel();
        }
        public IPackage CreatePackage()
        {
            return new ValuablePackage();
        }
    }
    class ConCreteFactoryExpress : IPostCompany
    {
        public ILetter CreateLetter()
        {
            return new ExpressLetter();
        }
        public IParcel CreateParcel()
        {
            return new ExpressParcel();
        }
        public IPackage CreatePackage()
        {
            return new ExpressPackage();
        }
    }

    public interface ILetter
    {
        float capacity { get; set; }
        void Send();
    }
    public interface IParcel
    {
        float capacity { get; set; }
        void Send();
    }
    public interface IPackage
    {
        float capacity { get; set; }
        void Send();
    }
    public class CustomLetter : ILetter
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна CustomLetter");
        } 
    }
    public class ValuableLetter : ILetter
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна ValuableLetter");
        }
    }
    public class ExpressLetter : ILetter
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна ExpressLetter");
        }
    }

    public class CustomParcel : IParcel
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна CustomParcel");
        }
    }
    public class ValuableParcel : IParcel
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна ValuableParcel");
        }
    }
    public class ExpressParcel : IParcel
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна ExpressParcel");
        }
    }

    public class CustomPackage : IPackage
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна CustomPackage");
        }
    }
    public class ValuablePackage : IPackage
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна ValuablePackage");
        }
    }
    public class ExpressPackage : IPackage
    {
        public float capacity { get; set; }
        public void Send()
        {
            Console.WriteLine("Посылка отправленна ExpressPackage");
        }
    }
    public class Client
    {
        public void Main()
        {
            ClientMEF(new ConCreteFactoryCustom());
            ClientMEF(new ConCreteFactoryExpress());
            ClientMEF(new ConCreteFactoryValuable());
        }
        public void ClientMEF(IPostCompany facktory) 
        {
            var Letter = facktory.CreateLetter();
            var Parcel = facktory.CreateParcel();
            var Package = facktory.CreatePackage();
            Letter.Send();
            Parcel.Send();
            Package.Send();
        }
    }
}