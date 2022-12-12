using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace MauiApp14;

public class MainPageViewModel : BindableBase
{
    public MainPageViewModel()
    {
        Items = new();
        GenerateItems();
    }

    public void Initialize()
    {
        SelectedItem = null;
        RaisePropertyChanged(nameof(SelectedItem));
    }

    private ObservableCollection<CustomModel> _items;
    public ObservableCollection<CustomModel> Items
    {
        get { return _items; }
        set { SetProperty(ref _items, value, nameof(Items)); }
    }

    void GenerateItems()
    {
        for (int i = 0; i < 200; i++)
        {
            Items.Add(new());
        }
    }


    public object SelectedItem { get; set; }

    public Command OnSelectedItemCommand => new(async () => await OnSelectedItem());
    async Task OnSelectedItem()
    {
        if (SelectedItem == null)
            return;

        var parameters = new Dictionary<string, object>
        {
            { "item", SelectedItem }
        };

        await Shell.Current.GoToAsync(nameof(DetailPage), parameters);
    }
}
