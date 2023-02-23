using System;
using Recipe.Mobile.Models;
using Recipe.Mobile.Interfaces;

namespace Recipe.Mobile.ViewModels
{
	public partial class RecipesViewModel : ObservableObject
	{
		[ObservableProperty]
		private ObservableCollection<RecipeDetail> _recipes;
		private IRecipeService _recipeService;

		public RecipesViewModel(IRecipeService recipeService)
		{
			_recipeService = recipeService;
		}

		public async void GetAllRecipes()
		{
            Recipes = new ObservableCollection<RecipeDetail>(await _recipeService.GetRecipes());
        }
	}
}

