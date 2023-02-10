using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
        static void Main(string[] args)
        {
            int player = 1;
            int input = 0;
            bool win = false;

            do
            {
                //player 1
                player = 1;
                PrintBoard();
                input = GetField(player);
                MarkField(player, input);
                Console.Clear();
                //check if win
                //player 1
                player = 2;
                PrintBoard();
                input = GetField(player);
                MarkField(player, input);
                Console.Clear();
                //check if win
            } while (!win);


            

            Console.Read();

        }

        public static void WinCheck(int player)
        {
            char playerSign = player == 1 ? 'x' : 'o';

            if ( ((playField[0, 0]== playerSign)&& (playField[0, 1] == playerSign)&& (playField[0, 2] == playerSign)) ||
                ((playField[1, 0] == playerSign) && (playField[1, 1] == playerSign) && (playField[1, 2] == playerSign)) ||
                ((playField[2, 0] == playerSign) && (playField[2, 1] == playerSign) && (playField[2, 2] == playerSign)) ||
                ((playField[0, 0] == playerSign) && (playField[0, 1] == playerSign) && (playField[0, 2] == playerSign)) ||
                )
            {

            }


        }
        public static void PrintBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ",playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
        }

        public static void MarkField(int player,int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'x';
            else
                playerSign = 'o';

            switch (input)
            {
                case 1:
                    playField[0,0] = playerSign;
                    break;
                case 2:
                    playField[0, 1] = playerSign;
                    break;
                case 3:
                    playField[0, 2] = playerSign;
                    break;
                case 4:
                    playField[1, 0] = playerSign;
                    break;
                case 5:
                    playField[1, 1] = playerSign;
                    break;
                case 6:
                    playField[1, 2] = playerSign;
                    break;
                case 7:
                    playField[2, 0] = playerSign;
                    break;
                case 8:
                    playField[2, 1] = playerSign;
                    break;
                case 9:
                    playField[2, 2] = playerSign;
                    break;
            }

        }

        public static int GetField(int player)
        {
            bool isCorrect = false;
            int returnInt = 0;

            do
            {
                Console.WriteLine("Player{0}: Select field..", player);
                //check if it is number
                isCorrect = int.TryParse(Console.ReadLine(), out returnInt);

                if (isCorrect)
                {
                    //check if its between 1 and 9
                    isCorrect = (returnInt > 0 && returnInt <= 9);

                    //check if field has been marked
                    switch (returnInt)
                    {
                        case 1:
                            isCorrect = playField[0, 0] == '1';
                            break;
                        case 2:
                            isCorrect = playField[0, 1] == '2';
                            break;
                        case 3:
                            isCorrect = playField[0, 2] == '3';
                            break;
                        case 4:
                            isCorrect = playField[1, 0] == '4';
                            break;
                        case 5:
                            isCorrect = playField[1, 1] == '5';
                            break;
                        case 6:
                            isCorrect = playField[1, 2] == '6';
                            break;
                        case 7:
                            isCorrect = playField[2, 0] == '7';
                            break;
                        case 8:
                            isCorrect = playField[2, 1] == '8';
                            break;
                        case 9:
                            isCorrect = playField[2, 2] == '9';
                            break;
                    }
                }

                if (isCorrect==false)
                    Console.WriteLine("Player{0}: Invalid input. Try again..");
                    




            } while (!isCorrect);

            return returnInt;
        }
    }
}
