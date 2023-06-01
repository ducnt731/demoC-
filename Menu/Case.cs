using a2.Base;
using a2.CaseDecoratorLibrary;

namespace a2.Menu
{
    public class Case : MenuProgram
    {
        private ICase c;
        public Case()
        {
            c = new tabletCase();
        }
        protected override void DoTask(int option)
        {
            switch(option)
            {
                case 1: BlackPaint(); break;
                case 2: RedPaint(); break;
                case 3: Sticker(); break;
                case 4: Toy(); break;
                case 5: PrintingPicture(); break;
                case 6: Magnet(); break;
                case 0: break;
                default: System.Console.WriteLine("Invalid option!!!!"); break;
            }
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("-------List options-------");
            System.Console.WriteLine("1. Black Paint");
            System.Console.WriteLine("2. Red Paint");
            System.Console.WriteLine("3. Sticker");
            System.Console.WriteLine("4. Toy");
            System.Console.WriteLine("5. Printing Picture");
            System.Console.WriteLine("6. Magnet");
            System.Console.WriteLine("0. Exit");
            System.Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        }
        private void PrintingPicture()
        {
            c = new PrintingPicture(c);
            System.Console.WriteLine("Total cost: " + ((PrintingPicture)c).Cost() + "$");
        }
        private void Toy()
        {
            c = new Toy(c);
            System.Console.WriteLine("Total cost: " + ((Toy)c).Cost() + "$");
        }
        private void Sticker()
        {
            c = new  Sticker(c);
            System.Console.WriteLine("Total cost: " + ((Sticker)c).Cost() + "$");
        }
        private void RedPaint()
        {
            c = new  RedPaint(c);
            System.Console.WriteLine("Total cost: " + ((RedPaint)c).Cost() + "$");
        }
        private void BlackPaint()
        {
            c = new  BlackPaint(c);
            System.Console.WriteLine("Total cost: " + ((BlackPaint)c).Cost() + "$");
        }
        private void Magnet()
        {
            c = new Magnet(c);
            System.Console.WriteLine("Total cost: " + ((Magnet)c).Cost()+ "$");
        }
    }
}