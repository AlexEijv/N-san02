// string [] stringToy = {"Nerf", "spider man", "tåg", "svärd", "yxa"};

// // for (int i = 0; i < stringArray.Length; i++)
// // {
// //     Console.WriteLine(stringArray[i]);
// // }
// // Console.ReadLine();

// string[] stringNames = { "Bogdan", "Rubio", "Kiwi", "Skoogen", "Mande POON" };

// // for (int i = 0; i < stringArray.Length; i++)
// // {
// //     Console.WriteLine(stringArray[i]);
// // }

// int[] intarray = { 1, 2, 3, 4, 5 };

// for (int i = 0; i < stringNames.Length; i++)
// {
//     Console.WriteLine($"{stringNames[i]} gives {stringToy[i]} Rating {intarray[i]}" );
// }


List<string> cities = [];
bool exit = false;
Console.WriteLine("Skriv in namn på orter");

while (exit == false)
{
    string choice = Console.ReadLine();
    if (choice != "exit")
    {
        cities.Add(choice);
    }
    else
    {
        exit = true;
        Console.WriteLine("Tryck på valfri knapp för att avsluta");
    }
}

foreach (string ort in cities)
{
    Console.WriteLine(ort);
}

Console.ReadKey();