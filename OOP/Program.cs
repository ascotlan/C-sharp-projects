var p1 = new Person("John", "Doe", new DateOnly(1987, 1, 20));
var p2 = new Person("Antonio", "Scotland", new DateOnly(1983, 12, 20));

p1.Pets.Add(new Dog("Fido"));
p1.Pets.Add(new Dog("Joey"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person> people = [p1, p2];

foreach (var person in people)
{
  foreach (var pet in person.Pets)
  {
    Console.WriteLine(person);
    Console.WriteLine(pet);
  }
}

public class Person(string firstName, string lastName, DateOnly birthday)
{
  public string First { get; } = firstName;
  public string Last { get; } = lastName;
  public DateOnly Birthday { get; } = birthday;
  public List<Pet> Pets { get; } = new();

  //how the object name should be printed
  public override string ToString()
  {
    return $"Human {First} {Last}";
  }
}

public abstract class Pet(string firstName)
{
  public string First { get; } = firstName;
  public abstract string makeNoise();

  //how the object name should be printed
  public override string ToString()
  {
    return $"{First} and it's a {GetType().Name} and it {makeNoise()}";
  }
}

public class Cat(string firstName) : Pet(firstName)
{
  public override string makeNoise() => "meows";
}

public class Dog(string firstName) : Pet(firstName)
{
  public override string makeNoise() => "barks";
}
