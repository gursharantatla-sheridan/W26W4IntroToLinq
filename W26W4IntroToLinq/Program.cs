using ConsoleTables;

namespace W26W4IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 4, 3, 6, 7, 8, 5, 6, 7, 9, 3, 1 };

            // query syntax
            var greaterThan4 = from n in array
                               where n > 4
                               orderby n
                               select n;

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n");


            // method syntax
            var greaterThan5 = array.Where(n => n > 5).OrderBy(n => n);


            foreach (var i in greaterThan5)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");



            List<string> colors = new List<string>();
            colors.Add("BluE");
            colors.Add("RuBy");
            colors.Add("grEEn");
            colors.Add("rEd");

            var startsWithR = from c in colors
                              let uppercaseColors = c.ToUpper()
                              where uppercaseColors.StartsWith("R")
                              orderby uppercaseColors
                              select uppercaseColors;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n");


            colors.Add("RuSt");
            colors.Add("YeLLow");

            // deferred execution
            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n\n");




            List<Employee> employees = new List<Employee>()
            {
                new Employee("James", "White", 4000),
                new Employee("Anne", "Indigo", 5000),
                new Employee("Bob", "Greene", 3000),
                new Employee("James", "Indigo", 6000),
                new Employee("Alice", "Indigo", 5500),
                new Employee("Sam", "Brown", 7000)
            };

            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var emp in between4k6k)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var sortedEmps = from e in employees
                             orderby e.LastName, e.FirstName
                             select e;

            foreach (var emp in sortedEmps)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var lastnames = from e in employees
                            select e.LastName;

            foreach (var emp in lastnames.Distinct())
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var empNames = from e in employees
                           select new { e.FirstName, e.LastName };

            foreach (var emp in empNames)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");



            // ConsoleTables example
            ConsoleTable tbl = new ConsoleTable("First Name", "Last Name", "Salary");

            foreach (var e in employees)
            {
                tbl.AddRow(e.FirstName, e.LastName, e.Salary.ToString("C"));
            }

            tbl.Write(Format.MarkDown);
            Console.WriteLine();
        }
    }
}
