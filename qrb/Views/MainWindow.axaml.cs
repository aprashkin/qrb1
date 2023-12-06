using Avalonia.Controls;
using Avalonia.Interactivity;

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
}