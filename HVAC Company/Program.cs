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
            double executed = int.Parse(Console.ReadLine());
            Console.WriteLine("project Monitoring completion percentage:");
            double monitored = int.Parse(Console.ReadLine());

            double[] arrayCom = new double[] {initiated, planned, executed, monitored };
            int len = arrayCom.Length;
            double sum = 0;
            double Average = 0;
            for (int i = 0; i < len; i++)
            {
                sum += arrayCom[i];
            }
            Average = sum / len;
            Console.WriteLine("project comletion percentage = " + Average);
            if(Average >= 95)
            {
                Console.WriteLine("Project Completed HandOver");
            }
            else
            {
                Console.WriteLine("project not completed");
            }


            
        }
    }
}
