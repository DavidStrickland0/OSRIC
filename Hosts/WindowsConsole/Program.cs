using Base;

namespace WindowsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var running = true;
            var adventure = new Adventure();
            var start = adventure.Start();
            Console.WriteLine(start);
            while(running)
            {
                var requested = Console.ReadLine();
                var reaction = adventure.React(requested);
                Console.WriteLine(reaction);
            }
        }
    }
}
