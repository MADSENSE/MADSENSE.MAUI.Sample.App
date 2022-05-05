namespace MADSENSE.MAUI.Sample;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.MainPageViewModel();
	}
}