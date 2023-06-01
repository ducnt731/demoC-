namespace a2.Base
{
    public abstract class PhoneCaseDecorator : ICase
    {
        private ICase phoneCase;
        public PhoneCaseDecorator(ICase paste)
        {
            phoneCase = paste;
        }
        public virtual double Cost()
        {
            return phoneCase.Cost();
        }
    }
}
