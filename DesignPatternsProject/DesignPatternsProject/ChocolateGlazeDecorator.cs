namespace DesignPatternsProject
{
    public class ChocolateGlazeDecorator : IceCreamDecorator
    {
        public ChocolateGlazeDecorator(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Make()
        {
            return base.Make() + " with chocolate glaze";
        }
    }
}
