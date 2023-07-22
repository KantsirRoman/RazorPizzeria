using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty]
    public PizzaModel Pizza { get; set; }

    public float PizzaPrice { get; set; }

    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        PizzaPrice = Pizza.BasePrice;
        if (Pizza.TomatoSauce) PizzaPrice += 20;
        if (Pizza.Cheese) PizzaPrice += 20;
        if (Pizza.Peperoni) PizzaPrice += 25;
        if (Pizza.Mushroom) PizzaPrice += 20;
        if (Pizza.Tuna) PizzaPrice += 20;
        if (Pizza.Pineapple) PizzaPrice += 25;
        if (Pizza.Ham) PizzaPrice += 25;
        if (Pizza.Beef) PizzaPrice += 20;

        return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
    }
    
}