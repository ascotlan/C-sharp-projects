namespace HRAdministrationAPI; // A namespace is a way to group and name related C# types. Think of it like a label or folder for code: HRAdministrationAPI.IEmployee means the IEmployee type inside the HRAdministrationAPI namespace.

//An interface is a promise about something a type e.g. a class, struct, int, List<string>, etc can do. It says, “Anything that implements this must provide this ability.”
public interface IEmployee
{
  int Id { get; set; }
  string FirstName { get; set; }
  string LastName { get; set; }
  decimal Salary { get; set; }
}


/*
A code API is a set of types and members other code can use. IEmployee and EmployeeBase are part of a code API: they define an employee contract and a reusable base class.
*/