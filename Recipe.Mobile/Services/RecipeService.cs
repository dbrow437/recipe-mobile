using System;
using Newtonsoft.Json;
using Recipe.Mobile.Interfaces;
using Recipe.Mobile.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Recipe.Mobile.Services
{
    //TODO: consume web api
    public class RecipeService : IRecipeService
    {
        List<RecipeDetail> recipeList = new();

        public RecipeDetail CreateRecipe()
        {
            throw new NotImplementedException();
        }

        public RecipeDetail DeleteRecipe()
        {
            throw new NotImplementedException();
        }

        public RecipeDetail GetRecipe()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RecipeDetail>> GetRecipes()
        {
            if (recipeList?.Count > 0)
                return recipeList;

            using var stream = await FileSystem.OpenAppPackageFileAsync("recipedata.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            recipeList = JsonSerializer.Deserialize<List<RecipeDetail>>(contents);

            return recipeList;

        }

        public RecipeDetail UpdateRecipe()
        {
            throw new NotImplementedException();
        }
    }
}
