using Recipe.Mobile.DataTypes;

namespace Recipe.Mobile.Models
{
    public class RecipeDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        //public RecipeSource RecipeSource { get; set; }
        //public Ingredient Ingredients { get; set; }
        //public Instructions Instructions { get; set; }
    }
}

