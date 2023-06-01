using a2.Base;

namespace a2.CaseDecoratorLibrary
{
    public class BlackPaint : PhoneCaseDecorator
    {
        public BlackPaint(ICase paste) : base (paste)
        {
        }
        public override double Cost()
        {
            return 1.5 + base.Cost();
        }
    }
}