using ClickerAsIntroOO;

var clickers = new Clicker[]
{
    new Clicker('a'),
    new Clicker('b'),
    new Clicker('c'),
    new Clicker('d'),
};
while (true)
{
    Console.Clear();
    foreach (var clicker in clickers)
    {
        clicker.Show();
    }
    var cmdKey = Console.ReadKey(true);
    foreach (var clicker in clickers)
    {
        clicker.HandleCommand(cmdKey);
    }
    
}