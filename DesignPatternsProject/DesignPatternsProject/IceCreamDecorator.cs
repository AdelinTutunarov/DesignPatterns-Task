namespace DesignPatternsProject
{
    public abstract class IceCreamDecorator : IceCream
    {
        protected IceCream _iceCream;

        public IceCreamDecorator(IceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public override string Make()
        {
            return _iceCream.Make();
        }
    }
}
