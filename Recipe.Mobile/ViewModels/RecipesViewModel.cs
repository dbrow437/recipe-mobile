using System;
using Recipe.Mobile.Models;
using Recipe.Mobile.Interfaces;

namespace Recipe.Mobile.ViewModels
{
	public partial class RecipesViewModel : BaseViewModel
	{
		public ObservableCollection<RecipeDetail> Recipes { get;  } = new();
        public Command GetRecipesCommand { get; }
        private IRecipeService _recipeService;

		public RecipesViewModel(IRecipeService recipeService)
		{
			_recipeService = recipeService;
			GetRecipesCommand = new Command(async () => await GetAllRecipes());

        }

		public async Task GetAllRecipes()
		{
            try
            {
                if (IsBusy)
                    return;

                IsBusy = true;
                var recipes = await _recipeService.GetRecipes();

                if (Recipes.Count != 0)
                    Recipes.Clear();

                foreach (var recipe in recipes)
                    Recipes.Add(recipe);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get recipes: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
	}
}

