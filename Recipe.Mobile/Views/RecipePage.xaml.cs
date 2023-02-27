using Recipe.Mobile.ViewModels;

namespace Recipe.Mobile.Views;

public partial class RecipePage : ContentPage
{
    public RecipePage(RecipesViewModel viewModel)
	{
		BindingContext = viewModel;
        InitializeComponent();
	}
}


