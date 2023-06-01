using a2.Base;
namespace a2.CaseDecoratorLibrary
{
    public class Magnet : PhoneCaseDecorator
    {
        public Magnet(ICase paste) : base(paste)
        {
        }
        public override double Cost()
        {
            return 4.0 + base.Cost();
        }
    }
}