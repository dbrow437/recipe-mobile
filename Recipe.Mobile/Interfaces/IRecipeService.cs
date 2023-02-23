using Recipe.Mobile.Models;

namespace Recipe.Mobile.Interfaces
{
	public interface IRecipeService
	{
		Task<List<RecipeDetail>> GetRecipes();
		RecipeDetail GetRecipe();
        RecipeDetail CreateRecipe();
        RecipeDetail UpdateRecipe();
        RecipeDetail DeleteRecipe();
    }
}

