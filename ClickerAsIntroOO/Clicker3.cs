namespace ClickerAsIntroOO
{
    internal class Clicker3
    {
        //private static int _points = 0;
        //private static int _upgrades = 1;
        private static ClickerSimple _clicker = new ClickerSimple();

        public static void Run()
        {
            while (true)
            {
                Show();
                var cmdKey = Console.ReadKey(true);
                HandleCommand(cmdKey);
            }
        }

        private static void Show()
        {
            Console.Clear();
            Console.WriteLine($"Klikker A: Du har {_clicker.Points} poeng. (a=klikk, A=upgrade)");
        }

        private static void HandleCommand(ConsoleKeyInfo cmdKey)
        {
            if (cmdKey.KeyChar == 'a')
            {
                _clicker.Points += _clicker.Upgrades;
            }
            else if (cmdKey.KeyChar == 'A')
            {
                if (_clicker.Points >= 10)
                {
                    _clicker.Upgrades++;
                    _clicker.Points -= 10;
                }
            }
        }
    }
}
