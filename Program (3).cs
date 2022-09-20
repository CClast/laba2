namespace EmployeeProject
{
    class Employee
    {
        public string FirstName;
        public string LastName;

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public double GetSalary(int experience, string position)
        {
            if (experience > 10)
                experience = 10;
            if (position == "Jun")
            {
                if (experience > 2)
                    experience = 2;
                return 30000.0 * experience / 2;
            }
            if (position == "Mid")
            {
                if (experience > 5)
                    experience = 5;
                return 70000.0 * experience / 5;
            }
            if (experience > 10)
                experience = 10;
            return 230000.0 * experience / 10;
        }

        public double GetTax(int experience, string position)
        {
            return GetSalary(experience, position) * 0.05;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Oleg", "Bondarenko");
            Console.WriteLine(employee.FirstName + " " + employee.LastName);
            Console.WriteLine("Salary: " + employee.GetSalary(4, "Sen"));
            Console.WriteLine("   Tax: " + employee.GetTax(4, "Sen"));
        }
    }
}
