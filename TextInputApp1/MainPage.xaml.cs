﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace TextInputApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        private object thatSender;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void textBox1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            thatSender = sender;
            Alphabet.Visibility = Visibility.Visible;
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((Button)thatSender).Content = ((Button)sender).Content;
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

        private void ChoosingWordStart(object sender, Microsoft.Phone.Controls.GestureEventArgs e)
        {
            e.Handled = false;
            ((Button)sender).Background = new SolidColorBrush(Colors.Red);
        }
        private void ChoosingWordFinish(object sender, Microsoft.Phone.Controls.GestureEventArgs e)
        {
            ((Button)sender).Background = new SolidColorBrush(Colors.Transparent);
        }

        private void GestureListener_Flick(object sender, FlickGestureEventArgs e)
        {
            ((Button)sender).Background = new SolidColorBrush(Colors.Transparent);
        }

        private void GestureListener_DragDelta(object sender, DragDeltaGestureEventArgs e)
        {
            
        }
    }
}