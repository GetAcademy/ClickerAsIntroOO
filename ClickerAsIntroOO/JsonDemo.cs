using System.Text.Json;

namespace ClickerAsIntroOO
{
    internal class JsonDemo
    {
        public static void Run()
        {
            var json = File.ReadAllText("people.json");
            var options = new JsonSerializerOptions { IncludeFields = true };
            var people = JsonSerializer.Deserialize<Person[]>(json, options);
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Points}");
                person.Points++;
            }

            json = JsonSerializer.Serialize(people, options);
            File.WriteAllText("people.json", json);
        }
    }
}
