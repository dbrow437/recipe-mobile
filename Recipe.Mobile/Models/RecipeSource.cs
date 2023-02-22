using Recipe.Mobile.DataTypes;

namespace Recipe.Mobile.Models
{
    public class RecipeSource
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public RecipeSourceTypes SourceType { get; set; }
    }
}