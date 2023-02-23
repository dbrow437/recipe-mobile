using System;
using Newtonsoft.Json;
using Recipe.Mobile.Interfaces;
using Recipe.Mobile.Models;

namespace Recipe.Mobile.Services
{
    //TODO: consume web api
    public class RecipeService : IRecipeService
    {
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
            var recipeData = await FileSystem.OpenAppPackageFileAsync("recipedata.json");
            var reader = new StreamReader(recipeData);
            string readToEnd = reader.ReadToEnd();
            var recipeDataList = JsonConvert.DeserializeObject<List<RecipeDetail>>(readToEnd);

            return recipeDataList;  
        }

        public RecipeDetail UpdateRecipe()
        {
            throw new NotImplementedException();
        }
    }
}
