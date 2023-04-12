namespace da
{
    public abstract class Muschroom
    {
        public abstract string Operation();
    }


    public class ConcreteMuschroom : Muschroom
    {
        public override string Operation()
        {
            return "Concrete Muschroom";
        }
    }

    public abstract class Decorator : Muschroom
    {
        protected Muschroom _Muschroom;

        public Decorator(Muschroom Muschroom)
        {
            this._Muschroom = Muschroom;
        }

        public void SetMuschroom(Muschroom Muschroom)
        {
            this._Muschroom = Muschroom;
        }


        public override string Operation()
        {
            if (this._Muschroom != null)
            {
                return this._Muschroom.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    public class Portobello : Decorator
    {
        public Portobello(Muschroom comp) : base(comp)
        {
        }


        public override string Operation()
        {
            return $"Portobello({base.Operation()})";
        }
    }


    public class Chanterelle : Decorator
    {
        public Chanterelle(Muschroom comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"Chanterelle({base.Operation()})";
        }
    }

    public class Client
    {

        public void ClientCode(Muschroom Muschroom)
        {
            Console.WriteLine("RESULT: " + Muschroom.Operation());
        }
    }
}