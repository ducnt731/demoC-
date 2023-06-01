using a2.Base;

namespace a2.CaseDecoratorLibrary
{
    public class PrintingPicture : PhoneCaseDecorator
    {
        public PrintingPicture(ICase paste) : base (paste)
        {
        }
        public override double Cost()
        {
            return 5.0 + base.Cost();
        }
    }
}
