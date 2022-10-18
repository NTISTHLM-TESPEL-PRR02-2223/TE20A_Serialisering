using System.IO;
using System.Text.Json;

string jsonText = File.ReadAllText("talisman.json");

Talisman tal = JsonSerializer.Deserialize<Talisman>(jsonText);

Console.WriteLine(tal.Name);


// Talisman tal = new Talisman()
// {
//   PickedUp = false,
//   IsEquipped = false,
//   Name = "Sprint Master",
//   Price = 300
// };

// string talText = JsonSerializer.Serialize<Talisman>(tal);

// File.WriteAllText("talisman.json", talText);

// Console.WriteLine(talText);




// string name = "Micke";

// string fileName = "namn.txt";

// string name = File.ReadAllText(fileName);

// Console.WriteLine(name);

// File.WriteAllText(fileName, name);




Console.ReadLine();
