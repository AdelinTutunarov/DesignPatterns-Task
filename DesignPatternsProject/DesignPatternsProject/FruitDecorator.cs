namespace DesignPatternsProject
{
    public class FruitDecorator : IceCreamDecorator
    {
        public FruitDecorator(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Make()
        {
            return base.Make() + " with fruit";
        }
    }
}
