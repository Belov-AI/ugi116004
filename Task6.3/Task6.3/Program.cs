using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._3
{
    class Program
    {
        // Белый ферзь и черная пешка
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого ферзя");
            var whiteQueenPosition = Console.ReadLine();

            //int queenX, queenY;
            //GetCoordinates(whiteQueenPosition, out queenY, out queenX);
            //Console.WriteLine($"{queenX} {queenY}");

            Console.WriteLine("Введите позицию черной пешки");
            var blackPawnPosition = Console.ReadLine();

            Console.WriteLine(IsPawnStrikesQueen(whiteQueenPosition, blackPawnPosition));

            Console.ReadKey();
        }

        static void GetCoordinates(string position, out int row, out int column)
        {
            column = (int)position[1] - 0x31;
            row = (int)position[0] - 0x61;
        }

        static bool IsEqualPositions(string position1, string position2)
        {
            return position1 == position2;
        }

        static bool IsPawnStrikesQueen(string queenPosition, string pawnPosition)
        {
            int qx, qy, px, py;

            GetCoordinates(queenPosition, out qy, out qx);
            GetCoordinates(pawnPosition, out py, out px);

            return py - qy == 1 && Math.Abs(px - qx) == 1;
        }
    }
}
