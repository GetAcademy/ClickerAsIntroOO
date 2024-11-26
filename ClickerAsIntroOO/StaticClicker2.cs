namespace ClickerAsIntroOO
{
    internal class StaticClicker2
    {
        private static int _points = 0;
        private static int _upgrades = 1;

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
            Console.WriteLine($"Klikker A: Du har {_points} poeng. (a=klikk, A=upgrade)");
        }

        private static void HandleCommand(ConsoleKeyInfo cmdKey)
        {
            if (cmdKey.KeyChar == 'a')
            {
                _points += _upgrades;
            }
            else if (cmdKey.KeyChar == 'A')
            {
                if (_points >= 10)
                {
                    _upgrades++;
                    _points -= 10;
                }
            }
        }
    }
}
