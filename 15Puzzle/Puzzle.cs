using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Puzzle
{
    internal class Puzzle
    {
        public int size = 4;
        public int[,] Board = new int[4, 4];

        public Puzzle(int[,] InitialBoard)
        {
            Board = InitialBoard;
        }

        public int[,] ReturnBoard()
        {
            return Board;
        }

        public void NewGame()//Creates a random board state
        {
            //We fill the array
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Board[i, j] = (i * size + j);
                }
            }
            //Then we use the Fisher-Yates algorithm to shuffle/Randomize the puzzle
            RandomizeBoard();
        }

        public void RandomizeBoard()
        {
            Random rnd = new Random();

            for (int i = size - 1; i > 0; i--)
            {
                for (int j = size - 1; j > 0; j--)
                {
                    int k = rnd.Next(i + 1);
                    int n = rnd.Next(j + 1);

                    int aux = Board[i, j];
                    Board[i, j] = Board[k, n];
                    Board[k, n] = aux;
                }
            }
        }

        public void Solveability()//Checks if board is solveable
        {
        }
    }
}