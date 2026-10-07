namespace HRAdministrationAPI; // A namespace is a way to group and name related C# types. Think of it like a label or folder for code: HRAdministrationAPI.IEmployee means the IEmployee type inside the HRAdministrationAPI namespace.

//An abstract class is a shared starting point i.e. a base class. It says, “These things are part of the same family, and they share some information or behavior.”
public abstract class EmployeeBase : IEmployee
{
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public virtual decimal Salary { get; set; } //Virtual modifier gives Salary a default implementation that child classes may override. Where as abstract provides no implementation, so child classes must override it.
}