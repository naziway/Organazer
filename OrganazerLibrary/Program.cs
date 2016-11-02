using System;

namespace OrganazerLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbContract contract = new DbContract();
            foreach (var allTaska in contract.GetAllTaskas())
            {
                Console.WriteLine(allTaska.ToString());
            }

            Console.ReadKey();

        }
    }
}