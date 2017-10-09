using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _15Puzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int size = 4;
        private int[,] Game = new int[4, 4];
        private Button[] buttons;
        private Puzzle myPuzzle;

        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int n;
                    Int32.TryParse(buttons[(i * size + j)].Content.ToString(), out n); ;
                    Game[i, j] = n;
                }
            }

            myPuzzle = new Puzzle(Game);
            myPuzzle.NewGame();
            Game = myPuzzle.ReturnBoard();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Debug.Write(Game[i, j] + " ");
                }
                Debug.Write("\n");
            }
            RefreshButtons();
        }

        //Test
        public void DebugDraw()
        {
            Debug.Write("\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Debug.Write(Game[i, j] + " ");
                }
                Debug.Write("\n");
            }
        }

        public void RefreshButtons()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var button = buttons[i * 4 + j];
                    button.Content = Game[i, j];
                    button.Visibility = Game[i, j] == 0 ?
                        Visibility.Hidden : Visibility.Visible;
                }
            }
        }

        //Menu buttons
        private void Resetbtn_Click(object sender, RoutedEventArgs e)
        {
            if (myPuzzle.Solvability())
            {
                MessageBox.Show($"Puzzle is Solvable");
            }
            else
            {
                MessageBox.Show($"Puzzle is NOT Solvable");
            }
        }

        private void Randomizebtn_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.RandomizeBoard();
            Game = myPuzzle.ReturnBoard();
            DebugDraw();
            RefreshButtons();
        }

        private void Solvebtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In construction");
        }

        private void Helpbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The 15 puzzle\n\nTo play you first scramble the tiles and then try to put them back in order. To move a tile you simply click on it." +
                " The only tiles you can move are those adjacent to the blank tile.\n\nReset: Resets the puzzle to the initial position.\n" +
                "Randomize: This button randomly mixes the puzzle up.\nSolve: Automatically solves the puzzle. Huzzah!", "Help");
        }

        //Game Buttons
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[0].Content);
            RefreshButtons();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[1].Content);
            RefreshButtons();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[2].Content);
            RefreshButtons();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[3].Content);
            RefreshButtons();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[4].Content);
            RefreshButtons();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[5].Content);
            RefreshButtons();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[6].Content);
            RefreshButtons();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[7].Content);
            RefreshButtons();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[8].Content);
            RefreshButtons();
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[9].Content);
            RefreshButtons();
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[10].Content);
            RefreshButtons();
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[11].Content);
            RefreshButtons();
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[12].Content);
            RefreshButtons();
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[13].Content);
            RefreshButtons();
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[14].Content);
            RefreshButtons();
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.MoveTile((int)buttons[15].Content);
            RefreshButtons();
        }
    }
}