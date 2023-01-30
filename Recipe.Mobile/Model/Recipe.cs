using Recipe.Mobile.DataTypes;

namespace Recipe.Mobile.Model
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IEnumerable<RecipeSourceTypes> Source { get; set; }
        public IEnumerable<Ingredients> Ingredients { get; set; }
        public IEnumerable<Instructions> Instruction { get; set; }
        //TODO: Decide type for times
        //public int PrepTime { get; set; }
        //public int CookTime { get; set; }
        //public int TotalTime { get; set; }
    }
}

