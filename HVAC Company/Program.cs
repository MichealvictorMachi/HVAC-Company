namespace HVAC_Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectCompletionRate projectCompletionRate = new ProjectCompletionRate();
            Console.WriteLine("project intiation completion percentage:");
            double initiated = int.Parse(Console.ReadLine());
            Console.WriteLine("project Planning completion percentage:");
            double planned = int.Parse(Console.ReadLine());
            Console.WriteLine("project Execution completion percentage:");
            double Executed = int.Parse(Console.ReadLine());
            Console.WriteLine("project Momitoring completion percentage:");
            double monitored = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Project Completed HandOver");
        }
    }
}