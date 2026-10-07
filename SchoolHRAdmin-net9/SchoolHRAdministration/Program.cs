using HRAdministrationAPI; // Lets this file use types, such as IEmployee and EmployeeBase, from the HRAdministrationAPI project.

// Groups this program and its classes under the SchoolHRAdministration namespace.
namespace SchoolHRAdministration;

class Program
{
    // The program starts running here.
    static void Main(string[] args)
    {
        // decimal is commonly used for money because it represents decimal amounts accurately.
        /* decimal totalSalaries = 0;  */
        // This list can hold any object whose class implements IEmployee.
        List<IEmployee> employees = new List<IEmployee>();

        // Fill the list with sample employees.
        SeedData(employees);

        // Read each employee's Salary and add it to the running total.
        // Each role overrides Salary, so the role-specific percentage is included here.
        /* foreach (IEmployee employee in employees)
         {
             totalSalaries += employee.Salary;
         } */



        // Display the combined salaries, including each role's added percentage.
        /* Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}"); */

        // LINQ's Sum goes through the list and adds the Salary value from each employee.
        // In (e) => e.Salary, "e" means the current employee; the arrow means "use its Salary".
        // Because Salary is overridden by each role, this adds each role's adjusted salary.
        Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(e => e.Salary)}");

        // Wait for a key press so the console window stays open.
        Console.ReadKey();
    }

    // Adds sample employees to the list supplied by Main.
    // Since the list uses the IEmployee interface, it can contain different employee role classes.
    public static void SeedData(List<IEmployee> employees)
    {
        // Create a Teacher and use an object initializer to set its employee properties.
        // Teacher inherits those properties from EmployeeBase.
        IEmployee teacher1 = new Teacher
        {
            Id = 1,
            FirstName = "Bob",
            LastName = "Fisher",
            Salary = 40000 // This is the base salary; Teacher adds its percentage when Salary is read.
        };

        // Add the teacher to the list passed into this method.
        employees.Add(teacher1);

        // Create a second, separate Teacher object with its own employee details.
        IEmployee teacher2 = new Teacher
        {
            Id = 2,
            FirstName = "Jenny",
            LastName = "Thomas",
            Salary = 40000
        };

        // Add the second teacher to the same list.
        employees.Add(teacher2);

        // The same IEmployee list can hold a different role, not just teachers.
        IEmployee headOfDepartment = new HeadOfDepartment
        {
            Id = 3,
            FirstName = "Brenda",
            LastName = "Mullins",
            Salary = 50000
        };

        employees.Add(headOfDepartment);

        // Create a deputy headmaster; its Salary property adds that role's percentage when read.
        IEmployee deputyHeadMaster = new DeputyHeadMaster
        {
            Id = 4,
            FirstName = "Delvin",
            LastName = "Brown",
            Salary = 60000
        };

        employees.Add(deputyHeadMaster);

        // Create a headmaster; its Salary property also calculates a role-specific increase.
        IEmployee headMaster = new HeadMaster
        {
            Id = 5,
            FirstName = "Damien",
            LastName = "Jones",
            Salary = 80000
        };

        employees.Add(headMaster);
    }

}

// A Teacher is an EmployeeBase, so it gets the shared employee properties.
// Its overridden Salary getter returns the base salary plus 2%.
public class Teacher : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
}

// A department head reuses the shared employee properties and adds 3% when Salary is read.
public class HeadOfDepartment : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
}

// A deputy headmaster reuses the shared employee properties and adds 4% when Salary is read.
public class DeputyHeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
}

// A headmaster reuses the shared employee properties and adds 5% when Salary is read.
public class HeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
}
