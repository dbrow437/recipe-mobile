namespace Recipe.Mobile.Interfaces
{
	public interface IRecipeService
	{
		List<Models.Recipe> GetRecipes();
		Models.Recipe GetRecipe();
		Models.Recipe CreateRecipe();
		Models.Recipe UpdateRecipe();
		Models.Recipe DeleteRecipe();
    }
}

