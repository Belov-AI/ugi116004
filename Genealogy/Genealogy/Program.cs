using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Genealogy
{
    class Program
    {
        static Dictionary<string, string> tree = new Dictionary<string, string>();

        static void Main()
        {
            Initialize();

            if (tree.Count == 0) return;

            while (true)
            {
                Console.WriteLine("Выберите опцию:");
                Console.WriteLine("1 - основатель рода");
                Console.WriteLine("2 - ближайший общий предок");
                Console.WriteLine("3 - дети");
                Console.WriteLine("0 - выход");

                int result = 0;

                if (!int.TryParse(Console.ReadLine(), out result) ||
                    result > 3 || result < 0)
                {
                    Console.WriteLine("Введите одну из перечисленных опций");
                    continue;
                }

                switch (result)
                {
                    case 1:
                        PrintFoundator();
                        break;
                    case 2:
                        PrintCommonAncestor();
                        break;
                    case 3:
                        PrintChildren();
                        break;
                    default:
                        return;
                }
            }
        }

        static void Initialize()
        {
            string filename;

            while (true)
            {
                Console.WriteLine("Введите имя файла");

                filename = Console.ReadLine();

                if (filename == string.Empty) return;

                if (File.Exists(filename))
                    break;
                else
                    Console.WriteLine("Такого файла нет.\n");
            }

            using(var file = new StreamReader(filename, Encoding.Default))
            {
                while (!file.EndOfStream)
                {
                    string[] record = file.ReadLine().Split('-');
                    tree[record[1].Trim()] = record[0].Trim();
                }
            }
        }

        static void PrintFoundator()
        {
            foreach(var person in tree.Values)
                if (!tree.ContainsKey(person))
                {
                    Console.WriteLine($"Основатель рода - {person}\n");
                    return;
                }                    
        }

        static void PrintCommonAncestor()
        {
            throw new NotImplementedException();
        }

        static void PrintChildren()
        {
            throw new NotImplementedException();
        }
    }
}
