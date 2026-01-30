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
            Console.WriteLine("\n");
        }
    }
}
