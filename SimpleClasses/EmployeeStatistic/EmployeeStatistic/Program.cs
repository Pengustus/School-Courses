namespace EmployeeStatistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employees> employees = new List<Employees>();
            Dictionary<string, List<Employees>> departments = new Dictionary<string, List<Employees>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];

                employees.Add(new Employees(name, salary, department));

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<Employees>();
                }
                departments[department].Add(new Employees(name, salary, department));
            }

            string topDepartment = " ";
            double highestAverage = 0;

            foreach (var dept in departments)
            {
                double totalSalary = 0;

                foreach (var emp in dept.Value)
                {
                    totalSalary += emp.Salary;
                }

                double averageSalary = totalSalary / dept.Value.Count;

                if (averageSalary > highestAverage)
                {
                    highestAverage = averageSalary;
                    topDepartment = dept.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {topDepartment}");
            
            foreach (var emp in departments[topDepartment].OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:F2}");
            }
        }
    }

    public class Employees
    {
        private string name;
        private double salary;
        private string department;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public Employees(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
    }
}