using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //laukums, divdimensiju masivs, 3x3 
            FieldEnum[,] board = GetEmptyBoard();
            FieldEnum currentPlayer = FieldEnum.X;
            bool isGameFinished = false;
            //drukāsim laukumu 
            Console.WriteLine("Game begins, it's X turn!");
            PrintBoard(board);
            //Katrā cikla iterācijā kāds spēlētājs veic gājienu  
            do
            {
                Console.WriteLine();
                Console.Write("Please enter row number:");
                string row = Console.ReadLine();
                Console.Write("Please enter column number:");
                string col = Console.ReadLine();
                //Ierakstot STOP rindas vai kolonas ievadē, programma/cikls apstājas 
                if (row == "STOP" || col == "STOP")
                {
                    break;
                }
                //Vai ievadītās vērtības nav tukšas. Ja ir, tad kļūda un cikls no jauna 
                if (string.IsNullOrEmpty(row) || string.IsNullOrEmpty(col))
                {
                    Console.WriteLine("Please enter non-empty value!");
                    continue;
                }
                //Mēģinām pārveidot ievadītās vērtības par rindas un kolonas skaitļiem 
                int rowNum;
                int colNum;
                bool rowSuccess = int.TryParse(row, out rowNum);
                bool colSuccess = int.TryParse(col, out colNum);
                //Pārbaudām, vai kādu ievadīto nevarēja pārveidot par skaitli 
                if (!rowSuccess || !colSuccess)
                {
                    Console.WriteLine("Please enter number type values!");
                    continue;
                }
                //Ievadītās laukuma koordinātas nevar būt ārpus diapazona 1-3 
                if (rowNum < 1 || rowNum > 3 || colNum < 1 || colNum > 3)
                {
                    Console.WriteLine("Please enter number values in range 1-3!");
                    continue;
                }
                //Nevar veikt gājienu ne-tukšā lauciņā  
                if (board[rowNum - 1, colNum - 1] != FieldEnum.Empty)
                {
                    Console.WriteLine("Please make a move in an empty space!");
                    continue;
                }
                board[rowNum - 1, colNum - 1] = currentPlayer;
                PrintBoard(board);
                currentPlayer = currentPlayer == FieldEnum.X ? FieldEnum.O : FieldEnum.X;
                isGameFinished = GameFinished(board);
            } while (!isGameFinished);
        }

        private static bool GameFinished(FieldEnum[,] board)
        {
            for(int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] != FieldEnum.Empty &&
                    board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    Console.WriteLine($"Spēlētājs {board[i, 0]} ir uzvarētājs!");
                    return true;
                }
            }

            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] != FieldEnum.Empty &&
                    board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    Console.WriteLine($"Spēlētājs {board[0, i]} ir uzvarētājs!");
                    return true;
                }
            }
                if (board[0, 0] != FieldEnum.Empty && board[0, 0] == board[1, 1] &&
                    board[1, 1] == board[2, 2])
                {
                    Console.WriteLine($"Spēlētājs {board[0, 0]} ir uzvarētājs!");
                    return true;
                }
                else if (board[2, 0] != FieldEnum.Empty && board[2, 0] == board[1, 1] &&
                    board[1, 1] == board[0, 2])
                {
                Console.WriteLine($"Spēlētājs {board[2, 0]} ir uzvarētājs!");
                return true;
                }

                for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i,j] == FieldEnum.Empty)
                    {
                        return false;
                    }
                }
            }

            Console.WriteLine("Neizšķirts!");
            return true;
        }
        private static void PrintBoard(FieldEnum[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    switch (board[i, j])
                    {
                        case FieldEnum.O:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("O ");
                            break;
                        case FieldEnum.X:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("X ");
                            break;
                        case FieldEnum.Empty:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("_ "); break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private static FieldEnum[,] GetEmptyBoard()
        {
            FieldEnum[,] board = new FieldEnum[3, 3];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = FieldEnum.Empty;
                }
            }
            return board;
        }
    }
}

