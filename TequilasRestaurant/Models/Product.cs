﻿namespace TequilasRestaurant.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; } //a product belongs to category
        public ICollection<OrderItem> OrderItems { get; set; } //a product can be in many order items
        public ICollection<ProductIngredient>? ProductIngredients { get; set; } //a product can have many ingredients
    }
}