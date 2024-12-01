namespace AverageWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee first = new Employee();
            Employee second = new Employee();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            first.name = Console.ReadLine();
            Console.Write("Salário: ");
            first.salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            second.name = Console.ReadLine();
            Console.Write("Salário: ");
            second.salary = double.Parse(Console.ReadLine());

            double average = (first.salary + second.salary)/2;
            Console.WriteLine("Média salarial: " + average);
        }
    }
}
