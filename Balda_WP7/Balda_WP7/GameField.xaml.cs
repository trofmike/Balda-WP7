using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Balda_WP7
{
    public partial class GameField : PhoneApplicationPage
    {
        private object thatSender;
        // Constructor
        public GameField()
        {
            InitializeComponent();
        }

        private void textBox1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content == null)
            {
                thatSender = sender;
                Alphabet.Visibility = Visibility.Visible;
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)thatSender).Content = ((Button)sender).Content;
            ((Button)thatSender).Background = new SolidColorBrush(Colors.Green);
            Alphabet.Visibility = (Alphabet.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible);
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);
            if (Alphabet.Visibility == Visibility.Visible)
            {
                Alphabet.Visibility = Visibility.Collapsed;
                e.Cancel = true;
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (((Button)sender).Content != null)
            {
                ((Button)sender).Background = App.Current.Resources["PhoneBorderBrush"] as SolidColorBrush;
            }
        }
    }
}