using a2.Base;

namespace a2.CaseDecoratorLibrary
{
    public class Sticker : PhoneCaseDecorator
    {
        public Sticker(ICase paste) : base (paste)
        {
        }
        public override double Cost()
        {
            return 0.5 + base.Cost();
        }
    }
}
