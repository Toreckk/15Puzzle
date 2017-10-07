using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void NewGame()
        {
            //We fill the array
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Board[i, j] = (i * size + j);
                }
            }
            RandomizeBoard();

            //Then we use the Fisher-Yates algorithm to shuffle/Randomize the puzzle
        }

        public void RandomizeBoard()
        {
            do
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
            } while (Solvability() != true);
        }

        public bool Solvability()//Checks if board is solveable
        {
            bool Solvable = false;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Determining solvability:                                                                                                                                                            //
            // If the grid width is odd, then the number of inversions in a solvable situation is even.                                                                                            //
            // If the grid width is even, and the blank is on an even row counting from the bottom (second-last, fourth-last etc), then the number of inversions in a solvable situation is odd.   //
            // If the grid width is even, and the blank is on an odd row counting from the bottom (last, third-last, fifth-last etc) then the number of inversions in a solvable situation is even.//
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int[] TwoDtoArray = Board.Cast<int>().ToArray();//2D array to 1D array
            //Calculate number of inversions
            //An inversion is when a tile precedes another tile with a lower number on it.
            int Inversions = 0;

            for (int i = 0; i < TwoDtoArray.Length; i++)
            {
                for (int j = i; j < TwoDtoArray.Length; j++)
                {
                    if (TwoDtoArray[i] > TwoDtoArray[j] && TwoDtoArray[i] != 0 && TwoDtoArray[j] != 0)
                    {
                        Inversions++;
                    }
                }
            }
            int zeroPos = findZeroRow();
            if (size % 2 != 0)//odd width
            {
                if (Inversions % 2 == 0)
                    Solvable = true;
            }
            else if (size % 2 == 0)//even width
            {
                if ((size - zeroPos) % 2 == 0)//even row counting from the button
                {
                    if (Inversions % 2 != 0)
                        Solvable = true;
                }
                else//odd row counting from the button
                {
                    if (Inversions % 2 == 0)
                        Solvable = true;
                }
            }

            return Solvable;
        }

        public int findzero()
        {
            return 0;
        }

        public int findZeroRow()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Board[i, j] == 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}