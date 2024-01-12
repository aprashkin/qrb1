using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using qrb.Models;

namespace qrb.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void perehod_na_reg(object? sender, RoutedEventArgs e)
    {
        new Registration().Show();
        Close();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Users users =
            Registration.Users.FirstOrDefault(u => u.Username == LogText.Text && u.Password == ParolText.Text);

        if (users is null)
        {
            ErrorBorder.IsVisible = true;

        }
        else
        {
            new MainMenu().Show();
            this.Close();
        }
    }
}