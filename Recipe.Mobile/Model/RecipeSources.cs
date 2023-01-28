using Recipe.Mobile.DataTypes;

namespace Recipe.Mobile.Model
{
    public class RecipeSources
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public RecipeSourceTypes Source { get; set; }
    }
}