public class LINQ
{
  public static void Run()
  {
    // Specify the data source.
    int[] scores = [97, 92, 81, 60];

    // Define the query expression.
    // IEnumerable<int> scoreQuery =
    //     from score in scores
    //     where score > 80
    //     orderby score ascending
    //     select score;

    var scoreQuery = scores.Where((s) => s > 80).OrderBy(s => s);

    IEnumerable<string> highScoresQuery2 =  //query variable
    from score in scores //required
    where score > 80 // optional
    orderby score descending // optional
    select $"The score is {score}"; //must end with select or group

    // Execute the query to produce the results
    foreach (var i in highScoresQuery2)
    {
      Console.WriteLine(i);
    }



    List<int> myScores = scoreQuery.ToList();

    foreach (var score in myScores)
    {
      Console.WriteLine(score);
    }


  }
}