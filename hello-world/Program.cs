// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Antonio!");

string firstFriend = "   Antonio   ";
firstFriend = firstFriend.Trim();
string secondFriend = "Kevin";

string friends = $"My friends are {firstFriend} and {secondFriend}.";

Console.WriteLine(friends.Replace("Antonio", "John"));
Console.WriteLine(friends.Contains("Antonio"));
Console.WriteLine(friends.ToUpper());