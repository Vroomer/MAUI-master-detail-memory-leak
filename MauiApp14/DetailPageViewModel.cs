namespace MauiApp14;

public class DetailPageViewModel : BindableBase, IQueryAttributable
{
    public DetailPageViewModel()
    {
        Bytes = new byte[1024 * 400000];
        Array.Clear(Bytes); 
    }

    public byte[] Bytes { get; set; }

    CustomModel _item;
    public CustomModel Item 
    {
        get { return _item; }
        set { SetProperty(ref _item, value, nameof(Item)); }
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Item = query["item"] as CustomModel;
    }
}