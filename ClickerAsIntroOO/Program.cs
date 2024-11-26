using System.Text.Json;
using ClickerAsIntroOO;

//JsonDemo.Run();

int a = 5;
int b = a;
b = 6;

/*
var personA = new Person { Name = "a" };
var personB = new Person()
{
    Name = personA.Name,
    Points = personA.Points,
};

personB.Points++;

Console.WriteLine($"{personA.Name} {personA.Points}");
Console.WriteLine($"{personB.Name} {personB.Points}");
*/


var options = new JsonSerializerOptions { IncludeFields = true };
var clickers = new Clicker[]
{
    new Clicker('a'),
    new Clicker('b'),
    new Clicker('c'),
    new Clicker('d'),
    new Clicker('e'),
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

    var json = JsonSerializer.Serialize(clickers, options);
    File.WriteAllText("clickers.json", json);
}
