using System;
using System.Linq;

namespace EfApp.WithUIConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EducationConnectionStr context = new EducationConnectionStr();
            var groups = context.Groups.ToList();

            Console.WriteLine("Gruplar");
            foreach (var group in groups)
            {
                Console.WriteLine(group.Name);
            }
        }
    }
}
