namespace SEDC.Class07.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected double Salary { get; set; }

        public Roles Roles { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {GetSalary()}");
        }

        public double GetSalary()
        {
            double salary = 100;
            return salary;
        }

        public Employee(string firstName, string lastName, double salary, Roles role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Roles = role;
        }
    }
}
