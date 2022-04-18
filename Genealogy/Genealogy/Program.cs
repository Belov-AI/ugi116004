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

                int result;

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
            var first = GetPerson("Введите имя первого человека");

            if(first != "")
            {
                var second = GetPerson("Введите имя второго человека");

                if(second != "")
                {
                    var firstAncestors = GetAncestors(first);
                    var secondAncestors = GetAncestors(second);

                    if (firstAncestors.Contains(second))
                        Console.WriteLine($"{second} - предок, {first} - потомок\n");
                    else if (secondAncestors.Contains(first))
                        Console.WriteLine($"{first} - предок, {second} - потомок\n");
                    else
                        foreach(var person in firstAncestors)
                            if (secondAncestors.Contains(person))
                            {
                                Console.WriteLine($"{person} - ближайший общий предок\n");
                                break;
                            }
                }
            }          
        }

        static void PrintChildren()
        {
            var person = GetPerson("Введите имя");
            
            if(person != "")
            {
                var children = new List<string>();

                foreach (var child in tree.Keys)
                    if (tree[child] == person)
                        children.Add(child);

                if (children.Count == 0)
                    Console.WriteLine("Детей нет\n");
                else
                {
                    Console.WriteLine("Дети:");

                    foreach (var child in children)
                        Console.WriteLine(child);

                    Console.WriteLine();
                }                   
            }
        }

        static List<string> GetAncestors(string person)
        {
            var result = new List<string>();

            while (tree.ContainsKey(person))
            {
                person = tree[person];
                result.Add(person);
            }

            return result;
        }

        static bool IsCorrectPerson(string name)
        {
            return tree.ContainsKey(name) || tree.ContainsValue(name);
        }

        static string GetPerson(string message)
        {
            string name;

            while (true)
            {
                Console.WriteLine(message);
                name = Console.ReadLine();

                if (name != "" && !IsCorrectPerson(name))
                {
                    Console.WriteLine($"Персонажа {name} нет");
                    continue;
                }

                return name;
            }
        }
    }
}
