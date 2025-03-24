namespace TequilasRestaurant.Models
{
    public class ProductIngredient
    {
        //join table
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}