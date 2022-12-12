using System.Collections.ObjectModel;

namespace MauiApp14;

public partial class MainPage : ContentPage
{
    MainPageViewModel vm => BindingContext as MainPageViewModel;
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        vm.Initialize();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        GC.Collect();
    }
}