public class Loops
{
  public static void Run()
  {
    // for (int counter = 0; counter < 5; counter++)
    // {
    //   Console.WriteLine(counter);
    // }

    var names = new List<string> { "Antonio", "Kevin", "Scotland" };

    names.Add("Will Succeed!");

    foreach (var name in names)
    {
      Console.WriteLine($"Hello {name.ToUpper()}");
    }


  }
}