

List<string> videoGameNameLength = new List<string>() { "Call of Duty", "Pokemon", "Grand Theft Auto", "Apex", "Fortnite" };
videoGameNameLength.Add("Fifa");
videoGameNameLength.Add("Tomb Raider");


var orderedVideoGameNameLength = videoGameNameLength.OrderBy(name => name.Length);


foreach (var videoGameName in orderedVideoGameNameLength)
{
Console.WriteLine(videoGameName); 
}

//var orderedVideoGameNameLength = videoGameNameLength.Where(name => name.Length > 5)
// .OrderBy(name => name.Length)
// .ThenBy(name => name);

//foreach (var videoGameName in orderedVideoGameNameLength)
//{
//Console.WriteLine(videoGameName);
//}

//var orderedVideoGameNameLength = videoGameNameLength.Select(name => name.Length)
//.OrderBy(length => length);

//foreach (var length in orderedVideoGameNameLength)
//{
//Console.WriteLine(length);
//}

//var orderedVideoGameNameLength = videoGameNameLength.Sum(name => name.Length);
//Console.WriteLine(orderedVideoGameNameLength);

//foreach (var videoGameName in videoGameNameLength)



