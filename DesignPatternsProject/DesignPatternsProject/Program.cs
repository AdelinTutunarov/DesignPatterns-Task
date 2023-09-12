namespace DesignPatternsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SweetShop shop = SweetShop.GetInstance();

            IceCream fruityIceCream = shop.CreateIceCream("fruity");
            Console.WriteLine(fruityIceCream.Make());

            IceCream chocolateIceCream = shop.CreateIceCream("chocolate");
            chocolateIceCream = new SprinklesDecorator(chocolateIceCream);
            Console.WriteLine(chocolateIceCream.Make());

            IceCream creamIceCream = shop.CreateIceCream("cream");
            creamIceCream = new ChocolateGlazeDecorator(creamIceCream);
            Console.WriteLine(creamIceCream.Make());
        }
    }
}