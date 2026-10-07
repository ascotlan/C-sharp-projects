public class DataStructures
{
  public static void Run()
  {
    //var names = new List<string> { "Scott", "Ana", "Felipe" };

    // names.Add("Antonio"); //method for Lists
    // names.Add("Kevin");
    // names.Add("Duvern");

    var names = new string[] { "Scott", "Ana", "Felipe" };

    names = [.. names, "Antonio"];

    foreach (var name in names)
    {
      Console.WriteLine($"Hello {name.ToUpper()}");
    }

    Console.WriteLine(names[0]);
    Console.WriteLine(names[^2]);
  }
}