using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages;

public class Pizza : PageModel
{
    public List<PizzaModel> fakePizzaDB =new List<PizzaModel>()
    {
        new PizzaModel()
		{
			ImageTitle = "Margerita",
			PizzaName = "Margerita",
			BasePrice = 30,
			TomatoSauce = true,
			Cheese = true,
			FinalPrice = 140
		},
		new PizzaModel() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 30, TomatoSauce = true,  FinalPrice = 100},
        new PizzaModel() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian",   BasePrice = 30, TomatoSauce = true,  FinalPrice = 110},
        new PizzaModel() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 30, TomatoSauce = true,  FinalPrice = 110},
        new PizzaModel() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 30, TomatoSauce = true,  FinalPrice = 120},
        new PizzaModel() { ImageTitle = "Mushroom", PizzaName = "Mushroom",   BasePrice = 30, TomatoSauce = true,  FinalPrice = 130},
        new PizzaModel() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 30, TomatoSauce = true,  FinalPrice = 140},
        new PizzaModel() { ImageTitle = "Seafood", PizzaName = "Seafood",     BasePrice = 30, TomatoSauce = true,  FinalPrice = 150},
        new PizzaModel() { ImageTitle ="Vegetarian",PizzaName = "Vegetarian", BasePrice = 30, TomatoSauce = true,  FinalPrice = 170}
    } ;
    public void OnGet()
    {
        
    }
}