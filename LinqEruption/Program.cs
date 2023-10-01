using System.Reflection.Metadata;

List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
//! Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

//! Find first eruption in Chile
Eruption? firstChileEruption = eruptions.FirstOrDefault(c => c.Location == "Chile");
// Console.WriteLine(firstChileEruption?.ToString());

//! Find first Hawaiian Is eruption
Eruption? firstHawaiianEruption = eruptions.FirstOrDefault(c => c.Location == "Hawaiian Is");
// if(firstHawaiianEruption != null) {
//     Console.WriteLine(firstHawaiianEruption.ToString());
// } else {
//     Console.WriteLine("No Hawaiian Is Eruption found");
// }

//! First Greenland eruption
Eruption? firstGreenlandEruption = eruptions.FirstOrDefault(c => c.Location == "Greenland");
// if(firstGreenlandEruption != null) {
//     Console.WriteLine(firstGreenlandEruption.ToString());
// } else {
//     Console.WriteLine("No Greenland Eruption found");
// }

//! First New Zealand after 1900
Eruption? firstNewZealandAfter1900 = eruptions.FirstOrDefault(c => c.Location == "New Zealand" && c.Year > 1900);
// Console.WriteLine(firstNewZealandAfter1900);

//! Volcano Elevations over 2000m
IEnumerable<Eruption> over2000Elevation = eruptions.Where(c => c.ElevationInMeters > 2000);
// PrintEach(over2000Elevation, "Volcano Elevations over 2000m");

//! Volcano's that start with L and count
IEnumerable<Eruption> startsWithL = eruptions.Where(c => c.Volcano.StartsWith("L"));
// PrintEach(startsWithL, "Volcano names that start with L");
// Console.WriteLine("Number of Volcanos that start with L is: " + startsWithL.Count());

//! Find highest elevation and print only that integer
int highestElevation = eruptions.Max(c => c.ElevationInMeters);
// Console.WriteLine("Highest elevation is: " + highestElevation + "m");

//! Print name of Volcano with highest elevation
Eruption? highestElevationName = eruptions.FirstOrDefault(c => c.ElevationInMeters == highestElevation);
// Console.WriteLine("The volcano with the highest elevation is: " + highestElevationName?.Volcano);

//! Print all volcano names alphabetically
IEnumerable<Eruption> volcanoNamesAlphabetical = eruptions.OrderBy(c => c.Volcano);
// foreach(Eruption e in volcanoNamesAlphabetical)
// {
//     Console.WriteLine(e.Volcano);
// }

//! Print sum of all elevations combined
int elevationSum = eruptions.Sum(c => c.ElevationInMeters);
// Console.WriteLine("The total sum of elevations is: " + elevationSum);

//! Print whether any volcano erupted in the year 2000
bool anyEruptionsIn2000 = eruptions.Any(c => c.Year == 2000);
// if (anyEruptionsIn2000)
// {
//     Console.WriteLine("Yes, an eruption occurred in 2000");
// } else {
//     Console.WriteLine("No eruptions occurred in 2000");
// }

//! Find all sratovolcanoes and print just first 3
IEnumerable<Eruption> firstThreeStrato = stratovolcanoEruptions.Take(3);
// PrintEach(firstThreeStrato, "First three stratovolcano eruptions");


//! Print all eruptions that occurred before 1000 CE alphabetically
IEnumerable<Eruption> eruptionsBefore1000 = eruptions.Where(c => c.Year < 1000).OrderBy(c => c.Volcano);
// PrintEach(eruptionsBefore1000, "Eruptions Before 1000 Alphabetically");

//! Last query but only select the volcano's names
IEnumerable<string> eruptionsBefore1000NamesOnly = eruptions.Where(c => c.Year < 1000).OrderBy(c => c.Volcano).Select(c => c.Volcano);
// foreach(string v in eruptionsBefore1000NamesOnly)
// {
//     Console.WriteLine(v);
// }

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
