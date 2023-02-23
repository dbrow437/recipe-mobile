using Recipe.Mobile.ViewModels;

namespace Recipe.Mobile.Views;

public partial class RecipePage : ContentPage
{

    public RecipePage(RecipesViewModel recipesViewModel)
	{
		BindingContext = recipesViewModel;
        InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        var vm = BindingContext as RecipesViewModel;
        vm.GetAllRecipes();
    }
}
