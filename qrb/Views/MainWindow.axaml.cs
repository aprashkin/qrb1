using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace qrb.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void perehod_na_reg(object? sender, RoutedEventArgs e)
    {
        new registration().Show();
        Close();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (LogText.Text == "admin")
        {
            if (ParolText.Text == "admin")
            {
                new MainMenu().Show();
                Close();
            }
            else
            {
                ParolText.Background = Brushes.IndianRed;
                
                ParolText.Watermark = "Неверный пароль";
            }
        }
        else
        {
            LogText.Background = Brushes.IndianRed;
            
            LogText.Watermark = "Неверный логин";
        }
    }
}