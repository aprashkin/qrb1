using System.Collections.ObjectModel;
using System.Reactive;
using System.Windows.Input;
using DynamicData;
using qrb.Models;
using ReactiveUI;

namespace qrb.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    
    public string ShopName { get; set; }
    public string ShopSpecialization { get; set; }
    
    public ObservableCollection<Shop> Shops { get; set; }

    public ICommand ECommand { get; }
    
    public MainWindowViewModel()
    {
        Shops = new ObservableCollection<Shop>();
        ECommand = ReactiveCommand.Create(NewShop);
    }

    private void NewShop()
    {
        Shops.Add(new Shop(ShopName, ShopSpecialization));
    }
    
}