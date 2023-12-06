using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace qrb.Views;

public partial class registration : Window
{
    public registration()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}