namespace DesignPatternsProject
{
    public class SprinklesDecorator : IceCreamDecorator
    {
        public SprinklesDecorator(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Make()
        {
            return base.Make() + " with sprinkles";
        }
    }
}
