using System.Collections;
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
        /*RemoveSelectedShopsCommand = new RelayCommand<IList>(RemoveSelectedShops);*/
    }

    private void NewShop()
    {
        Shops.Add(new Shop(ShopName, ShopSpecialization));
    }
    
    public ICommand RemoveSelectedShopsCommand { get;  }

    private void RemoveSelectedShops(IList selectedShops)
    {
        foreach (Shop shop in selectedShops)
        {
            Shops.Remove(shop);
        }
    }
}