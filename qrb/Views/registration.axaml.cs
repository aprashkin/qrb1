using System.Threading;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace qrb.Views;

public partial class registration : Window
{
    public registration()
    {
        InitializeComponent();

    }

    private void perehod_na_vhod(object? sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
        Close();
    }
    

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        
        if (Login1.Text == "")
        {
            Login1.Watermark = "Некорректный логин";
            Login1.Foreground = Brushes.Red;
        }
        else
        {
            if (parol1.Text != parol2.Text)
            {
                parol1.Foreground = Brushes.Red;
                parol1.Watermark = "Пароли не совпадают";
                parol2.Foreground = Brushes.Red;
                parol2.Watermark = "Пароли не совпадают";
            }
            else
            {
                if (kaptcha1.Text != "BYGX7CZ6")
                {
                    kaptcha1.Watermark = "Некорректный ввод капчи";
                    kaptcha1.Foreground = Brushes.Red;
                }
                else
                {
                    notificationreg.IsVisible = true;
                }
            }
            
        }

        

        









    }
}