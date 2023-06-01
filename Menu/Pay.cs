using a2.Base;
using a2.CaseDecoratorLibrary;

namespace a2.Menu
{
    public class Pay : MenuProgram
    {
        private ICase d;
        public Pay()
        {
            d = new PhoneCase();
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
            d = new PrintingPicture(d);
            System.Console.WriteLine("Total cost: " + ((PrintingPicture)d).Cost() + "$");
        }
        private void Toy()
        {
            d = new Toy(d);
            System.Console.WriteLine("Total cost: " + ((Toy)d).Cost() + "$");
        }
        private void Sticker()
        {
            d = new  Sticker(d);
            System.Console.WriteLine("Total cost: " + ((Sticker)d).Cost() + "$");
        }
        private void RedPaint()
        {
            d = new  RedPaint(d);
            System.Console.WriteLine("Total cost: " + ((RedPaint)d).Cost() + "$");
        }
        private void BlackPaint()
        {
            d = new  BlackPaint(d);
            System.Console.WriteLine("Total cost: " + ((BlackPaint)d).Cost() + "$");
        }
        private void Magnet()
        {
            d = new Magnet(d);
            System.Console.WriteLine("Total cost: " + ((Magnet)d).Cost()+ "$");
        }
    }
}