using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortName
{
    class Program
    {
        static void Main(string[] args)
        {
            var poets = new[] 
            {
                "Александр Сергеевич Пушкин",
                "Михайил Юрьевич Лермонтов",
                "Александр Блок",
                "Андрей  Вознесенский",
                "Борис Владимирович 3аходер"
            };

            foreach (var name in poets)
                Console.WriteLine(ShortName(name));

            Console.ReadKey();
        }

        static string ShortName(string fullName)
        {
            var names = fullName.Split();

            try
            {
                return $"{names[0][0]}. {names[1][0]}. {names[2]}";
            }

            catch
            {
                Console.Write($"\"{fullName}\" - строка должна содержать имя, отчество и фамилию через пробел!");
                return "";
            }
        }
    }
}
