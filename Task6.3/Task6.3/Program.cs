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

            Console.WriteLine("Введите позицию черной пешки");
            var blackPawnPosition = Console.ReadLine();

            if (!IsFiguresPositionsCorrect(whiteQueenPosition, blackPawnPosition))
            {
                Console.WriteLine("Позиции фигур не соответствуют условиям задачи");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите ход белого ферзя");
            var move = Console.ReadLine();

            if (IsQueenCanMakeSafeMove(whiteQueenPosition, blackPawnPosition, move))
                Console.WriteLine($"Ферзь {whiteQueenPosition} может безопасно пойти на клетку {move}");
            else
                Console.WriteLine($"Ферзь {whiteQueenPosition} не может пойти на клетку {move}");

            Console.ReadKey();
        }

        static bool IsFiguresPositionsCorrect(string queenPosition, string pawnPosition)
        {
            return !IsEqualPositions(queenPosition, pawnPosition) &&
                IsPawnPositionCorrect(pawnPosition) &&
                !IsQueenStrikesPawn(queenPosition, pawnPosition) &&
                !IsPawnStrikesQueen(queenPosition, pawnPosition);
        }

        static bool IsQueenCanMakeSafeMove(string queenPosition, string pawnPosition, string move)
        {
            return IsQueenCanMove(queenPosition, move) &&
                !IsPawnStrikesQueen(move, pawnPosition);
        }

        static bool IsEqualPositions(string position1, string position2)
        {
            return position1 == position2;
        }

        static bool IsPawnStrikesQueen(string queenPosition, string pawnPosition)
        {
            int qx, qy, px, py;

            (qy, qx) = GetCoordinates(queenPosition);
            (py, px) = GetCoordinates(pawnPosition);

            return py - qy == 1 && Math.Abs(px - qx) == 1;
        }

        static bool IsQueenStrikesPawn(string queenPosition, string pawnPosition)
        {
            return IsQueenCanMove(queenPosition, pawnPosition);
        }

        static bool IsPawnPositionCorrect(string pawnPosition)
        {
            int px, py;
            (py, px) = GetCoordinates(pawnPosition);

            return py > 0 && py < 7;
        }

        static bool IsQueenCanMove(string queenPosition, string move)
        {
            int qx, qy, mx, my;
            (qy, qx) = GetCoordinates(queenPosition);
            (my, mx) = GetCoordinates(move);

            return qy == my || qx == mx || Math.Abs(qy - my) == Math.Abs(qx - mx);
        }

        static (int, int) GetCoordinates(string position)
        {
            var row = (int)position[1] - 0x31;
            var column = (int)position[0] - 0x61;

            return (row, column);
        }
    }
}
