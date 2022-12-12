namespace MauiApp14;

public partial class DetailPage : ContentPage
{
	DetailPageViewModel vm => BindingContext as DetailPageViewModel;
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	protected override bool OnBackButtonPressed() 
	{
        //if (vm == null)
        //{
        //    vm.Bytes = null;
        //    vm.Item = null;
        //    BindingContext = null;
        //}

        return base.OnBackButtonPressed();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		//if (vm == null)
		//{
		//vm.Bytes = null;
		//vm.Item = null;
		//BindingContext = null;
		//}

		Shell.Current.Navigation.PopAsync();
		//Shell.Current.GoToAsync("..");
	}
}