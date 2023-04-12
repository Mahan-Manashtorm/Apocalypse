namespace da
{
    public class House
    {
        public string Material { get; set; }

        public override string ToString()
        {
            return $"Material: {Material}";
        }
    }
    public interface IHouseCompany
    {
        void SetMaterial();
        void SetnameCompan();
        string nameCompany { get; set; }
        House GetHouse();
    }
    public class WoodHouseCompany : IHouseCompany
    {
        private readonly House _house = new House();
        public string nameCompany { get; set; }
        public void SetMaterial()
        {
            _house.Material = "Wood";
        }
        public void SetnameCompan()
        {
            nameCompany = "Sus";
        }
        public House GetHouse()
        {
            return _house;
        }
    }
    public class BrickHouseCompany : IHouseCompany
    {
        private readonly House _house = new House();
        public string nameCompany { get; set; }
        public void SetMaterial()
        {
            _house.Material = "Brick";
        }
        public void SetnameCompan()
        {
            nameCompany = "Bus";
        }
        public House GetHouse()
        {
            return _house;
        }
    }
    public class HouseCompany
    {
        public House Construct(IHouseCompany builder)
        {

            builder.SetMaterial();
            builder.SetnameCompan();
            return builder.GetHouse();
        }
    }


}