using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using qrb.ViewModels;

namespace qrb.Views;

public partial class magazines : Window
{
    public magazines()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

}