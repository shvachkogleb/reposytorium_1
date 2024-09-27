using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            List<string> firstlist = new List<string> { };
            while (a) {
                string m = Console.ReadLine();
                if (m == "-")
                {
                    a = false;
                }
                else {
                    firstlist.Add(m);
                }
            }
            firstlist.Sort();
            foreach (string name in firstlist)
            {
                Console.WriteLine(name);
            }
        }
    }
}
