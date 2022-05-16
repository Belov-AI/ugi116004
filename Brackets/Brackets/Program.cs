using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static Dictionary<char, char> dict;

        static void Main(string[] args)
        {
            var brackets = "()[]{}<>";
            dict = new Dictionary<char, char>();
            for (var i = 1; i < brackets.Length; i += 2)
                dict[brackets[i]] = brackets[i - 1];

            while (true)
            {
                Console.WriteLine("Введите выражение со скобками");
                var expr = Console.ReadLine();

                if (expr.Length == 0)
                    break;

                if (CheckExpression(expr))
                    Console.WriteLine("Скобки расставлены верно.\n");
                else
                    Console.WriteLine("Скобки расставлены неверно.\n");
            }

        }

        static bool CheckExpression(string expression)
        {
            var stack = new Stack<char>();

            foreach (var ch in expression)
                if (dict.ContainsValue(ch))
                    stack.Push(ch);
                else if (dict.ContainsKey(ch) &&
                    (stack.Count == 0 || stack.Pop() != dict[ch]))
                    return false;

            return stack.Count == 0;
        }
    }
}
