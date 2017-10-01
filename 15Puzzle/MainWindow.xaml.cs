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
        private int[,] Game = new int[4, 4];
        private Button[] buttons;
        private Puzzle myPuzzle;

        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int n;
                    Int32.TryParse(buttons[(i * 4 + j)].Content.ToString(), out n); ;
                    Game[i, j] = n;
                }
            }

            myPuzzle = new Puzzle(Game);
            myPuzzle.NewGame();
            Game = myPuzzle.ReturnBoard();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
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
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Debug.Write(Game[i, j] + " ");
                }
                Debug.Write("\n");
            }
        }

        public void RefreshButtons()
        {
            int n = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //if (buttons[(i * 4 + j)].Content.ToString() == n.ToString())
                    //{
                    //    buttons[(i * 4 + j)].Visibility = Visibility.Hidden;
                    //}
                    //else
                    //{
                    buttons[(i * 4 + j)].Content = Game[i, j].ToString();
                    // }
                }
            }
        }

        //Menu buttons
        private void Resetbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In construction");
        }

        private void Randomizebtn_Click(object sender, RoutedEventArgs e)
        {
            myPuzzle.RandomizeBoard();
            Game = myPuzzle.ReturnBoard();
            DebugDraw();
            RefreshButtons();
        }

        private void solvebtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In construction");
        }

        private void Helpbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The 15 puzzle\n\nTo play you first scramble the tiles and then try to put them back in order. To move a tile you simply click on it." +
                " The only tiles you can move are those adjacent to the hole.\n\nReset: Resets the puzzle to the initial position.\n" +
                "Randomize: This button randomly mixes the puzzle up.\nSolve: Automatically solves the puzzle. Huzzah!", "Help");
        }

        //Game Buttons
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}