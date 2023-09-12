namespace DesignPatternsProject
{
    public class SweetShop
    {
        private static SweetShop _instance = null!;
        private SweetShop() { }

        public static SweetShop GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SweetShop();
            }
            return _instance;
        }

        // Factory method to create different types of ice cream
        public IceCream CreateIceCream(string type)
        {
            switch (type.ToLower())
            {
                case "fruity":
                    return new FruityIceCream();
                case "chocolate":
                    return new ChocolateIceCream();
                case "cream":
                    return new CreamyIceCream();
                default:
                    throw new ArgumentException("Invalid ice cream type.");
            }
        }
    }
}
