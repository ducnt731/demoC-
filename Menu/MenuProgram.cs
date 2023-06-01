namespace a2.Menu
{
    public abstract class MenuProgram
    {
        public virtual void Run()
        {
            bool running = true;
            while(running)
            {
                PrintMenu();
                int choice = ChooseOption();
                DoTask(choice);
                if (choice == 0) running = false;
            }
        }
        protected abstract void PrintMenu();
        protected abstract void DoTask(int choice);
        protected virtual int ChooseOption()
        {
            try
            {
                int choice = 0;
                System.Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                return choice;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid choice!!!!");
                Console.WriteLine("Please enter the valid choice");
                return ChooseOption();
            }
        }
    }
}
