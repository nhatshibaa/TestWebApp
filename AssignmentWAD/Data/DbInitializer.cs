using AssignmentWAD.Models;
using System.Linq;

namespace AssignmentWAD.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
            new Employee{EmployeeID="EM001",EmployeeName="John Carter",Department="HR",Salary=3000},
            new Employee{EmployeeID="EM002",EmployeeName="Micheal Bean",Department="SC",Salary=1300},
            new Employee{EmployeeID="EM003",EmployeeName="Jimmy Floy",Department="MD",Salary=2000},
            new Employee{EmployeeID="EM004",EmployeeName="Mary Browe",Department="MD",Salary=2000},

            };
            foreach (Employee s in employees)
            {
                context.Employee.Add(s);
            }
            context.SaveChanges();


        }
    }
}
