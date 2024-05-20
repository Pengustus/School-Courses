namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employees> employees = new List<Employees>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = input[0];
                string lastName = input[1];
                double salary = double.Parse(input[2]);

                employees.Add(new Employees(firstName, lastName, salary));
            }

            foreach (var employee in employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Salary:F2}");
            }
        }
    }

    public class Employees
    {
        private string firstName;
        private string lastName;
        private double salary;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public Employees(string firstName, string lastName, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }
    }
}