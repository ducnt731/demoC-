using a2.Base;

namespace a2.CaseDecoratorLibrary
{
    public class RedPaint : PhoneCaseDecorator
    {
        public RedPaint(ICase paste) : base (paste)
        {
        }
        public override double Cost()
        {
            return 2.0 + base.Cost();
        }
    }
}
