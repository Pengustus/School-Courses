namespace StudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());
        
            Sentence(name, grade);
        }

        static void Sentence(string name, int grade) =>
            Console.WriteLine($"{name} is studying in {grade} grade");
    }
}