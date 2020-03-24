using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

namespace oop_lab11
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("\\+\\d{12}$");
            if (regex.IsMatch(phone.Text)) phoneText.Foreground = Brushes.Green;
            else phoneText.Foreground = Brushes.Red;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("^[А-ГҐДЕЄЖЗИІЇЙК-Я]{2}\\d{6}$");
            if (regex.IsMatch(passport.Text)) passportText.Foreground = Brushes.Green;
            else passportText.Foreground = Brushes.Red;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(interval.Text);
            if (number >= 10311 && number <= 89645) intervalText.Foreground = Brushes.Green;
            else intervalText.Foreground = Brushes.Red;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("[А-ГҐДЕЄЖЗИІЇЙК-Я][а-гґдеєжзиіїйк-я]+");
            if (regex.IsMatch(name.Text)) nameText.Foreground = Brushes.Green;
            else nameText.Foreground = Brushes.Red;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            if (regex.IsMatch(time.Text)) timeText.Foreground = Brushes.Green;
            else timeText.Foreground = Brushes.Red;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("^[A-Z0-9+_.-]+@[A-Z0-9.-]+$");
            if (regex.IsMatch(time.Text)) timeText.Foreground = Brushes.Green;
            else timeText.Foreground = Brushes.Red;
        }
    }
}
