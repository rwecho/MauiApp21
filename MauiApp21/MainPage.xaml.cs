namespace MauiApp21;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        NavigationUtils.Navigation = this.Navigation;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        NavigationUtils.Navigation?.PushAsync(new SecondPage());
    }
}


public static class NavigationUtils
{

    public static INavigation? Navigation { get; set; }
}
