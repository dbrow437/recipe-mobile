using Recipe.Mobile.ViewModels;

namespace Recipe.Mobile.Views;

public partial class MainPage : ContentPage
{
	public MainPage(UserViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}

}


