public class SortingSearching
{
  public static void Run()
  {
    var nums = new List<int> { 45, 56, 99, 48, 67, 78 };

    Console.WriteLine($"I found 99 at index {nums.IndexOf(99)}"); //search for an index of an element
    nums.Sort(); //sort
    Console.WriteLine($"I found 99 at index {nums.IndexOf(99)}"); //search for an index of an element


    // foreach (var item in nums)
    // {
    //   Console.WriteLine(item);
    // }
  }
}