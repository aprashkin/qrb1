using System;
using System.Collections.Generic;
using System.Threading;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

using qrb.Models;

namespace qrb.Views;

public partial class Registration : Window
{
    public static List<Users> Users = new();
    public Registration()
    {
        InitializeComponent();

    }

    
    

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        /*Login1.Text = String.Empty;
        parol1.Text = String.Empty;
        parol2.Text = String.Empty;
        */

        if (string.IsNullOrEmpty(Login1.Text))
        {
            Login1.Watermark = "Необходимо заполнить";
            Login1.Foreground = Brushes.Red;
        }

        if (string.IsNullOrEmpty(parol1.Text))
        {
            parol1.Watermark = "Необходимо заполнить";
            parol1.Foreground = Brushes.Red;
        }

        if (string.IsNullOrEmpty(parol2.Text))
        {
            parol2.Watermark = "Необходимо заполнить";
            parol2.Foreground = Brushes.Red;
        }
        
        if (!string.IsNullOrEmpty(Login1.Text) || !string.IsNullOrEmpty(parol2.Text) ||
            !string.IsNullOrEmpty(parol1.Text))
        {
            return;
        }
        Users users = new Users(Login1.Text, parol1.Text);
        Users.Add(users);

        MainWindow main = new MainWindow();                          
        main.Show();
        this.Close();
    }
    private void perehod_na_vhod(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }

}
