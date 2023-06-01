using a2.Menu;

namespace a2
{
    class Program : MenuProgram
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
        public override void Run()
        {
            base.Run();
        }
        protected override int ChooseOption()
        {
            return base.ChooseOption();
        }
        protected override void DoTask(int option)
        {
            switch (option)
            {
                case 1: PriceList(); break;
                case 2: tabletCase(); break;
                case 3: phoneCase(); break;
                case 0: break;
                default: Console.WriteLine("Invalid choice!!!!"); break;
            }
        }
        private void tabletCase()
        {
            Case c = new Case();
            c.Run();
        }
        private void phoneCase()
        {
            Pay b = new Pay();
            b.Run();
        }
        private void PriceList()
        {
            System.Console.WriteLine("-------Price list-------");
            System.Console.WriteLine("Cost of case: 3.4$");
            System.Console.WriteLine("Cost of red paint: 2$");
            System.Console.WriteLine("Cost of black paint: 1.5$");
            System.Console.WriteLine("Cost of sticker: 0.5$");
            System.Console.WriteLine("Cost of toy: 2.3$");
            System.Console.WriteLine("Cost of printing picture: 5$");
            System.Console.WriteLine("Cost of magnet: 4$");
            System.Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^");
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("-------Welcome to Kpug Shop-------");
            System.Console.WriteLine("welcome to our shop when you come to our shop you should enter the number to access the system");
            System.Console.WriteLine("Enter the number 1 to access the price list of decorative option");
            System.Console.WriteLine("Enter the number 2 to choose the option to decorative case");
            System.Console.WriteLine("1. Price list");
            System.Console.WriteLine("2. Choose tablet case decorative options");
            System.Console.WriteLine("3. Choose phone case decorative options");
            System.Console.WriteLine("0. Exit");
        }
    }
}
