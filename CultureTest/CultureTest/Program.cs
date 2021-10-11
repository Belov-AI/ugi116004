using System;
using System.Globalization;

namespace CultureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCulture(CultureInfo.CurrentCulture.Name);
            TestCulture("en-US");
            TestCulture("en-GB");
            TestCulture("fr-FR");
            TestCulture("es-ES");
            TestCulture("bg");
            TestCulture(CultureInfo.InvariantCulture.Name);
            TestCulture("");

            Console.ReadKey();
        }

        static void TestCulture(string cultureName)
        {
            var oldCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo(cultureName);

            Console.WriteLine($"{CultureInfo.CurrentCulture.Name} : {CultureInfo.CurrentCulture.DisplayName}");
            Console.WriteLine(2.5);

            var date = DateTime.Now;
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(new string('=', 30));

            CultureInfo.CurrentCulture = oldCulture;
        }
    }
}
