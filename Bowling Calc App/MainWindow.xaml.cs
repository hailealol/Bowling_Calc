using System;
using System.Collections.Generic;
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

namespace Bowling_Calc_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double gameOne = 0;
        double gameTwo = 0;
        double gameThree = 0;
        double total = 0;
        double average = 0;
        double handicap = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            FindSeries();
            FindAverage();
            DisplayHandicap();
            FindHighGame();
        }

        public void FindSeries()
        {
            Double.TryParse(game_one.Text, out gameOne);
            Double.TryParse(game_two.Text, out gameTwo);
            Double.TryParse(game_three.Text, out gameThree);

            total = gameOne + gameTwo + gameThree;

            SeriesTotal.Text = total.ToString();
        }

        public void FindAverage()
        {
            average = total / 3;

            Average.Text = average.ToString();
        }

        public void DisplayHandicap()
        {
            handicap = (200 - average) * .8;

            Handicap.Text = handicap.ToString();
        }

        public void FindHighGame()
        {
            Double.TryParse(game_one.Text, out gameOne);
            Double.TryParse(game_two.Text, out gameTwo);
            Double.TryParse(game_three.Text, out gameThree);

            if (gameOne > gameTwo && gameOne > gameThree)
            {
                Results.Text = "1";
            } else if (gameTwo > gameOne && gameTwo > gameThree)
            {
                Results.Text = "2";
            } else if (gameThree > gameOne && gameThree > gameTwo)
            {
                Results.Text = "3";
            } else
            {
                Results.Text = "Tie";
            };
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            gameOne = 0;
            gameTwo = 0;
            gameThree = 0;
            total = 0;
            average = 0;
            handicap = 0;

            Name.Clear();
            GenderMale.IsChecked = false;
            GenderFemale.IsChecked = false;
            game_one.Clear();
            game_two.Clear();
            game_three.Clear();
            SeriesTotal.Text = total.ToString();
            Average.Text = average.ToString();
            Handicap.Text = handicap.ToString();
            Results.Text = "0";
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}