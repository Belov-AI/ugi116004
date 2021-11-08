using System;


namespace Chessboard
{
    class Program
    {
        static void Main()
        {
            int boardSize;

            //Здесь ввод размера доски.
            //оформите его в виде бесконечного цикла с проверкой,
            //что 1<= boardSize <= 26
            //и предложением повторного ввода, если условие не выполняется
            //Предусмотрите отказ от ввода (с последующим завершением программы).

            while (true)
            {
                Console.WriteLine("Введите размер доски (Enter - выход)");
                var input = Console.ReadLine();

                if (input == "")
                    return;

                if(!int.TryParse(input, out boardSize))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if (boardSize > 26 || boardSize < 1)
                {
                    Console.WriteLine("Размер доски должен быть от 1 до 26\n");
                    continue;
                }
               
                break;
            }
            
            PrintBoard(boardSize);           

            Console.ReadKey();
        }

        static void PrintBoard(int size)
        {
            const ConsoleColor DarkColor = ConsoleColor.DarkBlue;
            const ConsoleColor LightColor = ConsoleColor.Gray;
            //написать метод печати шахматной доски размера (size x size)
            PrintColumnNames(size);
            var horizontal = new string((char)0x2500, size);
            Console.WriteLine("  " + (char)0x250C + horizontal + (char)0x2510);

            for (var i = 0; i < size; i++)
            {
                var rowNumber = size - i;
                Console.Write($"{rowNumber,2}" + (char)0x2502);

                for (var j = 0; j < size; j++)
                    if ((rowNumber + j) % 2 == 0)
                        PrintSquare(LightColor);
                    else
                        PrintSquare(DarkColor);

                Console.WriteLine("" + (char)0x2502 + rowNumber);
            }

            Console.WriteLine("  " + (char)0x2514 + horizontal + (char)0x2518);
            PrintColumnNames(size);
        }

        static void PrintColumnNames(int size)
        {
            Console.Write("   ");

            for (var i = 0; i < size; i++)
                Console.Write((char)(0x61 + i));

            Console.WriteLine();
        }

        /// <summary>
        /// Печать квадрата нужного цвета
        /// </summary>
        /// <param name="color">Цвет квадрата</param>
        static void PrintSquare(ConsoleColor color)
        {
            const char square = (char)0x2588;

            Console.ForegroundColor = color;
            Console.Write(square);
            Console.ResetColor();
        }
    }
}
