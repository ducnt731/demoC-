using a2.Base;

namespace a2.CaseDecoratorLibrary
{
    public class Toy : PhoneCaseDecorator
    {
        public Toy(ICase paste) : base(paste)
        {
        }
        public override double Cost()
        {
            return 2.3 + base.Cost();
        }
    }
}
